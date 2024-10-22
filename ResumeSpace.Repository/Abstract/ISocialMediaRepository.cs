﻿using ResumeSpace.Model.Models;

namespace ResumeSpace.Repository.Abstract;

public interface ISocialMediaRepository : IRepository<SocialMedia>
{
        SocialMedia? AddSocialMedia(SocialMedia socialMedia);
        IQueryable<SocialMedia> GetAllSocialMediaWithResumes();
        IQueryable<SocialMedia> GetAllSocialMediaWithResumes(Guid userId);
        void RemoveSocialMedia(Guid guid);
        bool ToggleStatus(Guid guid);
        SocialMedia? UpdateSocialMedia(SocialMedia socialMedia);
}
