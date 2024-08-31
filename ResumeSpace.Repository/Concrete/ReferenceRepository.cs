using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Repository.Abstract;

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
        Update(reference);
        return  GetAllReferenceWithResumes().Where(x => x.Guid == reference.Guid).Include(x => x.ResumesReferences).FirstOrDefault();
    }
}
