using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaIcons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaIcons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaIconId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedias_SocialMediaIcons_SocialMediaIconId",
                        column: x => x.SocialMediaIconId,
                        principalTable: "SocialMediaIcons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconCssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interests_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumesEducations",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumesEducations", x => new { x.ResumeId, x.EducationId });
                    table.ForeignKey(
                        name: "FK_ResumesEducations_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumesEducations_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkill",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkill", x => new { x.ResumeId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumesReferences",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    ReferenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumesReferences", x => new { x.ResumeId, x.ReferenceId });
                    table.ForeignKey(
                        name: "FK_ResumesReferences_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumesReferences_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumesWorkExperiences",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumesWorkExperiences", x => new { x.ResumeId, x.WorkExperienceId });
                    table.ForeignKey(
                        name: "FK_ResumesWorkExperiences_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumesWorkExperiences_WorkExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "WorkExperiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumesSocialMedias",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumesSocialMedias", x => new { x.ResumeId, x.SocialMediaId });
                    table.ForeignKey(
                        name: "FK_ResumesSocialMedias_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumesSocialMedias_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40A649CC-F41A-4505-94B6-7335F12E3A5D", null, "User", "USER" },
                    { "A34A825F-E1A6-427C-8194-0D051C22560F", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4", 0, "08523b68-4259-4c90-9aec-9389e3e99180", "admin@gmail.com", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEIRq38PLwSIhR72uBPDR4S8BCPMNeatZKHxVnzbpZ/bkgJnoRJ6n/jHfokTejrgsIw==", null, false, null, "7140b04e-7cf0-4860-8a04-4733c0b2d81c", false, "admin" },
                    { "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", 0, "4f4e7d5d-6119-4395-9d74-652b805809f1", "kuscukagan@gmail.com", false, "", false, null, "KUSCUKAGAN@GMAIL.COM", "KAGANKUSCU", "AQAAAAIAAYagAAAAEE050nwfChUhEuCeBLtckihJXe7SPvrwm1HIG1E2MLnwgoExqM5/EXZZW0b/DRMJHw==", null, false, null, "62a013ce-f092-4d74-afa1-834dc9b3ac52", false, "kagankuscu" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6650), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f40c5a27-df8b-408c-b7fd-77ac1bb12aa5"), true, false, "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ", "Elektrik Teknisyeni", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6670), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d1fd0d9-6e53-434d-ab6c-977c31a704d9"), true, false, "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU", "Elektrik Teknikeri", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6680), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03d64a00-60c7-4bcb-8bb9-d8a63454fbf3"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", "Mekatronik Mühendisi", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6680), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34ddba47-a0ae-4d57-9504-504cdda81214"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", "Yüksek Lisans Mekatronik Mühendisi", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(6690), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7917527b-70ea-4c1e-802b-bd403745afb7"), true, false, "ACUNMEDYA AKADEMİ", ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7530), new Guid("83a5e1eb-23dc-4d60-ba38-33cee89a581b"), true, false, "Bill Gates" },
                    { 2, "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7530), new Guid("41cae59f-d75d-4c3c-86d0-271af48ee00f"), true, false, "Bill Gates" },
                    { 3, "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7540), new Guid("3e53ce37-0fa1-4ec6-895c-ed2171ea6f0c"), true, false, "Bill Gates" },
                    { 4, "Gelecek, bugünü nasıl geçirdiğimize bağlıdır.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7550), new Guid("50f652d3-2bfc-4772-a2da-455e11629954"), true, false, "Bill Gates" },
                    { 5, "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7550), new Guid("ccf1dea4-37c6-4da1-8f9a-65c0a0acff25"), true, false, "Bill Gates" },
                    { 6, "Teknolojinin kalbi insan ruhudur.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7560), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7560), new Guid("d464cbca-6300-4130-8ccf-4e4ab29493c4"), true, false, "Steve Jobs" },
                    { 7, "Noktaları birleştirmek ancak geriye baktığınızda mümkündür.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7560), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7560), new Guid("abe5fc61-97ea-4b5a-aeb1-3100941e1842"), true, false, "Steve Jobs" },
                    { 8, "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7570), new Guid("ddac49d3-2a7b-47e5-a560-a4491fb37fb2"), true, false, "Steve Jobs" },
                    { 9, "Harika işler yapmak için tutkulu olmanız gerekir.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7580), new Guid("bf874436-6035-4220-956d-21d49afdd36d"), true, false, "Steve Jobs" },
                    { 10, "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7580), new Guid("0d9a6c43-da73-4c77-bf31-7184441a9bc2"), true, false, "Steve Jobs" },
                    { 11, "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7590), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7590), new Guid("d75848a1-f3c1-4f6b-b3de-95d23de82094"), true, false, "Mark Zuckerberg" },
                    { 12, "Her zaman daha iyisini yapmanin bir yolu vardir.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7590), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7590), new Guid("fa484876-f4f0-4711-ab0e-7e81272feeb6"), true, false, "Larry Page" },
                    { 13, "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7600), new Guid("1fee7b3c-0f06-43ca-87d8-0068707a62d4"), true, false, "Elon Musk" },
                    { 14, "Basitlik, karmaşıklığın en üst noktasıdır.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7610), new Guid("84a33fa0-0b5e-4b4d-936d-16ca41bb3617"), true, false, "Tim Cook" },
                    { 15, "Teknolojinin iyilik için bir güç olduğuna inanıyorum.", new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7610), new Guid("cbb22a5d-9a38-4aa7-b884-e659f43682c8"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(250), new Guid("114d5ade-8e2e-4978-a2cb-b787b5494444"), true, false, "Asp.Net Core", 80 },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(260), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(260), new Guid("a701a3a1-0915-41be-a3e1-770603a475ec"), true, false, "C#", 75 },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(270), new Guid("a01d2082-b2b2-41fb-9f6e-03d7f3e354c9"), true, false, "Javascript", 60 },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(270), new Guid("ce11d288-c5aa-40f4-9f52-91b8f126821c"), true, false, "MS SQL", 72 },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(280), new Guid("69ccde7a-0c97-4c2e-bb2a-3b6052c484f9"), true, false, "HTML & CSS", 82 }
                });

            migrationBuilder.InsertData(
                table: "SocialMediaIcons",
                columns: new[] { "Id", "CssClass", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "rsicon rsicon-github", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1170), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1180), new Guid("ed9215ba-8f84-45e1-94aa-514975de6da5"), true, false, "Github" },
                    { 2, "rsicon rsicon-linkedin", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1180), new Guid("67746429-09b3-4213-8059-a9f11f55329e"), true, false, "LinkedIn" },
                    { 3, "rsicon rsicon-instagram", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1190), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1190), new Guid("0f5373c1-9433-4b82-8c9b-a312a8495634"), true, false, "Instagram" },
                    { 4, "rsicon rsicon-facebook", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1200), new Guid("7500e24a-aa6d-4ce4-b10c-304829b4efc3"), true, false, "Facebook" },
                    { 5, "rsicon rsicon-youtube", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1200), new Guid("007795b9-c78a-4e6f-a7d5-624a3c9e495a"), true, false, "Youtube" },
                    { 6, "rsicon rsicon-twitter", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1210), new Guid("b28822e9-c810-4e79-93f6-66eb2f995bee"), true, false, "X (Twitter)" },
                    { 7, "rsicon rsicon-slack", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1210), new Guid("e66c6614-050d-426d-99d0-c304b2f9b708"), true, false, "Slack" },
                    { 8, "rsicon rsicon-reddit", new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1220), new Guid("35ced78e-c4d1-435c-a618-8134f303bcef"), true, false, "Reddit" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "Role", "StartDate" },
                values: new object[] { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1560), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(1560), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14d182df-aff4-4264-86c1-64a081523b49"), true, false, "Deadline Bilişim", ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A34A825F-E1A6-427C-8194-0D051C22560F", "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4" },
                    { "40A649CC-F41A-4505-94B6-7335F12E3A5D", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0" }
                });

            migrationBuilder.InsertData(
                table: "Resumes",
                columns: new[] { "Id", "About", "Address", "AppUserId", "BirthDate", "DateCreated", "DateModified", "Email", "FullName", "Guid", "ImagePath", "Interest", "IsActive", "IsDeleted", "Phone", "ResumeName", "ResumePath", "SecondPhone", "Title" },
                values: new object[] { 1, "<p>Teknolojinin sunduğu sonsuz olasılıklar beni her zaman heyecanlandırmıştır. Yazılım geliştirme dünyasına adım atarak bu heyecanımı gerçeğe dönüştürme şansı yakaladım. .NET Core platformlarında backend web geliştirmeye olan ilgimi keşfettim ve bu alanlarda kendimi geliştirmeye başladım. C#, JavaScript ve MS SQL Server dillerini öğrenerek temellerimi sağlamlaştırmaya çalışıyorum.</p>\n\n                        <p>Meraklı ve araştırmacı ruhum sayesinde her gün yeni bir şeyler öğreniyor ve kendimi geliştirmeye devam ediyorum. Kod yazmak benim için sadece bir meslek değil, aynı zamanda bir tutku ve öğrenme fırsatı. Her projede kendimi geliştirmenin ve yeni bilgiler edinmenin heyecanını yaşıyorum.</p>\n\n                        <p>Problem çözme becerilerimi geliştirmeye ve analitik düşünme yeteneğimi güçlendirmeye odaklanıyorum. Karmaşık problemler karşısında yılmadan çözümler aramak ve en uygun çözümü bulmak için çabalıyorum.</p>\n\n                        <p>Ekip çalışmasına yatkın bir kişiliğe sahibim ve iletişim becerilerimi geliştirmeye önem veriyorum. Ekip arkadaşlarımla uyum içinde çalışarak ortak hedeflere ulaşmanın keyfini yaşıyorum.</p>", "Kocaeli/Izmit", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7990), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(8000), "kuscukagan@gmail.com", "Kağan Kuşcu", new Guid("acf2bb04-cd23-4ba2-9d1f-cda56b1b4cc9"), "img/resume/kagankuscu.jpg", "<p>Bisiklet tutkunuyum. Rüzgarı yüzümde hissederek pedallara basmak, özgürlüğün ve maceranın tadını çıkarmak benim için paha biçilemez bir deneyim. Her sürüşte yeni keşiflere yelken açıyor, doğanın güzelliklerine tanık oluyorum. Bisikletimle şehirlerin karmaşasından uzaklaşıp, sakin patikalarda huzur buluyorum. Her viraj yeni bir sürprizi, her tepe yeni bir manzarayı müjdeliyor.\n                        <br />\n                        <br />\n                        Bisikletim sadece bir ulaşım aracı değil, aynı zamanda bir yaşam tarzı. Bisiklet kullanmak bana sadece sağlık ve zindelik değil, aynı zamanda çevreye karşı sorumluluk bilinci de kazandırıyor. Bisikletimle pedal çevirdikçe dünyayı daha güzel bir yer yapmak için katkıda bulunuyorum.\n                        <br />\n                        <br />\n                        Bisiklet tutkum beni her geçen gün daha da ileriye taşıyor. Kendimi geliştirmek için sürekli yeni rotalar arıyor, daha uzun mesafeler kat etmek için antrenman yapıyorum. Bisiklet üzerinde kendimi sınırlarımı zorlarken, aynı zamanda kendimi de daha iyi tanıyorum.\n                        <br />\n                        <br />\n                        Bisikletimle çıktığım her yolculuk unutulmaz bir anıya dönüşüyor. Pedallara her basışımda yeni bir hikaye yazıyorum. Bisiklet tutkum bana sadece keyif ve huzur değil, aynı zamanda unutulmaz anılar ve deneyimler de kazandırıyor.</p>", true, false, "(551)-0973377", "", "Files/Resume/kagankuscu.pdf", "(089)-3006776", ".Net Backend Developer" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "SocialMediaIconId", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(810), new Guid("01594f74-4818-4708-a4c4-97c46aa4ff3d"), true, false, 1, "https://github.com/kagankuscu" },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(820), new Guid("e57e8974-86b2-4eb5-b4c2-1349bd08b05a"), true, false, 2, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 8, 9, 21, 22, 59, 151, DateTimeKind.Local).AddTicks(820), new Guid("9cd9cc58-2d00-4d1a-95a4-ab318e35fb2e"), true, false, 3, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "ResumeId" },
                values: new object[] { 1, new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 8, 9, 21, 22, 59, 150, DateTimeKind.Local).AddTicks(7100), new Guid("bba31d8c-8aa5-498b-9fec-a3ba28249732"), "map-icon map-icon-bicycling", true, false, "Bisiklet", 1 });

            migrationBuilder.InsertData(
                table: "ResumeSkill",
                columns: new[] { "ResumeId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "ResumesEducations",
                columns: new[] { "EducationId", "ResumeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "ResumesSocialMedias",
                columns: new[] { "ResumeId", "SocialMediaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "ResumesWorkExperiences",
                columns: new[] { "ResumeId", "WorkExperienceId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_ResumeId",
                table: "Blogs",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_ResumeId",
                table: "Interests",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BlogId",
                table: "Photos",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_AppUserId",
                table: "Resumes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumesEducations_EducationId",
                table: "ResumesEducations",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumesReferences_ReferenceId",
                table: "ResumesReferences",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumesSocialMedias_SocialMediaId",
                table: "ResumesSocialMedias",
                column: "SocialMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumesWorkExperiences_WorkExperienceId",
                table: "ResumesWorkExperiences",
                column: "WorkExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_SocialMediaIconId",
                table: "SocialMedias",
                column: "SocialMediaIconId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogId",
                table: "Tags",
                column: "BlogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "ResumesEducations");

            migrationBuilder.DropTable(
                name: "ResumeSkill");

            migrationBuilder.DropTable(
                name: "ResumesReferences");

            migrationBuilder.DropTable(
                name: "ResumesSocialMedias");

            migrationBuilder.DropTable(
                name: "ResumesWorkExperiences");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "SocialMediaIcons");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
