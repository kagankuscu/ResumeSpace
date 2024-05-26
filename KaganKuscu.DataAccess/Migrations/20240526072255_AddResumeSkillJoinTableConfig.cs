using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddResumeSkillJoinTableConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa421081-f78f-43eb-95da-0bbc933321e6", "AQAAAAIAAYagAAAAEGtc7F32JG3sVorkcvWRCZkOTsS3mXkC7SEK84OH6nakHKZV9oI4RcmWQzpicNMHWw==", "aa9976be-0752-4b54-a461-cfb8fec5fec5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2df1342-0c56-40d2-8b10-b8b24ddc23ca", "AQAAAAIAAYagAAAAEOupNzfdcjtz/2PCriL6huurC+doELPs0bxduf9FGORL45l4oD5bF7dR3E+ccSxCWw==", "a20a6ea2-995f-4aa8-a953-5bf29f268552" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8560), new Guid("02a01528-a6c2-4e7a-ab85-d79d20d84840") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8570), new Guid("954b68d8-ec00-4149-82c5-4ee918fffdee") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8580), new Guid("3ba89e9a-551d-4d1b-9a6a-5cc7234b96ff") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8580), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8580), new Guid("a9312fc0-3eae-44d5-ba36-d427e74cbbc3") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(8590), new Guid("847b00b3-375d-40cf-b5c3-f411c6021599") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9070), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9070), new Guid("65c987d1-9e15-4716-819d-1c66f90a19b4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9470), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9470), new Guid("0ca15a5c-aa5d-4444-a75b-1d4990a394c9") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9480), new Guid("5023b2de-85fa-4079-93ba-832a18a3ed9a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9490), new Guid("05beef97-2a97-4da4-baf3-b807220fe398") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9490), new Guid("aed2174c-9561-4cd7-bcfc-7cb14897451f") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9500), new Guid("c0ec8b28-c8aa-44a9-90bb-93cbf9a34502") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9500), new Guid("ce6a0864-8329-4d0c-bef8-424feebd873c") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9510), new Guid("27610c83-5c6d-48c0-8581-a474da68c378") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9510), new Guid("f42e9e40-2b33-4256-b3bc-dfb2b650b460") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9520), new Guid("bd31c776-5af9-4efe-908e-606e8879cd4d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9520), new Guid("9afec4d5-6e73-41a1-9af6-bd6d0f3a5e96") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9530), new Guid("33bae97c-442d-4f1a-8f74-ea8f3565ed55") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9530), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9530), new Guid("a5df5749-c5ab-48d7-91cf-ec43cb4d4aac") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9530), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9530), new Guid("244ff3bf-157c-4f56-8642-70ee3e5a1043") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9540), new Guid("61c7e4ab-e523-49aa-add0-cac95aaa1e53") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9600), new DateTime(2024, 5, 26, 10, 22, 55, 113, DateTimeKind.Local).AddTicks(9610), new Guid("fec14351-469d-4cd7-9329-768022387736") });

            migrationBuilder.InsertData(
                table: "ResumeSkill",
                columns: new[] { "ResumeId", "SkillId", "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(430), new Guid("d3988c87-a5b9-4c59-83de-de3d169b0a0b"), 0, true, false },
                    { 1, 2, new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(430), new Guid("2d815f32-658f-4346-9a70-11889642bf76"), 0, true, false },
                    { 1, 3, new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(440), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(440), new Guid("f22ae33f-a0e7-49db-8421-cdc80b93c73e"), 0, true, false },
                    { 1, 4, new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(440), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(440), new Guid("924f4329-5067-43cf-a553-e0dbc180e15b"), 0, true, false },
                    { 1, 5, new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(450), new Guid("cf8641d9-ec38-4203-a25f-692fd15f26b9"), 0, true, false }
                });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(50), new Guid("5d3968e8-c5af-47bb-baac-8dd2b0c8ea42") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1210), new Guid("a2638021-420b-47bd-8210-403a818d4e97") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1230), new Guid("8d0d789d-f5de-4129-a423-979015e43d72") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1230), new Guid("d49b4d5e-e1dc-4cd6-aace-af607767f4ca") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1240), new Guid("5eac945c-ee9a-42e7-86d1-e389c97e6105") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1240), new Guid("f9bb693c-7821-4ca0-bbb2-572959db1ed1") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1600), new Guid("98cd334c-39f4-447e-b219-21ca69b8afe2") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1600), new Guid("5c9c25dd-3b1a-463a-b9d6-2c7e1c94b5ec") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1610), new Guid("96b56986-819f-4816-b8cd-7ab56dd40caa") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1990), new DateTime(2024, 5, 26, 10, 22, 55, 114, DateTimeKind.Local).AddTicks(1990), new Guid("c1c98faf-e3f8-4a5c-b961-d7e5252cbf19") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e8e3bd-c60a-4ae7-b716-db9fd5c9fa40", "AQAAAAIAAYagAAAAELT03uZLrkiexTodDYeBZlQ13GUgAAjGv81YRUak3rQSWv10QSgQTKwGG5/d5wVHcQ==", "40e483c0-840b-49b6-bb48-bc8a7ba3ebad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ada8268-2fb0-4fdd-b076-101cb90b3474", "AQAAAAIAAYagAAAAEKkbzZRVmfw9F+YHDzyuLyuQLJ13H20uJlOC1jQT4IdO9mKrLeWPod6ZTn4cTflfww==", "0e1d288e-edf5-46dd-b0ad-e781cc187335" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9660), new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9700), new Guid("c7f07425-d30a-4618-ae32-13e07c91db6b") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9710), new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9720), new Guid("b9d2108d-0a0d-416c-a5fd-a1f8d3856f82") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9720), new Guid("f7d8fde4-0e54-4192-913e-c4d0c358e038") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9730), new Guid("60e75e4d-7620-459a-bf4d-e8a7df97ad30") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 5, 26, 9, 53, 49, 900, DateTimeKind.Local).AddTicks(9730), new Guid("9abb0c75-eb9f-4532-880c-822d774f992a") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(160), new Guid("256ca400-2eaf-47c8-a5a2-bbad82fc2cdd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(590), new Guid("f8a50654-1d5a-49c5-8f5b-2c54797c556e") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(600), new Guid("96a37363-879a-446f-b722-583724152e29") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(600), new Guid("ce10e25d-c6bd-4789-98b9-d04aa1d56c66") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(610), new Guid("140e0f7e-4143-4187-81b8-8fcf667790a2") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(610), new Guid("823f4645-23eb-4598-93ec-c88d65c4c321") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(610), new Guid("9cc63543-2349-44a4-8993-5e63bcb903ae") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(620), new Guid("02606f88-ba93-44a2-82ee-8357452512d2") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(630), new Guid("20a9054e-fe56-4787-8dcc-958ad02a5b65") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(630), new Guid("475532c4-da05-40ca-9a48-a42dd68f3254") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(640), new Guid("7fb853c3-5945-4b66-91ef-3d6bfe400dff") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(640), new Guid("35e0533f-dc5e-490a-b1c6-e4083fb27afc") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(650), new Guid("4a84315a-caf6-427a-aa5d-515ffefaea8c") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(650), new Guid("fafd9982-251b-4d80-9cbd-43035ca09e0f") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(660), new Guid("448ddfe3-0b3f-4cc8-96d6-5dbe373dae34") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(660), new Guid("2b17544d-54de-4f7c-b675-6982bde9f92b") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1040), new Guid("3102603b-9ca7-4b58-839c-ff5e7e4dc1fb") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1780), new Guid("e23cff12-aff7-4374-a8ec-466fed93cede") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1790), new Guid("89ce5d1a-fce5-41d2-b2ef-17f05a47c629") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1800), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1800), new Guid("6e99822f-9949-4ce8-a6a5-7e128fe782c7") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1800), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1800), new Guid("98aec5ef-20be-440e-bbfa-3e49f9d35610") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(1810), new Guid("8219d7d9-d36e-4fd9-be0d-ddfd1f0e9ccf") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2180), new Guid("46819a50-971f-44b4-bbf8-7b32931076a0") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2190), new Guid("e48e3eac-4d38-40d7-bffc-4536fa289552") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2190), new Guid("8d0bd7ba-58c2-437e-a482-6a22a792cf5b") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 5, 26, 9, 53, 49, 901, DateTimeKind.Local).AddTicks(2550), new Guid("316d2553-0441-4e72-accc-57294cc72032") });
        }
    }
}
