﻿using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface IEducationRepository : IRepository<Education>
{
    Education AddEducation(Education education);
    IQueryable<Education> GetAllEducationWithResumes();
    IQueryable<Education> GetAllEducationWithResumes(Guid userId);
    bool ToggleStatus(Guid guid); 
    void RemoveEducation(Guid guid);
    Education? UpdateEducation(Education education);
}
