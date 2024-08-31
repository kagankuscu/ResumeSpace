using ResumeSpace.Model.Models;

namespace ResumeSpace.Repository.Abstract;

public interface IWorkExperienceRepository : IRepository<WorkExperience>
{
    WorkExperience? AddWorkExperience(WorkExperience workExperience);
    IQueryable<WorkExperience> GetAllWorkExperienceWithResumes();
    IQueryable<WorkExperience> GetAllWorkExperienceWithResumes(Guid userId);
    void RemoveWorkExperience(Guid guid);
    bool ToggleStatus(Guid guid);
    WorkExperience? UpdateWorkExperience(WorkExperience workExperience);
}
