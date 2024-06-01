using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddResumeWorkExperienceJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Resumes_ResumeId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_ResumeId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "WorkExperiences",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fd2dec2-327e-47d4-81a9-1f63141c542b", "AQAAAAIAAYagAAAAEL/duA+rBP0NQRumrIc9JCgDGNPpU7FDMGOQcqjGB29qb+99VZ6Hh9K8gV67o6U9YQ==", "baaa56d3-95db-4087-92e5-33901138579c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8fffe6c-3671-4d7d-9fb7-7c6841563cd1", "AQAAAAIAAYagAAAAELBde9xR5JSo2zm2lqK2chsDGBv/Y0YV7dDraFjGM81zcRsAsS5JH6Ml0e4IwVTPgg==", "194512db-33ff-4caa-908f-5f122f2ac6ab" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(480), new Guid("f70bf0b9-80ec-41c6-aa58-e242e6ad5f61") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(510), new Guid("30f181ec-0582-4d5d-a3ab-3c5935dfdea0") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(510), new Guid("9f9c199b-5ceb-4ea2-8a3c-2185d142f192") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(520), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(520), new Guid("db40eafb-3aa8-45af-8d75-4b7bae9cc117") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(530), new Guid("b55d7d3a-761a-448c-9977-6a40fc26ab8e") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(960), new Guid("9e3cad8e-1647-4330-9d57-ec0b7764a30d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1350), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1350), new Guid("f14ff43d-419d-4cb7-9cad-1d34d071aa18") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1360), new Guid("e3bf1969-4295-4dc3-8637-5c2f9884aac2") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1360), new Guid("04a998cb-85e5-4fa9-9016-d156f913e8b7") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1370), new Guid("b09d2dfa-8ba8-4b14-92eb-02b88058ecfd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1370), new Guid("c8334ae0-757a-4b3d-92a1-400871bc6beb") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1380), new Guid("1941de42-d94e-4ead-ac45-5be1da9a894b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1380), new Guid("6b9c6a5a-cffe-44c3-a0a8-797ea4ea5ad6") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1390), new Guid("874baf7f-624e-4af0-b8ac-be631d9dc550") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1390), new Guid("0e52871d-b2bf-433e-97a4-83f141d26669") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1400), new Guid("dbf517af-adb8-41ec-b4f0-3837e145c6a9") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1400), new Guid("b96b1c3d-94d0-4ef4-a1d0-a362ce2104ac") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1410), new Guid("ebebfb85-27d1-4228-b7c8-cc5dcf1ca120") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1410), new Guid("1fe86098-d03d-4986-abbb-3330434861ec") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1410), new Guid("5ea0f837-a428-49f3-ab70-48f228178a5b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1420), new Guid("cf556ab8-0d5c-4161-b26c-2e712ea9775a") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(1810), new Guid("ba1fffc9-9c24-44db-9ff9-88c7ad56614b") });

            migrationBuilder.InsertData(
                table: "ResumesWorkExperiences",
                columns: new[] { "ResumeId", "WorkExperienceId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3650), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3660), new Guid("5470f07b-2855-4bf6-a433-a3399c465f96") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3660), new Guid("caa213ed-4310-49c3-9905-92a2ae9d891d") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3670), new Guid("8b7daba6-2580-4a8e-aa3b-0e16e02a636b") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3670), new Guid("348e1670-9f57-41a4-aad1-242d2304bfa0") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3680), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(3680), new Guid("49f3d349-08cc-4f85-a0fb-988fd9892db2") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4040), new Guid("b027c261-c582-4fd2-a574-f157cabad5f8") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4050), new Guid("03e00b00-afd9-42b9-bf7d-0b1cd2589b24") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4050), new Guid("8aa04cb7-760f-4cc1-9a4e-bbe0f80e8e85") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4530), new Guid("2ea61999-96fe-4a48-b8d4-f1868b0f89dd") });

            migrationBuilder.CreateIndex(
                name: "IX_ResumesWorkExperiences_WorkExperienceId",
                table: "ResumesWorkExperiences",
                column: "WorkExperienceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumesWorkExperiences");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5850), new Guid("2636044f-5e0c-43bc-993f-5487f11a14f0") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5880), new Guid("560b8694-9848-4d35-a6fa-797437cc53ba") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5880), new Guid("3e0363f1-cbd5-4ca8-b9f1-dc083b886de6") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5890), new Guid("f0f5840a-dc57-4c2e-8587-f6ff10fd7408") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(5900), new Guid("a3a8c9e6-038f-49fd-81ad-3e86751840ec") });

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
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 6, 1, 1, 13, 59, 499, DateTimeKind.Local).AddTicks(9470), new Guid("0d332cc6-7bf3-48c8-8331-cc649753c008"), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ResumeId",
                table: "WorkExperiences",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Resumes_ResumeId",
                table: "WorkExperiences",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
