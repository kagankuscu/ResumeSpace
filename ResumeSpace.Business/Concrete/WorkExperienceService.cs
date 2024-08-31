using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.WorkExperienceDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Business.Concrete;
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

      return _mapper.Map<WorkExperienceForGetWithResumesDto>(_repository.AddWorkExperience(workExperience));
   }

    public List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes() => _mapper.Map<List<WorkExperienceForGetWithResumesDto>>(_repository.GetAllWorkExperienceWithResumes());

    public List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes(Guid userId) => _mapper.Map<List<WorkExperienceForGetWithResumesDto>>(_repository.GetAllWorkExperienceWithResumes(userId));

    public void RemoveWorkExperience(Guid guid) => _repository.RemoveWorkExperience(guid);

    public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

    public WorkExperienceForGetWithResumesDto UpdateWorkExperience(WorkExperienceForUpdateDto workExperienceDto)
    {
      WorkExperience? real = _repository.GetAll(x => x.Guid == workExperienceDto.Guid).Include(x => x.ResumesWorkExperiences).FirstOrDefault();
      foreach (var item in real.ResumesWorkExperiences)
      {
          if (workExperienceDto.ResumesWorkExperiences.Select(x => x.ResumeId).Contains(item.ResumeId))
              workExperienceDto.ResumesWorkExperiences.Remove(item);
      }
      return _mapper.Map<WorkExperienceForGetWithResumesDto>(_repository.UpdateWorkExperience(_mapper.Map(workExperienceDto, real)));
    }
}
