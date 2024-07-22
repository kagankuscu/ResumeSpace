using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Repository.Concrete;

public interface IReferenceRepository : IRepository<Reference>
{
    Reference? AddReference(Reference reference);
    IQueryable<Reference> GetAllReferenceWithResumes();
    IQueryable<Reference> GetAllReferenceWithResumes(Guid userId);
    bool ToggleStatus(Guid guid); 
    void RemoveReference(Guid guid);
    Reference? UpdateReference(Reference reference);

}
