using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAppUserIdForEducationConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d48f4548-6608-4374-9d5d-cc39c4bd9565", "AQAAAAIAAYagAAAAEGzUFNB2CZsCyK5WeqyZQecxO1vlHnv7dj52ilsK+8jESuip/FtFdH+0VKty9hiP0w==", "fe22cd1d-a253-4c55-b11f-0a8e74e04244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2629815f-5619-4114-9bd9-704d16f50b0a", "AQAAAAIAAYagAAAAEH01I8r5v1g/Jifmwy4YgnphgkkUl+Uu+DaARdtq8RT4IjBI6fUtBHLFiAAqvD2QJQ==", "9370714d-7575-46ac-9eb9-b636b1d89367" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5850), new Guid("2636044f-5e0c-43bc-993f-5487f11a14f0") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5880), new Guid("560b8694-9848-4d35-a6fa-797437cc53ba") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5880), new Guid("3e0363f1-cbd5-4ca8-b9f1-dc083b886de6") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5890), new Guid("f0f5840a-dc57-4c2e-8587-f6ff10fd7408") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5900), new Guid("a3a8c9e6-038f-49fd-81ad-3e86751840ec") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6350), new Guid("58eadf5e-5f79-403c-a926-3dc40e2bd059") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6740), new Guid("698ab5fb-2075-4632-b574-d04f04975113") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6750), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6750), new Guid("2726f86e-d601-44cb-941c-879fda2cea55") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6750), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6750), new Guid("f23dd6a8-ef13-4c8b-ae05-c6e6445d489d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6760), new Guid("122eabf3-2914-4ace-85fc-82571269bb0b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6760), new Guid("06b5545d-21cf-4edb-9cd5-aee7b4a776b8") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6770), new Guid("b7eae171-6bd3-4217-b67f-c1649c0bdf03") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6770), new Guid("8cde0096-742b-41c8-add4-825dd742e6d9") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6780), new Guid("5562b936-d8fe-43a7-a400-5258fc29463f") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6780), new Guid("4740f94e-7747-4601-9e32-7c1ef73120b5") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6790), new Guid("68d6d1c0-af81-4315-8b95-452cef5d9d78") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6790), new Guid("0b36e8d0-bdc6-4c73-a9ad-1d70aef27d3b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6800), new Guid("37af2576-bd81-4df3-b510-44178cb8a123") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6800), new Guid("a6d17451-a4e5-40b5-ae54-86b3e48801ba") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6810), new Guid("0375e8a3-1d24-45be-9fc3-f2e00b45abb0") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(6810), new Guid("937abb1b-348c-422e-a0d4-4190dddeef6c") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(7190), new Guid("fda297a6-1b97-4fbf-a0c5-785a2a54b2d5") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8750), new Guid("905c5c72-de8a-4b14-bd9a-074e58c1577f") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8760), new Guid("9739e528-a695-4b10-aa92-357ac9811442") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8760), new Guid("07236b81-34b2-4790-9635-a5eea65c2d2b") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8770), new Guid("0088997f-b835-4dff-8f21-946a25253781") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(8770), new Guid("bf7cebb7-f325-4458-9201-17b63a82a60c") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9120), new Guid("10593af9-f0ad-45fb-9274-4342aebc8b92") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9120), new Guid("fad99961-4b82-498a-aede-7ad796eba31e") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9130), new Guid("260b6b3b-0a2d-4439-90ba-18337ddefb27") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9470), new Guid("0d332cc6-7bf3-48c8-8331-cc649753c008") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
