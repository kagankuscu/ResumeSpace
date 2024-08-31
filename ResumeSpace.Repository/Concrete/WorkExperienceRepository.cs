using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Repository.Concrete;

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

    public void RemoveWorkExperience(Guid guid) => Remove(guid);

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
        Update(workExperience);

        return GetAllWorkExperienceWithResumes().Where(x => x.Guid == workExperience.Guid).FirstOrDefault();
    }
}
