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
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Resumes_ResumeId",
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
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                    table.ForeignKey(
                        name: "FK_References_Resumes_ResumeId",
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
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    IconCssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_SocialMedias_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
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
                    { "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4", 0, "20609285-47dd-4796-beb5-a6ba63f5c153", "admin@gmail.com", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEE4YPZWElHSvyIVjDlnXQ0yn30gyp18yuXxRiCZgDplCF6NiJVr+dAhXpyzCWBwNRw==", null, false, null, "ea73e879-1dc5-4ef9-84d7-8ca0d705f321", false, "admin" },
                    { "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", 0, "b0c5b560-c7ef-4bb6-81f3-49bf347b40f7", "kuscukagan@gmail.com", false, "", false, null, "KUSCUKAGAN@GMAIL.COM", "KAGANKUSCU", "AQAAAAIAAYagAAAAEAUYnFSKgrX71mrTAyCvLhnicf6Fwb/eDcpsfjrwx7Bz4PW0wEjyd2O2u1wySv6VWQ==", null, false, null, "bc0c4e82-48fc-4bba-bf56-fef6a5f3fe58", false, "kagankuscu" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2190), new Guid("9fc52642-2788-4154-8203-9a9ba49fdb30"), true, false, "Bill Gates" },
                    { 2, "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new Guid("74663eb7-b0c5-4ced-a17a-6bd55aa78307"), true, false, "Bill Gates" },
                    { 3, "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new Guid("e83e8ba6-2485-48f3-8c37-59be6b258aab"), true, false, "Bill Gates" },
                    { 4, "Gelecek, bugünü nasıl geçirdiğimize bağlıdır.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new Guid("f20638c2-c284-477b-9017-f33ab01a5f3d"), true, false, "Bill Gates" },
                    { 5, "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new Guid("77282db5-432b-4f7e-b4d2-6ff4bde18ab2"), true, false, "Bill Gates" },
                    { 6, "Teknolojinin kalbi insan ruhudur.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new Guid("d913466a-67e9-4c64-b2c0-0f3a64ecae10"), true, false, "Steve Jobs" },
                    { 7, "Noktaları birleştirmek ancak geriye baktığınızda mümkündür.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2220), new Guid("95d28a95-6f8f-494b-a33e-15a56bf62b24"), true, false, "Steve Jobs" },
                    { 8, "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new Guid("99534c07-10a0-47bc-be5d-c947e5e6238b"), true, false, "Steve Jobs" },
                    { 9, "Harika işler yapmak için tutkulu olmanız gerekir.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new Guid("5646cbc9-9830-49c5-9617-e34071947725"), true, false, "Steve Jobs" },
                    { 10, "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new Guid("b09549bb-a317-482e-ac51-a99567dcc8ed"), true, false, "Steve Jobs" },
                    { 11, "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new Guid("d7fbe824-008c-426c-8c32-459b3bfda5ba"), true, false, "Mark Zuckerberg" },
                    { 12, "Her zaman daha iyisini yapmanin bir yolu vardir.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new Guid("09de37b0-bda4-4eb4-8283-67bdfc108d12"), true, false, "Larry Page" },
                    { 13, "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new Guid("6112b62b-af95-4bed-b4f3-89195a54c1e4"), true, false, "Elon Musk" },
                    { 14, "Basitlik, karmaşıklığın en üst noktasıdır.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new Guid("51984f9b-ea51-496f-83f9-75472c146739"), true, false, "Tim Cook" },
                    { 15, "Teknolojinin iyilik için bir güç olduğuna inanıyorum.", new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2260), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2260), new Guid("a9e22cf2-b67c-4aba-a86c-e82b386da0d9"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3770), new Guid("3feba83f-8119-4cec-8869-90810aae11a5"), true, false, "Asp.Net Core", 80 },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3790), new Guid("1e79228b-292c-4cd4-87f9-4d47154f0ef1"), true, false, "C#", 75 },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3790), new Guid("fc2c6eb1-38d2-4ea9-9350-7913f20c608a"), true, false, "Javascript", 60 },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new Guid("c7a31588-635b-4106-a16c-a25cbba76c35"), true, false, "MS SQL", 72 },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new Guid("0f3f30b8-94e9-44a6-93cf-9027cff62733"), true, false, "HTML & CSS", 82 }
                });

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
                values: new object[] { 1, "<p>Teknolojinin sunduğu sonsuz olasılıklar beni her zaman heyecanlandırmıştır. Yazılım geliştirme dünyasına adım atarak bu heyecanımı gerçeğe dönüştürme şansı yakaladım. .NET Core platformlarında backend web geliştirmeye olan ilgimi keşfettim ve bu alanlarda kendimi geliştirmeye başladım. C#, JavaScript ve MS SQL Server dillerini öğrenerek temellerimi sağlamlaştırmaya çalışıyorum.</p>\n\n                        <p>Meraklı ve araştırmacı ruhum sayesinde her gün yeni bir şeyler öğreniyor ve kendimi geliştirmeye devam ediyorum. Kod yazmak benim için sadece bir meslek değil, aynı zamanda bir tutku ve öğrenme fırsatı. Her projede kendimi geliştirmenin ve yeni bilgiler edinmenin heyecanını yaşıyorum.</p>\n\n                        <p>Problem çözme becerilerimi geliştirmeye ve analitik düşünme yeteneğimi güçlendirmeye odaklanıyorum. Karmaşık problemler karşısında yılmadan çözümler aramak ve en uygun çözümü bulmak için çabalıyorum.</p>\n\n                        <p>Ekip çalışmasına yatkın bir kişiliğe sahibim ve iletişim becerilerimi geliştirmeye önem veriyorum. Ekip arkadaşlarımla uyum içinde çalışarak ortak hedeflere ulaşmanın keyfini yaşıyorum.</p>", "Kocaeli/Izmit", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2640), "kuscukagan@gmail.com", "Kağan Kuşcu", new Guid("e7641569-9643-4f2a-ad92-0451079055d3"), "img/resume/kagankuscu.jpg", "<p>Bisiklet tutkunuyum. Rüzgarı yüzümde hissederek pedallara basmak, özgürlüğün ve maceranın tadını çıkarmak benim için paha biçilemez bir deneyim. Her sürüşte yeni keşiflere yelken açıyor, doğanın güzelliklerine tanık oluyorum. Bisikletimle şehirlerin karmaşasından uzaklaşıp, sakin patikalarda huzur buluyorum. Her viraj yeni bir sürprizi, her tepe yeni bir manzarayı müjdeliyor.\n                        <br />\n                        <br />\n                        Bisikletim sadece bir ulaşım aracı değil, aynı zamanda bir yaşam tarzı. Bisiklet kullanmak bana sadece sağlık ve zindelik değil, aynı zamanda çevreye karşı sorumluluk bilinci de kazandırıyor. Bisikletimle pedal çevirdikçe dünyayı daha güzel bir yer yapmak için katkıda bulunuyorum.\n                        <br />\n                        <br />\n                        Bisiklet tutkum beni her geçen gün daha da ileriye taşıyor. Kendimi geliştirmek için sürekli yeni rotalar arıyor, daha uzun mesafeler kat etmek için antrenman yapıyorum. Bisiklet üzerinde kendimi sınırlarımı zorlarken, aynı zamanda kendimi de daha iyi tanıyorum.\n                        <br />\n                        <br />\n                        Bisikletimle çıktığım her yolculuk unutulmaz bir anıya dönüşüyor. Pedallara her basışımda yeni bir hikaye yazıyorum. Bisiklet tutkum bana sadece keyif ve huzur değil, aynı zamanda unutulmaz anılar ve deneyimler de kazandırıyor.</p>", true, false, "(551)-0973377", "", "Files/Resume/kagankuscu.pdf", "(089)-3006776", ".Net Backend Developer" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "ResumeId", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1310), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1350), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1697d1ae-c108-4fda-a5cd-1458af648e9c"), true, false, "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ", 1, "Elektrik Teknisyeni", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1360), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4508fd67-567c-49bc-abd5-6a3d588e7a66"), true, false, "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU", 1, "Elektrik Teknikeri", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c08ea89-da13-4940-a234-30b92089b101"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Mekatronik Mühendisi", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("60a62392-cde3-4b78-82b4-4cfbb8a57c7d"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Yüksek Lisans Mekatronik Mühendisi", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1380), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2887a658-6dcc-4d39-800e-29bb3d79a021"), true, false, "ACUNMEDYA AKADEMİ", 1, ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "ResumeId" },
                values: new object[] { 1, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1800), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1810), new Guid("a5c77d71-5386-4a87-b4fe-52770b320c88"), "map-icon map-icon-bicycling", true, false, "Bisiklet", 1 });

            migrationBuilder.InsertData(
                table: "ResumeSkill",
                columns: new[] { "ResumeId", "SkillId", "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3030), new Guid("a1a9a7a5-c232-4b8c-ae81-49676d752b91"), 0, true, false },
                    { 1, 2, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new Guid("0e219fc0-9df0-4d8d-bdd5-16546fdd8815"), 0, true, false },
                    { 1, 3, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new Guid("f5f56cb5-b21f-49c8-96b2-cccb566604eb"), 0, true, false },
                    { 1, 4, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new Guid("bf2251a1-7660-4f7c-b65e-08c6ffcfd91c"), 0, true, false },
                    { 1, 5, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new Guid("2709fc93-c607-4bb3-99f6-43e7b15af89f"), 0, true, false }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "ResumeId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4160), new Guid("2b2176fb-0293-435d-a9f9-86aaa1d0f2f6"), "rsicon rsicon-github", true, false, "Github", 1, "https://github.com/kagankuscu" },
                    { 2, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4160), new Guid("8587b663-c4dd-43f8-bf0f-594ab01113c7"), "rsicon rsicon-linkedin", true, false, "LinkedIn", 1, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4170), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4170), new Guid("2f472e97-76c4-4f44-9173-665f29428478"), "rsicon rsicon-instagram", true, false, "Instagram", 1, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "ResumeId", "Role", "StartDate" },
                values: new object[] { 1, new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4530), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f865dced-08b3-4d1b-8939-807087adb243"), true, false, "Deadline Bilişim", 1, ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                name: "IX_Educations_ResumeId",
                table: "Educations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_ResumeId",
                table: "Interests",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BlogId",
                table: "Photos",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_References_ResumeId",
                table: "References",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_AppUserId",
                table: "Resumes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_ResumeId",
                table: "SocialMedias",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogId",
                table: "Tags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ResumeId",
                table: "WorkExperiences",
                column: "ResumeId");
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
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "ResumeSkill");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
