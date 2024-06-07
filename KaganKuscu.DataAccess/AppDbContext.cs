using KaganKuscu.Model.Models;
using KaganKuscu.Model.Rel;
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
            modelBuilder.Entity<ResumesEducations>().HasKey(x => new { x.ResumeId, x.EducationId });
            modelBuilder.Entity<ResumesWorkExperiences>().HasKey(x => new { x.ResumeId, x.WorkExperienceId });
            modelBuilder.Entity<ResumesReferences>().HasKey(x => new { x.ResumeId, x.ReferenceId });
            modelBuilder.Entity<ResumesSocialMedias>().HasKey(x => new { x.ResumeId, x.SocialMediaId });

            modelBuilder.Entity<ResumeSkill>()
              .HasOne(r => r.Resume)
              .WithMany(r => r.ResumesSkills)
              .HasForeignKey(x => x.ResumeId);

            modelBuilder.Entity<ResumeSkill>()
              .HasOne(s => s.Skill)
              .WithMany(s => s.ResumesSkills)
              .HasForeignKey(x => x.SkillId);

            modelBuilder.Entity<ResumeSkill>()
              .HasOne(rs => rs.Resume)
              .WithMany(r => r.ResumesSkills)
              .HasForeignKey(rs => rs.ResumeId);

            modelBuilder.Entity<ResumesEducations>()
              .HasOne(re => re.Education)
              .WithMany(e => e.ResumesEducations)
              .HasForeignKey(re => re.EducationId);

            modelBuilder.Entity<ResumesWorkExperiences>()
              .HasOne(rs => rs.Resume)
              .WithMany(r => r.ResumesWorkExperiences)
              .HasForeignKey(rs => rs.ResumeId);

            modelBuilder.Entity<ResumesWorkExperiences>()
              .HasOne(re => re.WorkExperience)
              .WithMany(e => e.ResumesWorkExperiences)
              .HasForeignKey(re => re.WorkExperienceId);

            modelBuilder.Entity<ResumesReferences>()
              .HasOne(r => r.Resume)
              .WithMany(r => r.ResumesReferences)
              .HasForeignKey(x => x.ResumeId);

            modelBuilder.Entity<ResumesReferences>()
              .HasOne(s => s.Reference)
              .WithMany(s => s.ResumesReferences)
              .HasForeignKey(x => x.ReferenceId);

            modelBuilder.Entity<ResumesSocialMedias>()
              .HasOne(r => r.Resume)
              .WithMany(r => r.ResumesSocialMedias)
              .HasForeignKey(x => x.ResumeId);

            modelBuilder.Entity<ResumesSocialMedias>()
              .HasOne(r => r.SocialMedia)
              .WithMany(r => r.ResumesSocialMedias)
              .HasForeignKey(x => x.SocialMediaId);
        }
    }
}
