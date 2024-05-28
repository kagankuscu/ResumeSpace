﻿using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KaganKuscu.DataAccess
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
            
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SocialMedia> SocialMedias { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ResumeSkill>().HasKey(x => new { x.ResumeId, x.SkillId });

            modelBuilder.Entity<ResumeSkill>()
              .HasOne(r => r.Resume)
              .WithMany(r => r.ResumesSkills)
              .HasForeignKey(x => x.ResumeId);

            modelBuilder.Entity<ResumeSkill>()
              .HasOne(s => s.Skill)
              .WithMany(s => s.ResumesSkills)
              .HasForeignKey(x => x.SkillId);
        }
    }
}
