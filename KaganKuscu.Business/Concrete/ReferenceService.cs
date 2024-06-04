using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ReferenceDto;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Business.Concrete
{
  class ReferenceService : IReferenceService
  {
    private readonly IRepository<Reference> _repository;
    private readonly IResumeService _resumeService;
    private readonly IMapper _mapper;

    public ReferenceService(IRepository<Reference> repository, IMapper mapper, IResumeService resumeService)
    {
      _repository = repository;
      _mapper = mapper;
      _resumeService = resumeService;
    }

    public void Add(Reference entity)
    {
      throw new NotImplementedException();
    }

    public ReferenceForGetWithResumesDto AddReference(ReferenceForAddDto referenceDto)
    {
      Reference reference = _mapper.Map<Reference>(referenceDto);
      _repository.Add(reference);
      ReferenceForGetWithResumesDto returnData = _mapper.Map<ReferenceForGetWithResumesDto>(reference);
      returnData.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesReferences.Any(re => re.ReferenceId == reference.Id)).ToList());
      return returnData;
    }

    public void AddRange(IEnumerable<Reference> entities)
    {
      throw new NotImplementedException();
    }

    public IQueryable<Reference> GetAll()
    {
      throw new NotImplementedException();
    }

    public List<ReferenceForGetDto> GetAllReference()
    {
      List<Reference> references = _repository.GetAll().ToList();

      return _mapper.Map<List<ReferenceForGetDto>>(references);
    }

    public List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes()
    {
      List<ReferenceForGetWithResumesDto> references = _repository.GetAll()
        .Select(e => new ReferenceForGetWithResumesDto
            {
            Guid = e.Guid,
            Name = e.Name, 
            CompanyName = e.CompanyName,
            Quote = e.Quote,
            Title = e.Title,
            IsActive = e.IsActive,
            Resumes = _mapper.Map<List<ResumeForGetDto>>(e.ResumesReferences.Select(re => re.Resume).ToList()) 
            }).ToList();

      return references; 
    }

    public List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes(Guid userId)
    {
      List<ReferenceForGetWithResumesDto> references = _repository.GetAll().Where(e => e.AppUserId == userId)
        .Select(e => new ReferenceForGetWithResumesDto
            {
            Guid = e.Guid,
            Name = e.Name, 
            CompanyName = e.CompanyName,
            Quote = e.Quote,
            Title = e.Title,
            IsActive = e.IsActive,
            Resumes = _mapper.Map<List<ResumeForGetDto>>(e.ResumesReferences.Select(re => re.Resume).ToList()) 
            }).ToList();

      return references; 
    }

    public Reference? GetById(int id)
    {
      return _repository.GetById(id);
    }

    public Reference? GetById(Guid guid)
    {
      return _repository.GetAll(r => r.Guid == guid).FirstOrDefault();
    }

    public void Remove(Reference entity)
    {
      _repository.Remove(entity);
    }

    public void Remove(int id)
    {
      Reference? reference = _repository.GetAll(e => e.Id == id).SingleOrDefault(); 
      if (reference is null)
        return;

      Remove(reference);
    }

    public void Remove(Guid guid)
    {
      Reference? reference = _repository.GetAll(e => e.Guid == guid).SingleOrDefault(); 
      if (reference is null)
        return;

      Remove(reference);
    }

    public bool ToggleStatus(Guid guid)
    {
      Reference? eduction = _repository.GetById(guid);
      if (eduction is null)
        return false;

      eduction.IsActive = !eduction.IsActive;
      _repository.Update(eduction);
      return true;
    }

    public void Update(Reference entity)
    {
      _repository.Update(entity);
    }

    public void Update(Guid guid)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }

    public ReferenceForGetWithResumesDto UpdateReference(ReferenceForUpdateDto referenceDto)
    {
      Reference? reference = _repository.GetAll(e => e.Guid == referenceDto.Guid).Include(e => e.ResumesReferences).FirstOrDefault();

      if (reference is null)
        return new ReferenceForGetWithResumesDto();

      reference.ResumesReferences.Clear();

      foreach (var item in referenceDto.ResumesReferences)
      {
        if (!reference.ResumesReferences.Select(re => re.ResumeId).Contains(item.ResumeId))
          reference.ResumesReferences.Add(item);
      }

      reference.Name = referenceDto.Name;
      reference.CompanyName = referenceDto.CompanyName;
      reference.Quote = referenceDto.Quote;
      reference.Title = referenceDto.Title;
      reference.IsActive = referenceDto.IsActive;
      Update(reference);

      var returnDto = _mapper.Map<ReferenceForGetWithResumesDto>(reference);
      returnDto.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesReferences.Any(re => re.ReferenceId == reference.Id)).ToList());
      return returnDto;
    }

    public async Task<bool> AddImage(IFormCollection form)
    {
      IFormFile? image = form.Files["image"];
      string imageFilename;
      
      string? formGuid = form["guid"];
      if (formGuid is null)
        return false;

      Reference? real = GetById(Guid.Parse(formGuid));

      if (real is null)
        return false;

      if (image is null)
        return false;


      string serverImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Reference");

      if (!Directory.Exists(serverImagePath))
        Directory.CreateDirectory(serverImagePath);

      imageFilename = Helper.RandomStringGenerator(3) + "-" + real.CompanyName + "-" + real.Name +  Path.GetExtension(image.FileName);

      string imagePath = Path.Combine(serverImagePath, imageFilename);

      using (var stream = new FileStream(imagePath, FileMode.Create))
      {
        await image.CopyToAsync(stream);
      }

      real.ImagePath = $"{imageFilename}";
      return true;
    }
    }
}
