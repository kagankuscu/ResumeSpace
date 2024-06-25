using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.WorkExperienceDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business.Concrete;
public class WorkExperienceService : IWorkExperienceService
{
    private readonly IWorkExperienceRepository _repository;
    private readonly IMapper _mapper;

    public WorkExperienceService(IWorkExperienceRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public WorkExperienceForGetWithResumesDto AddWorkExperience(WorkExperienceForAddDto workExperienceDto)
    {
      WorkExperience workExperience = _mapper.Map<WorkExperience>(workExperienceDto);
      _repository.Add(workExperience);

      return _mapper.Map<WorkExperienceForGetWithResumesDto>(workExperience);
   }

    public List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes() => _mapper.Map<List<WorkExperienceForGetWithResumesDto>>(_repository.GetAllWorkExperienceWithResumes());

    public List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes(Guid userId) => _mapper.Map<List<WorkExperienceForGetWithResumesDto>>(_repository.GetAllWorkExperienceWithResumes(userId));

    public void RemoveWorkExperience(Guid guid) => _repository.RemoveWorkExperience(guid);

    public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

    public WorkExperienceForGetWithResumesDto UpdateWorkExperience(WorkExperienceForUpdateDto workExperienceDto)
    {
      WorkExperience? workExperience = _mapper.Map<WorkExperience>(workExperienceDto);
      return _mapper.Map<WorkExperienceForGetWithResumesDto>(_repository.UpdateWorkExperience(workExperience));
    }
}
