using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Repository.Concrete;

public class EducationRepository : Repository<Education>, IEducationRepository
{
    public EducationRepository(AppDbContext context) : base(context)
    {
    }

    public Education? AddEducation(Education education)
    {
        Add(education);
        Education? edu = GetAllEducationWithResumes().Where(x => x.Id == education.Id).FirstOrDefault();

        if (edu is null)
            return null; 

        return edu;
    }

    public IQueryable<Education> GetAllEducationWithResumes()
    {
        return GetAll().Include(x => x.ResumesEducations).ThenInclude(x => x.Resume);
    }

    public IQueryable<Education> GetAllEducationWithResumes(Guid userId)
    {
        return GetAll().Where(x => x.AppUserId == userId).Include(x => x.ResumesEducations).ThenInclude(x => x.Resume);
    }

    public void RemoveEducation(Guid guid) => Remove(guid);

    public bool ToggleStatus(Guid guid)
    {
      Education? eduction = GetById(guid);
      if (eduction is null)
        return false;

      eduction.IsActive = !eduction.IsActive;
      Update(eduction);
      return true;
    }

    public Education? UpdateEducation(Education education)
    {
      Update(education);

      return GetAllEducationWithResumes().Where(x => x.Id == education.Id).FirstOrDefault();
    }
}