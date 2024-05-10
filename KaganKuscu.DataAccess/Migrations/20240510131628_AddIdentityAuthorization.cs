using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityAuthorization : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4eff98ec-766c-48a2-b22e-d99dc9d06475", null, "User", "USER" },
                    { "8926a1db-5642-4c19-9789-6146c3aa602c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 5, 10, 16, 16, 28, 22, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1870), new DateTime(2024, 5, 10, 16, 16, 28, 23, DateTimeKind.Local).AddTicks(1870) });

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8920) });
        }
    }
}
