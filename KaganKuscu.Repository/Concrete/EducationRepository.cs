using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Repository.Concrete;

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
      Education? real = GetById(education.Id);
      if (real is null)
        return null;

      education.ResumesEducations.Clear();

      foreach (var item in education.ResumesEducations)
      {
        if (!education.ResumesEducations.Select(re => re.ResumeId).Contains(item.ResumeId))
          education.ResumesEducations.Add(item);
      }

      real.Name = education.Name;
      real.StartDate = education.StartDate;
      real.EndDate = education.EndDate;
      real.Role = education.Role;
      real.IsActive = education.IsActive;
      Update(education);

      return GetAllEducationWithResumes().Where(x => x.Id == education.Id).FirstOrDefault();
    }
}