using KaganKuscu.Model.ManyToMany;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SocialMedia> SocialMedias { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<PersonSkill> PersonSkill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<PersonSkill>(x => x.HasKey(p => new { p.PersonId, p.SkillId}));

            modelBuilder.Entity<Person>()
                .HasMany(x => x.Skills)
                .WithMany(x => x.People)
                .UsingEntity<PersonSkill>();
        }

    }
}
