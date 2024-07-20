using KaganKuscu.DataAccess;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Repository.Concrete;

public class ResumeRepository : Repository<Resume>, IResumeRepository
{
    public ResumeRepository(AppDbContext context) : base(context)
    {
    }

    public Resume? AddResume(Resume resume)
    {
        Add(resume);
        return resume;
    }

    public IQueryable<Resume> GetAllByAppUserGuid(Guid guid) => GetAll(x => x.AppUserId == guid.ToString());

    public IQueryable<Resume> GetAllResume() => GetAll();

    public IQueryable<Resume> GetAllResumeWithDetail()
    {
        return GetAll();
    }

    public void RemoveResume(Guid guid) => Remove(guid);

    public bool ToggleStatus(Guid guid)
    {
        Resume? resume = GetById(guid);
        if (resume is null)
            return false;

        resume.IsActive = !resume.IsActive;
        if (UpdateStatusForUserGuid(Guid.Parse(resume.AppUserId), resume.Guid))
            Update(resume);
        return true;
    }

    public Resume? UpdateResume(Resume resume)
    {
        Update(resume);

        return resume;
    }

    public bool UpdateStatusForUserGuid(Guid guid, Guid resumeGuid)
    {
        try
        {
            IQueryable<Resume> resumes = GetAllByAppUserGuid(guid)
                .Where(x => x.Guid != resumeGuid)
                .Where(x => x.IsActive);

            var resumss = resumes.ToList();
            foreach (Resume resume in resumes)
            {
                resume.IsActive = false;
            }
            UpdateRange(resumes);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
