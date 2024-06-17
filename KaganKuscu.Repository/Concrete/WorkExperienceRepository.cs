using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Repository.Concrete;

public class WorkExperienceRepository : Repository<WorkExperience>, IWorkExperienceRepository
{
    public WorkExperienceRepository(AppDbContext context) : base(context)
    {
    }

    public WorkExperience? AddWorkExperience(WorkExperience workExperience)
    {
        Add(workExperience);
        return GetAllWorkExperienceWithResumes().Where(x => x.Guid == workExperience.Guid).FirstOrDefault();
    }

    public IQueryable<WorkExperience> GetAllWorkExperienceWithResumes() => GetAll().Include(x => x.ResumesWorkExperiences).ThenInclude(x => x.Resume);

    public IQueryable<WorkExperience> GetAllWorkExperienceWithResumes(Guid userId) => GetAll().Where(x => x.AppUserId == userId).Include(x => x.ResumesWorkExperiences).ThenInclude(x => x.Resume);

    public bool ToggleStatus(Guid guid)
    {
        WorkExperience? workExperience = GetById(guid);
        if (workExperience is null)
            return false;

        workExperience.IsActive = !workExperience.IsActive;
        Update(workExperience);
        return true;
    }

    public WorkExperience? UpdateWorkExperience(WorkExperience workExperience)
    {
       WorkExperience? real = GetAllWorkExperienceWithResumes().Where(x => x.Guid == workExperience.Guid).FirstOrDefault();

        if (real is null)
            return null;

        real.ResumesWorkExperiences.Clear();

        foreach (var item in workExperience.ResumesWorkExperiences)
        {
            if (!real.ResumesWorkExperiences.Select(x => x.ResumeId).Contains(item.ResumeId))
                real.ResumesWorkExperiences.Add(item);
        }

        real.Name = workExperience.Name;
        real.StartDate = workExperience.StartDate;
        real.EndDate = workExperience.EndDate;
        real.Description = workExperience.Description;
        real.Role = workExperience.Role;
        real.IsActive = workExperience.IsActive;
        Update(real);

        return GetAllWorkExperienceWithResumes().Where(x => x.Guid == workExperience.Guid).FirstOrDefault();
    }
}
