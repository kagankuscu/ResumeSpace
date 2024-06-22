﻿using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface IResumeRepository: IRepository<Resume>
{
    Resume? AddResume(Resume resume);
    IQueryable<Resume> GetAllByAppUserGuid(Guid guid);
    bool ToggleStatus(Guid guid); 
    void RemoveResume(Guid guid);
    Resume? UpdateResume(Resume resume);
    bool UpdateStatusForUserGuid(Guid guid);
}
