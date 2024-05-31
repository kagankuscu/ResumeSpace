using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.EducationDto;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Business.Concrete
{
  class EducationService : IEducationService
  {
    private readonly IRepository<Education> _repository;
    private readonly IResumeService _resumeService;
    private readonly IMapper _mapper;

    public EducationService(IRepository<Education> repository, IMapper mapper, IResumeService resumeService)
    {
      _repository = repository;
      _mapper = mapper;
      _resumeService = resumeService;
    }

    public void Add(Education entity)
    {
      throw new NotImplementedException();
    }

    public EducationForGetWithResumesDto AddEducation(EducationForAddDto educationDto)
    {
      Education education = _mapper.Map<Education>(educationDto);
      _repository.Add(education);
      EducationForGetWithResumesDto returnData = _mapper.Map<EducationForGetWithResumesDto>(education);
      returnData.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesEducations.Any(re => re.EducationId == education.Id)).ToList());
      return returnData;
    }

    public void AddRange(IEnumerable<Education> entities)
    {
      throw new NotImplementedException();
    }

    public IQueryable<Education> GetAll()
    {
      throw new NotImplementedException();
    }

    public List<EducationForGetDto> GetAllEducation()
    {
      List<Education> educations = _repository.GetAll().ToList();

      return _mapper.Map<List<EducationForGetDto>>(educations);
    }

    public List<EducationForGetWithResumesDto> GetAllEducationWithResumes()
    {
      List<EducationForGetWithResumesDto> educations = _repository.GetAll()
        .Select(e => new EducationForGetWithResumesDto
            {
            Guid = e.Guid,
            Name = e.Name, 
            StartDate = e.StartDate,
            EndDate = e.EndDate,
            Role = e.Role,
            IsActive = e.IsActive,
            Resumes = _mapper.Map<List<ResumeForGetDto>>(e.ResumesEducations.Select(re => re.Resume).ToList()) 
            }).ToList();

      return educations; 
    }

    public List<EducationForGetWithResumesDto> GetAllEducationWithResumes(Guid userId)
    {
      List<EducationForGetWithResumesDto> educations = _repository.GetAll().Where(e => e.AppUserId == userId)
        .OrderByDescending(e => e.EndDate)
        .Select(e => new EducationForGetWithResumesDto
            {
            Guid = e.Guid,
            Name = e.Name, 
            StartDate = e.StartDate,
            EndDate = e.EndDate,
            Role = e.Role,
            IsActive = e.IsActive,
            Resumes = _mapper.Map<List<ResumeForGetDto>>(e.ResumesEducations.Select(re => re.Resume).ToList()) 
            }).ToList();

      return educations; 
    }

    public Education? GetById(int id)
    {
      throw new NotImplementedException();
    }

    public Education? GetById(Guid guid)
    {
      throw new NotImplementedException();
    }

    public void Remove(Education entity)
    {
      _repository.Remove(entity);
    }

    public void Remove(int id)
    {
      Education? education = _repository.GetAll(e => e.Id == id).SingleOrDefault(); 
      if (education is null)
        return;

      Remove(education);
    }

    public void Remove(Guid guid)
    {
      Education? education = _repository.GetAll(e => e.Guid == guid).SingleOrDefault(); 
      if (education is null)
        return;

      Remove(education);
    }

    public bool ToggleStatus(Guid guid)
    {
      Education? eduction = _repository.GetById(guid);
      if (eduction is null)
        return false;

      eduction.IsActive = !eduction.IsActive;
      _repository.Update(eduction);
      return true;
    }

    public void Update(Education entity)
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

    public EducationForGetWithResumesDto UpdateEducation(EducationForUpdateDto educationDto)
    {
      Education? education = _repository.GetAll(e => e.Guid == educationDto.Guid).Include(e => e.ResumesEducations).FirstOrDefault();

      if (education is null)
        return new EducationForGetWithResumesDto();

      education.ResumesEducations.Clear();

      foreach (var item in educationDto.ResumesEducations)
      {
        if (!education.ResumesEducations.Select(re => re.ResumeId).Contains(item.ResumeId))
          education.ResumesEducations.Add(item);
      }

      education.Name = educationDto.Name;
      education.StartDate = DateTime.Parse(educationDto.StartDate);
      education.EndDate = DateTime.Parse(educationDto.EndDate);
      education.Role = educationDto.Role;
      education.IsActive = educationDto.IsActive;
      Update(education);

      var returnDto = _mapper.Map<EducationForGetWithResumesDto>(education);
      returnDto.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesEducations.Any(re => re.EducationId == education.Id)).ToList());
      return returnDto;
    }
  }
}
