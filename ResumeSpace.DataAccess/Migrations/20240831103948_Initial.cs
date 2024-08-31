using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumeSpace.DataAccess.Migrations
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
                    { "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4", 0, "9ef3499c-8d4f-47de-bfe6-5d10d27740e8", "admin@gmail.com", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEO9JN1j7RwDz49cSnsjEIuSbwOlO3arJN00dNiCvjw/9pZAOeUK4mVeGY6Gt9yshtg==", null, false, null, "0244e8b9-92da-40bb-88c3-0d664ecfaa72", false, "admin" },
                    { "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", 0, "dc2b0a25-bea7-4318-b030-bac7da666e13", "kuscukagan@gmail.com", false, "", false, null, "KUSCUKAGAN@GMAIL.COM", "KAGANKUSCU", "AQAAAAIAAYagAAAAEADaTrsDiPXEBh3x3ambtIK+62yenJIheDS1vcIWyoLIuXyeakmnpb/LnpZsGczXPQ==", null, false, null, "6904b190-0b40-442c-9f40-877344941730", false, "kagankuscu" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6690), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c998cbb9-bb20-4c6c-b3a9-e6073bad0582"), true, false, "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ", "Elektrik Teknisyeni", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6710), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9bbd7c9f-9d0b-4c6e-b518-1f5133939e96"), true, false, "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU", "Elektrik Teknikeri", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6720), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90b962ac-5a30-4130-b7e6-8f8dded2901d"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", "Mekatronik Mühendisi", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6720), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("460d0b1c-4d37-4bf5-b5b0-7623c358d6ab"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", "Yüksek Lisans Mekatronik Mühendisi", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(6730), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d06796be-aaec-492c-bf26-af54bc78e5ae"), true, false, "ACUNMEDYA AKADEMİ", ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7670), new Guid("397a47ab-5f1e-48e3-b286-6c12e56ae07f"), true, false, "Bill Gates" },
                    { 2, "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7680), new Guid("0a548571-3d6b-4a28-a5b6-0d8b0dfc5c88"), true, false, "Bill Gates" },
                    { 3, "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7690), new Guid("97dd707e-11f1-48bd-9f7b-23cc85355937"), true, false, "Bill Gates" },
                    { 4, "Gelecek, bugünü nasıl geçirdiğimize bağlıdır.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7690), new Guid("f4f4b9e3-07d8-4500-bef0-6bd4c97808da"), true, false, "Bill Gates" },
                    { 5, "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7700), new Guid("4674e32d-810c-466b-b460-a37f74fb461d"), true, false, "Bill Gates" },
                    { 6, "Teknolojinin kalbi insan ruhudur.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7700), new Guid("e6c51353-4c56-4422-88cc-1c3231cb3b8d"), true, false, "Steve Jobs" },
                    { 7, "Noktaları birleştirmek ancak geriye baktığınızda mümkündür.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7710), new Guid("e8b89137-c146-413b-bd7e-28353faddf6a"), true, false, "Steve Jobs" },
                    { 8, "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7720), new Guid("8a8208fb-bd63-4865-bf04-d7e48cbde3cb"), true, false, "Steve Jobs" },
                    { 9, "Harika işler yapmak için tutkulu olmanız gerekir.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7720), new Guid("69de6947-ac82-415a-bb51-d850381b4385"), true, false, "Steve Jobs" },
                    { 10, "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7730), new Guid("f77c9ac1-ed4d-4d49-a28b-37ba1403da35"), true, false, "Steve Jobs" },
                    { 11, "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7730), new Guid("999e4b66-30c9-4b7b-8de6-093ed2bc258b"), true, false, "Mark Zuckerberg" },
                    { 12, "Her zaman daha iyisini yapmanin bir yolu vardir.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7740), new Guid("94697484-4a1d-4a5d-ac15-265a5f05c177"), true, false, "Larry Page" },
                    { 13, "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7750), new Guid("0d4f5f9e-ee64-4662-888c-835903f15b6c"), true, false, "Elon Musk" },
                    { 14, "Basitlik, karmaşıklığın en üst noktasıdır.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7750), new Guid("c72c67be-29b4-45be-9496-1f5c7d514f1f"), true, false, "Tim Cook" },
                    { 15, "Teknolojinin iyilik için bir güç olduğuna inanıyorum.", new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7760), new Guid("5e22800a-9605-44a7-81fa-e8ca4024373f"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(660), new Guid("e37e330b-4c3e-4579-8f06-d55737f52ec7"), true, false, "Asp.Net Core", 80 },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(670), new Guid("7c3774f7-20b6-4c68-8d95-14b4cec3a75c"), true, false, "C#", 75 },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(680), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(680), new Guid("290b798b-a4d2-42c7-8039-739a76b553d7"), true, false, "Javascript", 60 },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(690), new Guid("77ad2c88-c758-4d9e-8daf-b0bdca6fde5a"), true, false, "MS SQL", 72 },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(690), new Guid("65f43e71-3f82-431b-8279-6cc6f30ace5a"), true, false, "HTML & CSS", 82 }
                });

            migrationBuilder.InsertData(
                table: "SocialMediaIcons",
                columns: new[] { "Id", "CssClass", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "rsicon rsicon-github", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1480), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1480), new Guid("b96ffdfc-27c5-47b9-916c-2b0dd9a89a5b"), true, false, "Github" },
                    { 2, "rsicon rsicon-linkedin", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1490), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1490), new Guid("947ddb81-c922-40d0-984f-0375e7f13003"), true, false, "LinkedIn" },
                    { 3, "rsicon rsicon-instagram", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1500), new Guid("d431d715-2bc2-4da4-af04-92cfb02f3642"), true, false, "Instagram" },
                    { 4, "rsicon rsicon-facebook", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1500), new Guid("d3faaf45-f92f-4ac7-8af8-bf06849f8a0c"), true, false, "Facebook" },
                    { 5, "rsicon rsicon-youtube", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1510), new Guid("ee884add-22de-4f39-8484-36d459a0c7c7"), true, false, "Youtube" },
                    { 6, "rsicon rsicon-twitter", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1510), new Guid("713d05e8-bc09-4c74-8ab7-196ec04eff1f"), true, false, "X (Twitter)" },
                    { 7, "rsicon rsicon-slack", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1520), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1520), new Guid("aeec2bfc-63ba-49bb-90fe-d4239e60bb28"), true, false, "Slack" },
                    { 8, "rsicon rsicon-reddit", new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1530), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1530), new Guid("e94995e6-d56f-42a5-8a56-fd39d46c3760"), true, false, "Reddit" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "Role", "StartDate" },
                values: new object[] { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1920), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4c6011df-73d4-4f61-bc23-3561566029df"), true, false, "Deadline Bilişim", ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                values: new object[] { 1, "<p>Teknolojinin sunduğu sonsuz olasılıklar beni her zaman heyecanlandırmıştır. Yazılım geliştirme dünyasına adım atarak bu heyecanımı gerçeğe dönüştürme şansı yakaladım. .NET Core platformlarında backend web geliştirmeye olan ilgimi keşfettim ve bu alanlarda kendimi geliştirmeye başladım. C#, JavaScript ve MS SQL Server dillerini öğrenerek temellerimi sağlamlaştırmaya çalışıyorum.</p>\n\n                        <p>Meraklı ve araştırmacı ruhum sayesinde her gün yeni bir şeyler öğreniyor ve kendimi geliştirmeye devam ediyorum. Kod yazmak benim için sadece bir meslek değil, aynı zamanda bir tutku ve öğrenme fırsatı. Her projede kendimi geliştirmenin ve yeni bilgiler edinmenin heyecanını yaşıyorum.</p>\n\n                        <p>Problem çözme becerilerimi geliştirmeye ve analitik düşünme yeteneğimi güçlendirmeye odaklanıyorum. Karmaşık problemler karşısında yılmadan çözümler aramak ve en uygun çözümü bulmak için çabalıyorum.</p>\n\n                        <p>Ekip çalışmasına yatkın bir kişiliğe sahibim ve iletişim becerilerimi geliştirmeye önem veriyorum. Ekip arkadaşlarımla uyum içinde çalışarak ortak hedeflere ulaşmanın keyfini yaşıyorum.</p>", "Kocaeli/Izmit", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(8190), "kuscukagan@gmail.com", "Kağan Kuşcu", new Guid("96df543e-0af8-4726-96e1-a1fdac874934"), "img/resume/kagankuscu.jpg", "<p>Bisiklet tutkunuyum. Rüzgarı yüzümde hissederek pedallara basmak, özgürlüğün ve maceranın tadını çıkarmak benim için paha biçilemez bir deneyim. Her sürüşte yeni keşiflere yelken açıyor, doğanın güzelliklerine tanık oluyorum. Bisikletimle şehirlerin karmaşasından uzaklaşıp, sakin patikalarda huzur buluyorum. Her viraj yeni bir sürprizi, her tepe yeni bir manzarayı müjdeliyor.\n                        <br />\n                        <br />\n                        Bisikletim sadece bir ulaşım aracı değil, aynı zamanda bir yaşam tarzı. Bisiklet kullanmak bana sadece sağlık ve zindelik değil, aynı zamanda çevreye karşı sorumluluk bilinci de kazandırıyor. Bisikletimle pedal çevirdikçe dünyayı daha güzel bir yer yapmak için katkıda bulunuyorum.\n                        <br />\n                        <br />\n                        Bisiklet tutkum beni her geçen gün daha da ileriye taşıyor. Kendimi geliştirmek için sürekli yeni rotalar arıyor, daha uzun mesafeler kat etmek için antrenman yapıyorum. Bisiklet üzerinde kendimi sınırlarımı zorlarken, aynı zamanda kendimi de daha iyi tanıyorum.\n                        <br />\n                        <br />\n                        Bisikletimle çıktığım her yolculuk unutulmaz bir anıya dönüşüyor. Pedallara her basışımda yeni bir hikaye yazıyorum. Bisiklet tutkum bana sadece keyif ve huzur değil, aynı zamanda unutulmaz anılar ve deneyimler de kazandırıyor.</p>", true, false, "(551)-0973377", "KaganKuscu", "Files/Resume/kagankuscu.pdf", "(089)-3006776", ".Net Backend Developer" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "SocialMediaIconId", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1100), new Guid("18c97685-44cc-41e5-9f5b-0fdbe8dd2295"), true, false, 1, "https://github.com/kagankuscu" },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1110), new Guid("42643af5-a103-4845-9ece-f2a82c806f9a"), true, false, 2, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 8, 31, 13, 39, 48, 449, DateTimeKind.Local).AddTicks(1120), new Guid("fbb39a91-cadc-445b-91e5-dfa141747b43"), true, false, 3, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "ResumeId" },
                values: new object[] { 1, new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 8, 31, 13, 39, 48, 448, DateTimeKind.Local).AddTicks(7240), new Guid("a80467bf-cd03-467f-be8b-c08b32309ed2"), "map-icon map-icon-bicycling", true, false, "Bisiklet", 1 });

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
