using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Dtos.WorkExperienceDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

public class WorkExperienceService : IWorkExperienceService
{
    private readonly IRepository<WorkExperience> _repository;
    private readonly IResumeService _resumeService;
    private readonly IMapper _mapper;

    public WorkExperienceService(IRepository<WorkExperience> repository, IMapper mapper, IResumeService resumeService)
    {
        _repository = repository;
        _mapper = mapper;
        _resumeService = resumeService;
    }


    public void Add(WorkExperience entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<WorkExperience> entities)
    {
        throw new NotImplementedException();
    }

    public WorkExperienceForGetWithResumesDto AddWorkExperience(WorkExperienceForAddDto workExperienceDto)
    {
      WorkExperience workExperience = _mapper.Map<WorkExperience>(workExperienceDto);
      _repository.Add(workExperience);
      WorkExperienceForGetWithResumesDto returnData = _mapper.Map<WorkExperienceForGetWithResumesDto>(workExperience);
      returnData.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesEducations.Any(re => re.EducationId == workExperience.Id)).ToList());
      return returnData;

    }

    public IQueryable<WorkExperience> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<WorkExperienceForGetDto> GetAllWorkExperience()
    {
        throw new NotImplementedException();
    }

    public List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes()
    {
      List<WorkExperienceForGetWithResumesDto> educations = _repository.GetAll()
        .Select(we => new WorkExperienceForGetWithResumesDto 
            {
            Guid = we.Guid,
            Name = we.Name, 
            StartDate = we.StartDate,
            EndDate = we.EndDate,
            Description = we.Description,
            Role = we.Role,
            IsActive = we.IsActive,
            Resumes = _mapper.Map<List<ResumeForGetDto>>(we.ResumesWorkExperiences.Select(re => re.Resume).ToList()) 
            }).ToList();

      return educations; 
    }

    public List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes(Guid userId)
    {
      List<WorkExperienceForGetWithResumesDto> educations = _repository.GetAll()
        .Where(we => we.AppUserId == userId)
        .Select(we => new WorkExperienceForGetWithResumesDto 
            {
            Guid = we.Guid,
            Name = we.Name, 
            StartDate = we.StartDate,
            EndDate = we.EndDate,
            Description = we.Description,
            Role = we.Role,
            IsActive = we.IsActive,
            Resumes = _mapper.Map<List<ResumeForGetDto>>(we.ResumesWorkExperiences.Select(re => re.Resume).ToList()) 
            }).ToList();

      return educations; 
    }

    public WorkExperience? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public WorkExperience? GetById(Guid guid)
    {
        throw new NotImplementedException();
    }

    public void Remove(WorkExperience entity)
    {
      _repository.Remove(entity);
    }

    public void Remove(int id)
    {
      WorkExperience? workExperience = _repository.GetAll(e => e.Id == id).SingleOrDefault(); 
      if (workExperience is null)
        return;

      Remove(workExperience);
    }

    public void Remove(Guid guid)
    {
      WorkExperience? workExperience = _repository.GetAll(e => e.Guid == guid).SingleOrDefault(); 
      if (workExperience is null)
        return;

      Remove(workExperience);
    }

    public bool ToggleStatus(Guid guid)
    {
      WorkExperience? workExperience = _repository.GetById(guid);
      if (workExperience is null)
        return false;

      workExperience.IsActive = !workExperience.IsActive;
      _repository.Update(workExperience);
      return true;
    }

    public void Update(WorkExperience entity)
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

    public WorkExperienceForGetWithResumesDto UpdateWorkExperience(WorkExperienceForUpdateDto workExperienceDto)
    {
      WorkExperience? workExperience = _repository.GetAll(we => we.Guid == workExperienceDto.Guid).Include(we => we.ResumesWorkExperiences).FirstOrDefault();

      if (workExperience is null)
        return new WorkExperienceForGetWithResumesDto();

      workExperience.ResumesWorkExperiences.Clear();

      foreach (var item in workExperienceDto.ResumesWorkExperiences)
      {
        if (!workExperience.ResumesWorkExperiences.Select(re => re.ResumeId).Contains(item.ResumeId))
          workExperience.ResumesWorkExperiences.Add(item);
      }

      workExperience.Name = workExperienceDto.Name;
      workExperience.StartDate = DateTime.Parse(workExperienceDto.StartDate);
      workExperience.EndDate = DateTime.Parse(workExperienceDto.EndDate);
      workExperience.Description = workExperienceDto.Description;
      workExperience.Role = workExperienceDto.Role;
      workExperience.IsActive = workExperienceDto.IsActive;
      Update(workExperience);

      var returnDto = _mapper.Map<WorkExperienceForGetWithResumesDto>(workExperience);
      returnDto.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesWorkExperiences.Any(re => re.WorkExperienceId == workExperience.Id)).ToList());
      return returnDto;

    }
}
