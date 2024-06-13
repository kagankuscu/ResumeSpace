using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.EducationDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business.Concrete
{
  class EducationService : IEducationService
  {
    private readonly IEducationRepository _repository;
    private readonly IMapper _mapper;

    public EducationService(IMapper mapper, IEducationRepository repository)
    {
      _mapper = mapper;
      _repository = repository;
    }

    public EducationForGetWithResumesDto AddEducation(EducationForAddDto educationDto)
    {
        Education? education = _mapper.Map<Education>(educationDto);
        education = _repository.AddEducation(education);
        return _mapper.Map<EducationForGetWithResumesDto>(education);
    }

    public List<EducationForGetDto> GetAllEducation()
    {
      IQueryable<Education> educations = _repository.GetAll();
      return _mapper.Map<List<EducationForGetDto>>(educations);
    }

    public List<EducationForGetWithResumesDto> GetAllEducationWithResumes()
    {
      IQueryable<Education> educations = _repository.GetAllEducationWithResumes();
      return _mapper.Map<List<EducationForGetWithResumesDto>>(educations); 
    }

    public List<EducationForGetWithResumesDto> GetAllEducationWithResumes(Guid userId)
    {
      IQueryable<Education> educations = _repository.GetAllEducationWithResumes(userId);
      return _mapper.Map<List<EducationForGetWithResumesDto>>(educations); 
    }

    public void RemoveEducation(Guid guid)
    {
      _repository.RemoveEducation(guid);
    }

    public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

    public EducationForGetWithResumesDto UpdateEducation(EducationForUpdateDto educationDto)
    {
      Education? education = _repository.UpdateEducation(_mapper.Map<Education>(educationDto));

      return _mapper.Map<EducationForGetWithResumesDto>(education);
    }
  }
}
