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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Blogs_Resumes_PersonId",
                        column: x => x.PersonId,
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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Educations_Resumes_PersonId",
                        column: x => x.PersonId,
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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Interests_Resumes_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonSkill",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    SkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSkill", x => new { x.PeopleId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_PersonSkill_Resumes_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonSkill_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_References_Resumes_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Resumes",
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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_SocialMedias_Resumes_PersonId",
                        column: x => x.PersonId,
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
                    PersonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_WorkExperiences_Resumes_PersonId",
                        column: x => x.PersonId,
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
                    { "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4", 0, "c4b6cf4b-a63a-455a-975c-312eff0f2ed0", "admin@gmail.com", false, "", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEB2X3fxTzGlCwoQx0T9d/i59y9cckHDKHOqvPRPoeBQ23SHZkKQ2s/MrvZJgiJz1NQ==", null, false, null, "434f9263-93f2-4622-b63c-4ca021e9ef49", false, "admin" },
                    { "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", 0, "4b745a9f-29cf-47a4-87e4-ff180ccf6abf", "kuscukagan@gmail.com", false, "", false, null, "KUSCUKAGAN@GMAIL.COM", "KAGANKUSCU", "AQAAAAIAAYagAAAAEDbf6zUgyYeGslcrbM8IEybsFzFGzbTFeqtSihttUk210c2IZmqYNX7evnE4wHY5wQ==", null, false, null, "3432e0bb-b192-4b7b-b370-7f15dd9c9768", false, "kagankuscu" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(990), new Guid("45823911-f354-4d89-8da7-4090208e424f"), true, false, "Bill Gates" },
                    { 2, "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(990), new Guid("fed24920-322a-4f02-a468-47b3c4ac3986"), true, false, "Bill Gates" },
                    { 3, "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1000), new Guid("88442701-f7e2-41d1-b515-68ea4bc23e3d"), true, false, "Bill Gates" },
                    { 4, "Gelecek, bugünü nasıl geçirdiğimize bağlıdır.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1000), new Guid("c8b74b6f-8315-4719-9032-c1fdafa039c3"), true, false, "Bill Gates" },
                    { 5, "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1010), new Guid("46488918-4994-4184-a97c-1dd1b25200b0"), true, false, "Bill Gates" },
                    { 6, "Teknolojinin kalbi insan ruhudur.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1010), new Guid("4a0430be-124a-4170-abba-3b64e54357b8"), true, false, "Steve Jobs" },
                    { 7, "Noktaları birleştirmek ancak geriye baktığınızda mümkündür.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1020), new Guid("b8e04164-9092-4d23-a548-47fd4a58963b"), true, false, "Steve Jobs" },
                    { 8, "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1020), new Guid("3a8370d9-1349-4ebb-bd2c-834fe89edea6"), true, false, "Steve Jobs" },
                    { 9, "Harika işler yapmak için tutkulu olmanız gerekir.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1030), new Guid("aebfd533-7185-4ec8-bd71-f8436052a270"), true, false, "Steve Jobs" },
                    { 10, "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1030), new Guid("9fd0609c-ece2-4c09-a92f-73fda4486ce4"), true, false, "Steve Jobs" },
                    { 11, "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1040), new Guid("bdffedbe-be8d-44eb-9692-024f4d9965d6"), true, false, "Mark Zuckerberg" },
                    { 12, "Her zaman daha iyisini yapmanin bir yolu vardir.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1040), new Guid("421ce0cd-c269-4402-a77f-e73f2a049fcf"), true, false, "Larry Page" },
                    { 13, "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1050), new Guid("f4e06d61-c109-407b-98c3-c1635f2a3142"), true, false, "Elon Musk" },
                    { 14, "Basitlik, karmaşıklığın en üst noktasıdır.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1050), new Guid("5886324a-f6fc-484e-808a-caf96f986872"), true, false, "Tim Cook" },
                    { 15, "Teknolojinin iyilik için bir güç olduğuna inanıyorum.", new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1050), new Guid("45c8d45a-b7b7-4353-9b4b-39cfbdcdf5e3"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AppUserId", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent" },
                values: new object[,]
                {
                    { 1, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(1980), new Guid("c0271012-ea4a-4f27-84db-ac23ce0b607b"), true, false, "Asp.Net Core", 80 },
                    { 2, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2000), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2000), new Guid("aeef362e-0939-4190-9b9b-db26cea0905a"), true, false, "C#", 75 },
                    { 3, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2010), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2010), new Guid("6f0258fe-d20d-4366-ba53-847b53563b1f"), true, false, "Javascript", 60 },
                    { 4, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2010), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2010), new Guid("81495f3f-ec7b-4b05-9609-7c16d6366c7f"), true, false, "MS SQL", 72 },
                    { 5, new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2020), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2020), new Guid("245d0185-4d53-4261-b342-88a5995ff6bf"), true, false, "HTML & CSS", 82 }
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
                values: new object[] { 1, "<p>Teknolojinin sunduğu sonsuz olasılıklar beni her zaman heyecanlandırmıştır. Yazılım geliştirme dünyasına adım atarak bu heyecanımı gerçeğe dönüştürme şansı yakaladım. .NET Core platformlarında backend web geliştirmeye olan ilgimi keşfettim ve bu alanlarda kendimi geliştirmeye başladım. C#, JavaScript ve MS SQL Server dillerini öğrenerek temellerimi sağlamlaştırmaya çalışıyorum.</p>\n\n                        <p>Meraklı ve araştırmacı ruhum sayesinde her gün yeni bir şeyler öğreniyor ve kendimi geliştirmeye devam ediyorum. Kod yazmak benim için sadece bir meslek değil, aynı zamanda bir tutku ve öğrenme fırsatı. Her projede kendimi geliştirmenin ve yeni bilgiler edinmenin heyecanını yaşıyorum.</p>\n\n                        <p>Problem çözme becerilerimi geliştirmeye ve analitik düşünme yeteneğimi güçlendirmeye odaklanıyorum. Karmaşık problemler karşısında yılmadan çözümler aramak ve en uygun çözümü bulmak için çabalıyorum.</p>\n\n                        <p>Ekip çalışmasına yatkın bir kişiliğe sahibim ve iletişim becerilerimi geliştirmeye önem veriyorum. Ekip arkadaşlarımla uyum içinde çalışarak ortak hedeflere ulaşmanın keyfini yaşıyorum.</p>", "Kocaeli/Izmit", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2830), "kuscukagan@gmail.com", "Kağan Kuşcu", new Guid("5dcfc5dc-ed09-4b08-ac6b-32f8fcd9ee2c"), "img/People/kagankuscu.jpg", "<p>Bisiklet tutkunuyum. Rüzgarı yüzümde hissederek pedallara basmak, özgürlüğün ve maceranın tadını çıkarmak benim için paha biçilemez bir deneyim. Her sürüşte yeni keşiflere yelken açıyor, doğanın güzelliklerine tanık oluyorum. Bisikletimle şehirlerin karmaşasından uzaklaşıp, sakin patikalarda huzur buluyorum. Her viraj yeni bir sürprizi, her tepe yeni bir manzarayı müjdeliyor.\n                        <br />\n                        <br />\n                        Bisikletim sadece bir ulaşım aracı değil, aynı zamanda bir yaşam tarzı. Bisiklet kullanmak bana sadece sağlık ve zindelik değil, aynı zamanda çevreye karşı sorumluluk bilinci de kazandırıyor. Bisikletimle pedal çevirdikçe dünyayı daha güzel bir yer yapmak için katkıda bulunuyorum.\n                        <br />\n                        <br />\n                        Bisiklet tutkum beni her geçen gün daha da ileriye taşıyor. Kendimi geliştirmek için sürekli yeni rotalar arıyor, daha uzun mesafeler kat etmek için antrenman yapıyorum. Bisiklet üzerinde kendimi sınırlarımı zorlarken, aynı zamanda kendimi de daha iyi tanıyorum.\n                        <br />\n                        <br />\n                        Bisikletimle çıktığım her yolculuk unutulmaz bir anıya dönüşüyor. Pedallara her basışımda yeni bir hikaye yazıyorum. Bisiklet tutkum bana sadece keyif ve huzur değil, aynı zamanda unutulmaz anılar ve deneyimler de kazandırıyor.</p>", true, false, "(551)-0973377", "", "Files/Resume/kagankuscu.pdf", "(089)-3006776", ".Net Backend Developer" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "PersonId", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9850), new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9890), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3724865a-8c46-404b-b4fc-ce2a492c61ca"), true, false, "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ", 1, "Elektrik Teknisyeni", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9910), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb329525-e6c1-4b9a-9ec9-65653edfa1bb"), true, false, "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU", 1, "Elektrik Teknikeri", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9920), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("916a8fd9-a2be-4399-9f7f-c529eb3cec9d"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Mekatronik Mühendisi", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9920), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("13d03568-5eb7-48e6-ae56-87b4ed7bccc6"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Yüksek Lisans Mekatronik Mühendisi", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 5, 24, 9, 49, 47, 636, DateTimeKind.Local).AddTicks(9930), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9046afb9-e006-4a99-9e5d-3bbed54f8ed3"), true, false, "ACUNMEDYA AKADEMİ", 1, ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "PersonId" },
                values: new object[] { 1, new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(490), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(490), new Guid("cad3bdad-9527-481a-8c94-c85cf4fce67a"), "map-icon map-icon-bicycling", true, false, "Bisiklet", 1 });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "PersonId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2430), new Guid("5765e5c4-185c-4dc6-9cee-41edd2b5e4e3"), "rsicon rsicon-github", true, false, "Github", 1, "https://github.com/kagankuscu" },
                    { 2, new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2440), new Guid("f639f8ba-745c-42c4-bc00-6e0a2f1c8dfd"), "rsicon rsicon-linkedin", true, false, "LinkedIn", 1, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(2440), new Guid("69582196-7beb-41f1-8d12-916da44f320f"), "rsicon rsicon-instagram", true, false, "Instagram", 1, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "PersonId", "Role", "StartDate" },
                values: new object[] { 1, new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 5, 24, 9, 49, 47, 637, DateTimeKind.Local).AddTicks(3240), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2af04fa0-6046-4a8a-b2ee-9d009cbb9b22"), true, false, "Deadline Bilişim", 1, ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                name: "IX_Blogs_PersonId",
                table: "Blogs",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonId",
                table: "Educations",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_PersonId",
                table: "Interests",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSkill_SkillsId",
                table: "PersonSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BlogId",
                table: "Photos",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_References_PersonId",
                table: "References",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_AppUserId",
                table: "Resumes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PersonId",
                table: "SocialMedias",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogId",
                table: "Tags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_PersonId",
                table: "WorkExperiences",
                column: "PersonId");
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
                name: "PersonSkill");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "References");

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
