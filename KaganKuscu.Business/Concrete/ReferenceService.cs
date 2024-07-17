using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ReferenceDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Concrete;
using KaganKuscu.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KaganKuscu.Business.Concrete
{
  class ReferenceService : IReferenceService
  {
    private readonly IReferenceRepository _repository;
    private readonly IMapper _mapper;

    public ReferenceService(IMapper mapper, IReferenceRepository repository)
    {
      _mapper = mapper;
      _repository = repository;
    }

    public ReferenceForGetWithResumesDto AddReference(ReferenceForAddDto referenceDto)
    {
      Reference? reference = _mapper.Map<Reference>(referenceDto);
      reference = _repository.AddReference(reference);
      return _mapper.Map<ReferenceForGetWithResumesDto>(reference);
    }

    public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

    public ReferenceForGetWithResumesDto UpdateReference(ReferenceForUpdateDto referenceDto)
    {
      Reference? real = _repository.GetAll(x => x.Guid == referenceDto.Guid).Include(x => x.ResumesReferences).FirstOrDefault();
      foreach (var item in real.ResumesReferences)
      {
          if (referenceDto.ResumesReferences.Select(re => re.ResumeId).Contains(item.ResumeId))
              referenceDto.ResumesReferences.Remove(item);
      }
      var f = _mapper.Map(referenceDto, real);
      return _mapper.Map<ReferenceForGetWithResumesDto>(_repository.UpdateReference(f));
    }

    public async Task<bool> AddImage(IFormCollection form)
    {
      IFormFile? image = form.Files["image"];
      string imageFilename;

      string? formGuid = form["guid"];
      if (formGuid is null)
        return false;

      Reference? real = _repository.GetAll(x => x.Guid == Guid.Parse(formGuid)).Include(x => x.ResumesReferences).ThenInclude(x => x.Resume).ThenInclude(x => x.AppUser).FirstOrDefault();

      if (real is null)
        return false;

      if (image is null)
        return false;

      string username = real.ResumesReferences.Select(x => x.Resume).Select(x => x.AppUser).FirstOrDefault().UserName;
      string serverImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Reference", username);

      if (!Directory.Exists(serverImagePath))
        Directory.CreateDirectory(serverImagePath);

      imageFilename = Helper.RandomStringGenerator(3) + "-" + real.CompanyName + "-" + real.Name + Path.GetExtension(image.FileName);

      string imagePath = Path.Combine(serverImagePath, imageFilename);

      using (var stream = new FileStream(imagePath, FileMode.Create))
      {
        await image.CopyToAsync(stream);
      }

      real.ImagePath = $"/img/Reference/{username}/{imageFilename}";
      _repository.UpdateReference(real);
      return true;
    }

    public List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes()
    {
      IQueryable<Reference> references = _repository.GetAllReferenceWithResumes();
      return _mapper.Map<List<ReferenceForGetWithResumesDto>>(references);
    }

    public List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes(Guid userId)
    {
      return _mapper.Map<List<ReferenceForGetWithResumesDto>>(_repository.GetAllReferenceWithResumes(userId));
    }

    public void RemoveReference(Guid guid) => _repository.RemoveReference(guid);
  }
}
