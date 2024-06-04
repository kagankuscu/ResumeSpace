using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "References",
                newName: "Quote");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "References",
                newName: "CompanyName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a14107a0-e5a9-4e1a-9215-c76bf289ad73", "AQAAAAIAAYagAAAAEOXSamu/qpTJpSVpaU3BC2YTIeDJba8JAYCAGe7mM9cMX4kgCh5eMfqDlBWGNXZk6g==", "31aeeb7b-1a10-4ff1-a5ae-b9a0601f1c15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16cb275a-dce4-4aad-8f90-c13642237100", "AQAAAAIAAYagAAAAEL0WN/zxdwu3378GbxQWc7vBhIpY/hqAlCz74ocbIty6GIUYzBdG027tOT3yxCiAbw==", "2f781636-907c-41bb-b9a3-27fcb1080249" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8330), new Guid("024acfcd-5555-4449-9438-04fc87d6c4c0") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8360), new Guid("d57f537d-4d77-4ebb-a07f-aa432745276c") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8360), new Guid("bfe388fe-4bc2-4b06-ab8a-da832b24205a") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8370), new Guid("4f9cc913-b97c-4c47-804e-5c61da523be2") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8380), new Guid("d6d87b5a-e163-4956-a169-d9d9ef8836fc") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(8890), new Guid("ec923cea-59a7-4e8b-9132-713b17fb2c52") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9320), new Guid("4b4ce5b1-b56b-479e-ba61-db12203ae238") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9330), new Guid("43507b21-155b-45a4-b79a-40f6f56aa3a6") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9330), new Guid("9ad11fde-cffb-46ef-ba1a-8e3a7c10f326") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9340), new Guid("bb8ec94c-b9af-4ad9-950a-8b02e8cfe1c8") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9340), new Guid("d8e838e1-4108-433a-a648-3d395b6dc0b6") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9350), new Guid("af6f30a8-2a64-487b-bfa9-a5891ef15f1d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9350), new Guid("2a7e4dfc-78e8-46ba-8638-930566928c1d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9360), new Guid("c2661403-69e1-4d1d-b967-eb48c288a975") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9360), new Guid("3eff327a-47e3-4780-aaac-2604d623ad11") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9370), new Guid("b21a6141-979e-4c02-b586-c5239891ab26") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9370), new Guid("13d053f8-1da7-4c24-bc59-fcd267fa6552") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9380), new Guid("ac4ab7fc-0c71-4a2e-8381-acaa1f6661e4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9380), new Guid("66c662a1-4b38-4d53-8b59-654791cead2e") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9390), new Guid("fa3f3046-ae8e-4f96-987f-36715543d9bc") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9390), new Guid("9d67ad12-5cdf-4897-b4f2-3799bfeaace2") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 6, 4, 17, 21, 1, 368, DateTimeKind.Local).AddTicks(9820), new Guid("bc52c4ca-848c-4ea0-8e50-3fd12a4098cc") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1740), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1750), new Guid("1bcfb34a-54ea-45fe-89e4-5aa597cc5f0d") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1750), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1750), new Guid("299a8f25-a814-40ac-adfc-0c86964e1d7e") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1760), new Guid("11675025-caaf-4e42-aa8a-eeaaff394a76") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1770), new Guid("6eff6887-eedc-4921-911d-04c26442d0d0") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(1770), new Guid("4c73ebcb-6192-4aac-9e4b-f0116dc60360") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2140), new Guid("50e627ac-e462-4440-97b4-a4a4ed91faf1") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new Guid("f6d33455-144b-4351-9707-a7ac2479f379") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new Guid("49443869-f773-4c62-978a-5edb3afd88ab") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2660), new Guid("6f010ed4-768c-457d-a1c2-352badc34107") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quote",
                table: "References",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "References",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13d5e867-c1fe-4e71-abb1-8a6d6e588246", "AQAAAAIAAYagAAAAEDosh0NYVtgvcattsEkbd5IoH4V+A0GcJMcT3KLGKzFgP1Bik71mjlkUjLDrHi1A5g==", "bd14cf97-4278-46f2-b933-7eff2655833a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a67e4cd-4f69-4b54-8cf2-9f063eef0e48", "AQAAAAIAAYagAAAAEG5ciLUi8riL/PcrJW2RAJ+QOi3BSkLIVviS97Z0Mn3ddqqC/8J/1oZuptYgvgWaHA==", "7943b02d-318d-488a-8c07-1b36f0d46c27" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5680), new Guid("4000b3ea-5899-49ab-b1c9-5ce480dcf3d3") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5700), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5700), new Guid("2bb74161-e8dd-45f0-8ab9-a2ff0d55fb59") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5710), new Guid("3f9cbdc1-7f64-4586-bd16-d2061b1e43bb") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5710), new Guid("e40e3b5a-cd90-4f4b-ad61-e46ac5daf005") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(5720), new Guid("4a1d6471-33aa-47fd-8b8d-ef67c7dbfd15") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6190), new Guid("3db530a4-116c-4c3b-a0ca-098a6e7ee90d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6660), new Guid("80fbf0c8-d976-4af2-8ad4-9a539868535b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6670), new Guid("29a49211-4f87-4dff-b35d-b5bb05103ecc") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6670), new Guid("82a5663f-0ae2-4eff-99f8-5106b0dc1418") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6680), new Guid("b974d2d1-d813-4c1f-9146-3b843a442215") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6680), new Guid("a0a31796-d11e-485f-9464-ea0fa3096e0d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6690), new Guid("f72c89cd-4a90-4609-b31b-9b16870e1c30") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6690), new Guid("6d9317b7-36b1-460c-934c-4063879c5f5c") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6700), new Guid("aed60d72-5492-4033-8b56-8cd58cc51316") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6700), new Guid("4405cd9b-e98e-4f1e-b047-38082117c85b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6710), new Guid("f8cd8b94-ea9d-41eb-bc68-c923971f1579") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6720), new Guid("8d938151-db19-4e3f-b2fa-140d96f58899") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6720), new Guid("3c0181db-1400-4d85-a14f-9c0c41ea2ea4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6730), new Guid("9852ce15-cc2e-48c2-92aa-fa57fae0d172") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6730), new Guid("0bcc11c5-6927-4e44-ba30-4aa7f207f28c") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(6740), new Guid("21d231be-5f02-4d07-9112-a68e23d41f13") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(7160), new Guid("afa15e93-9dde-4442-a82d-9b49fd56aeba") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9110), new Guid("a33068e7-3c85-48ea-9abc-bb5513317e24") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9120), new Guid("38693f0e-b3eb-439e-af8e-3600fcb9b639") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9130), new Guid("f37b1d69-adb7-4d45-98b6-e5ad67ea4a66") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9130), new Guid("7492fceb-75dd-44b1-8eb6-3cc165c7055e") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9140), new Guid("246e5b72-9863-4a0b-b73c-43d39def6f05") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9510), new Guid("47e1de21-e0ec-4457-928b-3a78b4937209") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9510), new Guid("f1f587fb-b255-47a5-9358-e8dc87f99ac3") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9520), new Guid("54397b65-18ff-46f7-94e8-4977df4e0e9c") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 6, 3, 23, 14, 43, 36, DateTimeKind.Local).AddTicks(9960), new Guid("5b3f62a8-3e9b-40d3-abfc-0782c88df542") });
        }
    }
}
