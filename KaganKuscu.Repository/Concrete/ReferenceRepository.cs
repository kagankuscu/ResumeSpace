using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Repository.Abstract;

public class ReferenceRepository : Repository<Reference>, IReferenceRepository
{
    public ReferenceRepository(AppDbContext context) : base(context)
    {
    }

    public Reference? AddReference(Reference reference)
    {
        Add(reference);
        Reference? refer = GetAllReferenceWithResumes().Where(x => x.Id == reference.Id).FirstOrDefault();
        if (reference is null)
            return null;

        return refer;
    }

    public IQueryable<Reference> GetAllReferenceWithResumes()
    {
        return GetAll().Include(x => x.ResumesReferences).ThenInclude(x => x.Resume);
    }

    public IQueryable<Reference> GetAllReferenceWithResumes(Guid userId)
    {
        return GetAll().Where(x => x.AppUserId == userId).Include(x => x.ResumesReferences).ThenInclude(x => x.Resume);
    }

    public void RemoveReference(Guid guid) => Remove(guid);

    public bool ToggleStatus(Guid guid)
    {
        Reference? reference = GetById(guid);
        if (reference is null)
            return false;

        reference.IsActive = !reference.IsActive;
        Update(reference);
        return true;
    }

    public Reference? UpdateReference(Reference reference)
    {
        Reference? real = GetAllReferenceWithResumes().Where(x => x.Guid == reference.Guid).FirstOrDefault();

        if (real is null)
            return null;

        real.ResumesReferences.Clear();

        foreach (var item in reference.ResumesReferences)
        {
            if (!real.ResumesReferences.Select(re => re.ResumeId).Contains(item.ResumeId))
                real.ResumesReferences.Add(item);
        }
        Update(real);
        return  GetAllReferenceWithResumes().Where(x => x.Guid == reference.Guid).FirstOrDefault();
    }
}
