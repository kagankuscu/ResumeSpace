using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RelationResumesAndReferences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_Resumes_ResumeId",
                table: "References");

            migrationBuilder.DropIndex(
                name: "IX_References_ResumeId",
                table: "References");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "References");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "References",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ResumesReferences_ReferenceId",
                table: "ResumesReferences",
                column: "ReferenceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumesReferences");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "References");

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "References",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 6, 1, 13, 10, 39, 956, DateTimeKind.Local).AddTicks(4530), new Guid("2ea61999-96fe-4a48-b8d4-f1868b0f89dd") });

            migrationBuilder.CreateIndex(
                name: "IX_References_ResumeId",
                table: "References",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_References_Resumes_ResumeId",
                table: "References",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
