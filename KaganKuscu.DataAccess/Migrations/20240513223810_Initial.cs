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
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_AspNetUsers_AppUserId",
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
                        name: "FK_Blogs_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                        name: "FK_Educations_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                        name: "FK_Interests_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                        name: "FK_References_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                        name: "FK_SocialMedias_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                        name: "FK_WorkExperiences_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
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
                values: new object[] { "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", 0, "420401c3-09ab-4d4c-a959-eed04b3438ab", "kuscukagan@gmail.com", false, "", false, null, "KUSCUKAGAN@GMAIL.COM", "KAGANKUSCU", "AQAAAAIAAYagAAAAEHiPAYh0LPp8l7nZt+g2Hus/UKRnF+1nnPM7ivIfCrNimhuhe66OXQbMO1V+nAvt8g==", null, false, null, "19265d48-4662-4ef5-9083-fbbfe93fe097", false, "kagankuscu" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5780), new Guid("b8749260-855e-4cc8-af53-17b7537f88bf"), true, false, "Bill Gates" },
                    { 2, "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5780), new Guid("a0255aba-0652-4efc-b069-da89504d0a42"), true, false, "Bill Gates" },
                    { 3, "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5790), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5790), new Guid("18f6ea34-b552-4b70-9bb5-2a15238de62a"), true, false, "Bill Gates" },
                    { 4, "Gelecek, bugünü nasıl geçirdiğimize bağlıdır.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5790), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5790), new Guid("05c68de7-5d50-4df6-82e3-c9f33e0432d7"), true, false, "Bill Gates" },
                    { 5, "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5800), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5800), new Guid("ae18c108-a4f5-4a48-8c90-c91c9df8c441"), true, false, "Bill Gates" },
                    { 6, "Teknolojinin kalbi insan ruhudur.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5800), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5800), new Guid("13c57fa0-d0be-4f07-8ea4-4d6bb4045534"), true, false, "Steve Jobs" },
                    { 7, "Noktaları birleştirmek ancak geriye baktığınızda mümkündür.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5810), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5810), new Guid("3427a010-b98d-4ac7-b3d4-a25c5a7ba5ec"), true, false, "Steve Jobs" },
                    { 8, "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5810), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5810), new Guid("1b9b5ef9-798d-49ef-8818-bea2f17f9ef2"), true, false, "Steve Jobs" },
                    { 9, "Harika işler yapmak için tutkulu olmanız gerekir.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5820), new Guid("1e0ee200-2df7-43eb-b3b9-1ac6fee5f3f7"), true, false, "Steve Jobs" },
                    { 10, "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5820), new Guid("84e4be16-263b-4c19-aae1-71090485b322"), true, false, "Steve Jobs" },
                    { 11, "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5830), new Guid("b3fb0c3b-90b8-4424-bec3-7303f738103d"), true, false, "Mark Zuckerberg" },
                    { 12, "Her zaman daha iyisini yapmanin bir yolu vardir.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5830), new Guid("70cb0af0-6b10-4532-bf32-f7e0350d4d58"), true, false, "Larry Page" },
                    { 13, "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5840), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5840), new Guid("c727a8b0-b39a-4b29-bf2a-94b79f753299"), true, false, "Elon Musk" },
                    { 14, "Basitlik, karmaşıklığın en üst noktasıdır.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5840), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5840), new Guid("fdbcb9f8-aab8-4a56-afba-70509cf7bf21"), true, false, "Tim Cook" },
                    { 15, "Teknolojinin iyilik için bir güç olduğuna inanıyorum.", new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5850), new Guid("4cf66a57-e427-4e09-bb40-909415ec24db"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "A34A825F-E1A6-427C-8194-0D051C22560F", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "About", "Address", "AppUserId", "BirthDate", "DateCreated", "DateModified", "Email", "FullName", "Guid", "ImagePath", "Interest", "IsActive", "IsDeleted", "Phone", "ResumePath", "SecondPhone", "Title" },
                values: new object[] { 1, "<p>Teknolojinin sunduğu sonsuz olasılıklar beni her zaman heyecanlandırmıştır. Yazılım geliştirme dünyasına adım atarak bu heyecanımı gerçeğe dönüştürme şansı yakaladım. .NET Core platformlarında backend web geliştirmeye olan ilgimi keşfettim ve bu alanlarda kendimi geliştirmeye başladım. C#, JavaScript ve MS SQL Server dillerini öğrenerek temellerimi sağlamlaştırmaya çalışıyorum.</p>\n\n                        <p>Meraklı ve araştırmacı ruhum sayesinde her gün yeni bir şeyler öğreniyor ve kendimi geliştirmeye devam ediyorum. Kod yazmak benim için sadece bir meslek değil, aynı zamanda bir tutku ve öğrenme fırsatı. Her projede kendimi geliştirmenin ve yeni bilgiler edinmenin heyecanını yaşıyorum.</p>\n\n                        <p>Problem çözme becerilerimi geliştirmeye ve analitik düşünme yeteneğimi güçlendirmeye odaklanıyorum. Karmaşık problemler karşısında yılmadan çözümler aramak ve en uygun çözümü bulmak için çabalıyorum.</p>\n\n                        <p>Ekip çalışmasına yatkın bir kişiliğe sahibim ve iletişim becerilerimi geliştirmeye önem veriyorum. Ekip arkadaşlarımla uyum içinde çalışarak ortak hedeflere ulaşmanın keyfini yaşıyorum.</p>", "Kocaeli/Izmit", "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7440), "kuscukagan@gmail.com", "Kağan Kuşcu", new Guid("2acc75b3-7eb4-4b8d-9f44-252b953bb766"), "img/People/kagankuscu.jpg", "<p>Bisiklet tutkunuyum. Rüzgarı yüzümde hissederek pedallara basmak, özgürlüğün ve maceranın tadını çıkarmak benim için paha biçilemez bir deneyim. Her sürüşte yeni keşiflere yelken açıyor, doğanın güzelliklerine tanık oluyorum. Bisikletimle şehirlerin karmaşasından uzaklaşıp, sakin patikalarda huzur buluyorum. Her viraj yeni bir sürprizi, her tepe yeni bir manzarayı müjdeliyor.\n                        <br />\n                        <br />\n                        Bisikletim sadece bir ulaşım aracı değil, aynı zamanda bir yaşam tarzı. Bisiklet kullanmak bana sadece sağlık ve zindelik değil, aynı zamanda çevreye karşı sorumluluk bilinci de kazandırıyor. Bisikletimle pedal çevirdikçe dünyayı daha güzel bir yer yapmak için katkıda bulunuyorum.\n                        <br />\n                        <br />\n                        Bisiklet tutkum beni her geçen gün daha da ileriye taşıyor. Kendimi geliştirmek için sürekli yeni rotalar arıyor, daha uzun mesafeler kat etmek için antrenman yapıyorum. Bisiklet üzerinde kendimi sınırlarımı zorlarken, aynı zamanda kendimi de daha iyi tanıyorum.\n                        <br />\n                        <br />\n                        Bisikletimle çıktığım her yolculuk unutulmaz bir anıya dönüşüyor. Pedallara her basışımda yeni bir hikaye yazıyorum. Bisiklet tutkum bana sadece keyif ve huzur değil, aynı zamanda unutulmaz anılar ve deneyimler de kazandırıyor.</p>", true, false, "905510973377", "Files/Resume/kagankuscu.pdf", "3590893006776", ".Net Backend Developer" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "PersonId", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4840), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5728bf6e-92a9-431c-ad20-e5fbab47ceee"), true, false, "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ", 1, "Elektrik Teknisyeni", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4860), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f8f9120a-9185-4758-bb18-b353ffcd3631"), true, false, "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU", 1, "Elektrik Teknikeri", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4870), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a52b85f-69d8-4224-add6-19f7b8bed873"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Mekatronik Mühendisi", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4880), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29b5e31e-533f-4ca7-a3af-970bd63dedc6"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Yüksek Lisans Mekatronik Mühendisi", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(4880), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad21821d-b3eb-4edf-bee3-b74c85f4d018"), true, false, "ACUNMEDYA AKADEMİ", 1, ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "PersonId" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(5370), new Guid("e02f2c75-5b8e-4bd7-9206-dec0e210b14e"), "map-icon map-icon-bicycling", true, false, "Bisiklet", 1 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent", "PersonId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6640), new Guid("02c337fc-debb-4dc1-afa6-06f6fc363ed7"), true, false, "Asp.Net Core", 80, 1 },
                    { 2, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6650), new Guid("4c6da950-cf71-4e17-aea5-82facb5db19d"), true, false, "C#", 75, 1 },
                    { 3, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6660), new Guid("67c42bcd-7074-44e5-aa82-409de1d38369"), true, false, "Javascript", 60, 1 },
                    { 4, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6660), new Guid("a0e1f8d4-4e28-436c-a1a6-089e0ed9f1ef"), true, false, "MS SQL", 72, 1 },
                    { 5, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(6670), new Guid("18d362a7-034e-4a31-9698-3e23396cb794"), true, false, "HTML & CSS", 82, 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "PersonId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7040), new Guid("089fdceb-e66a-4dd1-b908-d9dd7993c120"), "rsicon rsicon-github", true, false, "Github", 1, "https://github.com/kagankuscu" },
                    { 2, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7050), new Guid("c1f8f690-c9ce-43ac-a8cb-e2638837179d"), "rsicon rsicon-linkedin", true, false, "LinkedIn", 1, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7060), new Guid("869cd00b-d6a9-4588-93c3-d123b959d58a"), "rsicon rsicon-instagram", true, false, "Instagram", 1, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "PersonId", "Role", "StartDate" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 5, 14, 1, 38, 10, 702, DateTimeKind.Local).AddTicks(7810), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5e7dc3f-7924-42ff-b885-feae082daecc"), true, false, "Deadline Bilişim", 1, ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                name: "IX_People_AppUserId",
                table: "People",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BlogId",
                table: "Photos",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_References_PersonId",
                table: "References",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersonId",
                table: "Skills",
                column: "PersonId");

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
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Skills");

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
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
