using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;

namespace ResumeSpace.Repository.Concrete;

public interface IReferenceRepository : IRepository<Reference>
{
    Reference? AddReference(Reference reference);
    IQueryable<Reference> GetAllReferenceWithResumes();
    IQueryable<Reference> GetAllReferenceWithResumes(Guid userId);
    bool ToggleStatus(Guid guid); 
    void RemoveReference(Guid guid);
    Reference? UpdateReference(Reference reference);

}
