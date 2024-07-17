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
        if (UpdateStatusForUserGuid(Guid.Parse(resume.AppUserId)))
            Update(resume);
        return true;
    }

    public Resume? UpdateResume(Resume resume)
    {
        Resume? real = GetById(resume.Guid);
        if (real is null)
            return null;

        real.Email = resume.Email;
        real.ResumeName = resume.ResumeName;
        real.FullName = resume.FullName;
        real.Title = resume.Title;
        real.Phone = resume.Phone;
        real.SecondPhone = resume.SecondPhone;
        real.Address = resume.Address;
        real.BirthDate = resume.BirthDate;
        real.About = resume.About;

        Update(real);

        return real;
    }

    public bool UpdateStatusForUserGuid(Guid guid)
    {
        try
        {
            IQueryable<Resume> resumes = GetAllByAppUserGuid(guid);
            foreach (Resume resume in resumes)
            {
                resume.IsActive = false;
                Update(resume);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
}
