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
                    { "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4", 0, "295dac93-d2b7-4731-81d5-4861284c79f9", "admin@gmail.com", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAENUEgkPnUy9VFkCRTO8GGeE/VmCNmUrMAtp80C5kjwUB4ekuedZoHgXxzXNzYYMMCw==", null, false, null, "5bb91de5-174b-4c72-b0ba-6c0d51e6e7b7", false, "admin" },
                    { "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", 0, "799d1fab-777c-4a17-9cef-d04a41157ac4", "kuscukagan@gmail.com", false, "", false, null, "KUSCUKAGAN@GMAIL.COM", "KAGANKUSCU", "AQAAAAIAAYagAAAAEHN0vShVAC47kMLQiyW6hyD801QLGVeA9EFvSivYupJRxO0sqYAomk7z0jWcilZ/oA==", null, false, null, "63e54f55-44bc-46a6-a590-ef701b035556", false, "kagankuscu" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5920), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61ccc377-f00d-4659-8d0f-036ccc3bdca5"), true, false, "IZMIT VOCATIONAL AND TECHNICAL ANATOLIAN HIGH SCHOOL", "Electrical Technician", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5950), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1010e9cd-2459-4376-bd62-2e216d0bc60a"), true, false, "KOCAELI UNIVERSITY HEREKE VOCATIONAL SCHOOL", "Electrical Engineer", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5960), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5960), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dce7676a-e34f-4ff1-bd01-c2d0797310df"), true, false, "SOFIA TECHNICAL UNIVERSITY", "Mechatronics Engineer", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5960), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5960), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ff70f55-7bf0-44bc-936e-c5705990e10c"), true, false, "SOFIA TECHNICAL UNIVERSITY", "Master's in Mechatronics Engineering", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(5970), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f27de5a1-bdb2-4d73-b8a7-8f39543ba88f"), true, false, "ACUNMEDYA ACADEMY", ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Don’t be afraid of failure. Failure is a crucial step on the road to success.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6850), new Guid("a0f6ed5f-32b8-46a0-a6db-d7a173169593"), true, false, "Bill Gates" },
                    { 2, "Computers are like riding a bicycle. Once you get the balance, it’s hard to fall off.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6860), new Guid("1f0e1804-8657-4545-8490-6ca631d22f9a"), true, false, "Bill Gates" },
                    { 3, "Software is the best reflection of a person’s intelligence.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6860), new Guid("2fb62d93-0515-45a3-a06d-a8526a1684ce"), true, false, "Bill Gates" },
                    { 4, "The future depends on how we spend today.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6870), new Guid("a75eefe0-382b-477c-8358-20d3125c1428"), true, false, "Bill Gates" },
                    { 5, "If you want to change the world, you must first change yourself.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6880), new Guid("2d71b3d9-8f07-4c16-b707-9c041ec136fe"), true, false, "Bill Gates" },
                    { 6, "The heart of technology is the human soul.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6880), new Guid("5958556e-d9a1-4efa-a82c-2b5ab45c8257"), true, false, "Steve Jobs" },
                    { 7, "You can only connect the dots looking backward.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6890), new Guid("fb2640b6-f114-4e4d-a4e5-59bd5fa072af"), true, false, "Steve Jobs" },
                    { 8, "Your time is limited, so don’t waste it living someone else’s life.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6890), new Guid("f4ff27b9-1dfb-490b-8f0a-ed0cc610aeb1"), true, false, "Steve Jobs" },
                    { 9, "To do great work, you need to be passionate.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6900), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6900), new Guid("60cf7ab8-2da1-4bbf-8fc0-e2e03a8dbe46"), true, false, "Steve Jobs" },
                    { 10, "Being creative means not caring about what others think.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6910), new Guid("2b10af82-31eb-431b-b6f9-86e3813f9fa2"), true, false, "Steve Jobs" },
                    { 11, "Move fast and make things. Perfection is the result of action.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6910), new Guid("edf24942-a085-41e9-9ca4-1bc1d3ab6309"), true, false, "Mark Zuckerberg" },
                    { 12, "There is always a way to do better.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6920), new Guid("fff1aabd-3f17-49b4-b2e8-68f0c3433fcb"), true, false, "Larry Page" },
                    { 13, "Failure is not an option. Keep trying until you succeed.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6920), new Guid("c51fb881-93e0-400a-a2b4-634858f40bdf"), true, false, "Elon Musk" },
                    { 14, "Simplicity is the ultimate sophistication.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6930), new Guid("28fc0cb7-e7cd-4c59-9e53-fce911fdfb7e"), true, false, "Tim Cook" },
                    { 15, "I believe technology is a force for good.", new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6940), new Guid("0c6ce12d-cf60-43ed-b355-12d67e33c643"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9680), new Guid("c2cb2fe6-e801-4af2-b615-85b78f30a727"), true, false, "Asp.Net Core", 80 },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9690), new Guid("027f7cc7-0851-4387-a2c5-efe4f48b7bc3"), true, false, "C#", 75 },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9690), new Guid("cc26a2b3-be6d-42e7-b771-842250f8c8fa"), true, false, "Javascript", 60 },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9700), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9700), new Guid("a28716ec-6ba6-420a-8c6d-24be789a394a"), true, false, "MS SQL", 72 },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9710), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9710), new Guid("2da79711-d019-4c8c-a83f-8e78f08740f1"), true, false, "HTML & CSS", 82 },
                    { 6, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9710), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(9710), new Guid("65ece91c-4f8d-4016-82bf-3f07be557aca"), true, false, "JQuery", 75 }
                });

            migrationBuilder.InsertData(
                table: "SocialMediaIcons",
                columns: new[] { "Id", "CssClass", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "rsicon rsicon-github", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(560), new Guid("72add5b3-dd01-4eef-9821-ae10ba15506f"), true, false, "Github" },
                    { 2, "rsicon rsicon-linkedin", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(560), new Guid("f7b342a8-55a8-4a7e-a2a4-865d903479f5"), true, false, "LinkedIn" },
                    { 3, "rsicon rsicon-instagram", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(570), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(570), new Guid("f6258325-15be-4c01-b39f-c3c7d88fe35e"), true, false, "Instagram" },
                    { 4, "rsicon rsicon-facebook", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(570), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(570), new Guid("767065ad-5554-4f0b-87c8-4a25a850842d"), true, false, "Facebook" },
                    { 5, "rsicon rsicon-youtube", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(580), new Guid("3c57a646-cd92-4993-854d-749d8a03e084"), true, false, "Youtube" },
                    { 6, "rsicon rsicon-twitter", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(590), new Guid("ebc275a1-008b-452a-a8be-6ab96564ee6b"), true, false, "X (Twitter)" },
                    { 7, "rsicon rsicon-slack", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(590), new Guid("8741c59c-54a2-40e0-ac07-a8fc2b22bb25"), true, false, "Slack" },
                    { 8, "rsicon rsicon-reddit", new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(600), new Guid("f1407bcc-bbf4-4577-b48f-116f1ea44395"), true, false, "Reddit" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "Role", "StartDate" },
                values: new object[] { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(960), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("baaad4e7-988f-4b88-a93f-ec417c36ce4c"), true, false, "Deadline Bilişim (Deadline Information Technology)", ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                values: new object[] { 1, "<p>The endless possibilities offered by technology have always excited me. Stepping into the world of software development has given me the chance to turn this excitement into reality. I discovered my interest in backend web development on .NET Core platforms and started to improve myself in these areas. By learning C#, JavaScript, and MS SQL Server, I am working to solidify my foundations.</p>\n\n                    <p>Thanks to my curious and research-oriented nature, I learn new things every day and continue to develop myself. Writing code is not just a profession for me but also a passion and an opportunity for learning. I experience the thrill of growing and acquiring new knowledge with every project.</p>\n\n                    <p>I focus on enhancing my problem-solving skills and strengthening my analytical thinking abilities. I strive to find solutions and seek the best possible answers when faced with complex problems.</p>\n\n                    <p>I have a personality suited to teamwork and place great importance on developing my communication skills. I enjoy working in harmony with my team members to achieve common goals.</p>", "Kocaeli/Izmit", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(7330), "kuscukagan@gmail.com", "Kagan Kuscu", new Guid("7f531a24-84b6-4390-acec-8c2eb77994d4"), "kagankuscu/kagankuscu.jpg", "<p>I am passionate about cycling. Feeling the wind on my face as I pedal is an invaluable experience that embodies freedom and adventure. Each ride opens the door to new discoveries and allows me to witness the beauty of nature. I find tranquility away from the city’s chaos, exploring serene trails on my bike. Every turn brings a new surprise, and every hill reveals a new view.\n                    <br />\n                    <br />\n                    My bike is not just a mode of transportation; it’s a lifestyle. Cycling provides not only health and vitality but also a sense of responsibility towards the environment. By pedaling, I contribute to making the world a better place.\n                    <br />\n                    <br />\n                    My passion for cycling drives me forward each day. I am constantly seeking new routes to challenge myself and training to cover longer distances. As I push my limits on the bike, I also get to know myself better.\n                    <br />\n                    <br />\n                    Every journey I take on my bike becomes an unforgettable memory. With every pedal stroke, I write a new story. My passion for cycling brings me not only joy and peace but also unforgettable memories and experiences.</p>", true, false, "(089)-3006776", "KaganKuscu", "kagankuscu/kagankuscu.pdf", "", ".Net Backend Developer" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "SocialMediaIconId", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(190), new Guid("5dfd70e8-c120-4fcd-8ae1-5bb864829e99"), true, false, 1, "https://github.com/kagankuscu" },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(200), new Guid("62f41be9-73de-45ce-9893-b5b929928f69"), true, false, 2, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 8, 31, 15, 49, 34, 929, DateTimeKind.Local).AddTicks(210), new Guid("2ff28b5c-fb25-433a-8730-6d194166b40c"), true, false, 3, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "ResumeId" },
                values: new object[] { 1, new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 8, 31, 15, 49, 34, 928, DateTimeKind.Local).AddTicks(6460), new Guid("c8e551e5-fc02-45c9-89e0-6b720128909a"), "map-icon map-icon-bicycling", true, false, "Bicycle", 1 });

            migrationBuilder.InsertData(
                table: "ResumeSkill",
                columns: new[] { "ResumeId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 }
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
