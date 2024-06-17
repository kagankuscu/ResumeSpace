using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface IWorkExperienceRepository : IRepository<WorkExperience>
{
    WorkExperience? AddWorkExperience(WorkExperience workExperience);
    IQueryable<WorkExperience> GetAllWorkExperienceWithResumes();
    IQueryable<WorkExperience> GetAllWorkExperienceWithResumes(Guid userId);
    bool ToggleStatus(Guid guid);
    WorkExperience? UpdateWorkExperience(WorkExperience workExperience);
}
