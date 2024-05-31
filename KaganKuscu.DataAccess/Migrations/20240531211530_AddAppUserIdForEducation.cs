using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAppUserIdForEducation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74cf0ecf-2b6f-4d61-8835-278ec4e42820", "AQAAAAIAAYagAAAAEGtq8ZxW+krZNO6jKrkSZiSaVw+Ln2KQbLB8/Ai2iPu5eAKZeoXd9J/xo+kk0zhCcA==", "57dc8776-fb49-4bf9-94a7-3f07e8293975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "733d45db-f528-4812-a99a-7db17873543d", "AQAAAAIAAYagAAAAEF4forQjmpObQLRmwWZGUGJpBMwdZB8BZa/2s06DwO9VcbtJQiYdK+2pdveUIzd66g==", "5e4eab25-e62c-4be0-9b6b-e52e1dd09309" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7630), new Guid("301bd61d-ea53-4f0e-b0d2-98e3d5d5c222") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7660), new Guid("f48bbcba-510f-4444-8d38-1fa125cab9d3") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7670), new Guid("55f9e212-4c5c-49a4-a44e-95004f29170d") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7670), new Guid("9b2cce48-ecfe-49fe-8ba5-a0001d9dcc84") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(7680), new Guid("e7eae7c4-75e0-4ada-abdb-49a6041ea2f9") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8170), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8170), new Guid("f458b66d-b6a7-4072-af1d-e69e935b9941") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8590), new Guid("007b6eba-da3a-4451-82d0-1e5b14bd4f73") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8600), new Guid("84185d14-7b0b-408f-8ca0-260defbb65af") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8600), new Guid("c727e93c-10a9-4847-bd25-a1ba919ad901") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8610), new Guid("1b635f6f-a213-4c9b-8008-94ac98b48313") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8610), new Guid("dc5ec558-a1af-4b0b-8fc9-9cd1ed4d6025") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8620), new Guid("cbccba48-8ef1-4424-be78-84b9a7f2cdfd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8620), new Guid("2a78f691-6428-4aa7-9d10-c9c9e5bdc489") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8630), new Guid("df51fc6d-8356-48a0-96ba-3ec106164740") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8630), new Guid("ac3f7197-233b-402a-b7d1-9f031f85da1f") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8640), new Guid("f778710e-20f4-4c8e-82c5-ccc1e5da01f8") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8640), new Guid("0337dfb2-8005-48d1-992b-102a275d2171") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8650), new Guid("db468323-7c5a-4b58-996d-050658b94b33") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8650), new Guid("e138e4c5-242b-4216-9305-d5d03e2d1f0a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8660), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8660), new Guid("c951e2f8-9437-4fc5-a7ae-e210010d07ed") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8660), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(8660), new Guid("7b9100f4-cef6-4c2b-be10-40b83cd1a5e9") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 6, 1, 0, 15, 29, 893, DateTimeKind.Local).AddTicks(9090), new Guid("0b92b65e-b45c-429b-9825-2612a41c50c2") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(820), new Guid("a96aa365-7850-488e-a8be-db49f2050564") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(840), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(840), new Guid("b33adf4b-d679-4278-a45a-887df623f2c7") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(840), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(840), new Guid("aa4daffe-7986-4bd5-9b0b-959269d2b33a") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(850), new Guid("c47db721-3bcf-411c-823b-8c01c3ee4b1e") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(850), new Guid("f394d0ed-c901-49e8-b642-5882e02d94b5") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1220), new Guid("bb059cb1-4a93-48b0-ade2-14b587f3efda") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1230), new Guid("10ae184b-2fc9-48d0-bbed-1e5e88d273b8") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1230), new Guid("3ab248a5-d82e-43c6-bba8-2eae6ccfd05b") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 6, 1, 0, 15, 29, 894, DateTimeKind.Local).AddTicks(1630), new Guid("923f3ecd-a855-4be8-9a7f-cd00ed3c80b4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Educations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "846e68b8-0608-4167-9536-15e05a7fe1a3", "AQAAAAIAAYagAAAAEL7ViODCl4yXAUbhELQNPu1ggJt5c4h7gIqsM1P2Hhsh7Tx7n/s2VhfSGyfV45KfAQ==", "0d41bc0f-76b5-4226-a1d0-8dce9edfa9db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "657cc86c-e506-44f4-9514-eba526099816", "AQAAAAIAAYagAAAAEGZWtJUfZtXc6LKlami4kz74uAyGR+1AwYJOyKIPXt1AEGUotwqx9aFUFbYganzxww==", "f265588e-81a0-4718-b085-10ae343ae62a" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8230), new Guid("660627f7-9a2b-4ed3-b639-3ff3be9eaa64") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8240), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8250), new Guid("b5393b66-f4f1-46fa-9a7e-a373d62fcc83") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8250), new Guid("5e87309c-9f20-4c78-b538-4b7e7a18c9d2") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8260), new Guid("31c265ef-d0f4-4cdd-b9f9-63471a5bf7d4") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8260), new Guid("cfb05a5c-4057-4f2b-8d6c-03e765a797ba") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(8720), new Guid("adc0048c-230e-43df-9cad-f75728c5ee77") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9120), new Guid("58cc4d63-4a78-4f38-b375-c221a25c451e") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9120), new Guid("2f477037-2a25-4c3f-ba6f-5a53f067ef19") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9130), new Guid("117b7f0f-97fd-48e9-824f-c48a7e74c7e9") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9130), new Guid("3a463b45-8a8f-4c4c-baad-4da5fe7fdb67") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9140), new Guid("717aa1bb-b460-42d1-b8b6-4d1d6b500f9c") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9140), new Guid("989991ce-101e-4ec1-bf93-11e95edd5c88") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9150), new Guid("da4a1fe6-d2ff-4af7-8486-ca93cd84d437") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9150), new Guid("4bfa9e25-af3e-418c-a023-23f7cc1c02f2") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9160), new Guid("402aab55-c773-4ee5-a782-28f7b8e74d7b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9160), new Guid("8b5042f9-304d-47bc-b1cf-53dfc4916a2b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9170), new Guid("1fae2c45-f0be-4853-892b-0bdd622f8ee8") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9170), new Guid("f025eb03-ec1c-4b4d-a5d0-a5cc53f79983") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9180), new Guid("3b61cdda-7576-44ca-9e58-2498e86df1a4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9180), new Guid("e4ea082d-1f0d-4c67-9eee-7ba919335f5a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9190), new Guid("a88558f4-7e2d-461e-9555-3a406c9265ca") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 5, 30, 14, 10, 22, 871, DateTimeKind.Local).AddTicks(9640), new Guid("e5b0701a-64b2-43ee-8301-669a96a9bca3") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1130), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1130), new Guid("78907c51-8210-4a9d-8f84-7f06f120f29c") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1150), new Guid("b8c645de-a3d3-4a8c-9638-6dcf871cf837") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1150), new Guid("0c9cf715-9f71-4180-a7b1-9c92ee3fe105") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1160), new Guid("1eea2fa9-4521-4471-9ec8-74c52c7a120e") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1160), new Guid("7951269d-b415-4ed0-8729-090688eb40f3") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1510), new Guid("009df8ff-0255-4a3f-88f8-e758850928d5") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1520), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1520), new Guid("556cee0b-4add-4646-9049-597ffe7cf999") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1520), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1520), new Guid("71fce514-df28-46f0-b70e-172009e459b7") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 5, 30, 14, 10, 22, 872, DateTimeKind.Local).AddTicks(1910), new Guid("7ad8b4cb-db20-4ef2-b4bf-e2cb1934a1be") });
        }
    }
}
