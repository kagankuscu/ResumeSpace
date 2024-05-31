using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ResumesEduationsJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Resumes_ResumeId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "Educations");

            migrationBuilder.CreateTable(
                name: "ResumesEducations",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumesEducations", x => new { x.ResumeId, x.EducationId });
                    table.ForeignKey(
                        name: "FK_ResumesEducations_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumesEducations_Resumes_ResumeId",
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

            migrationBuilder.InsertData(
                table: "ResumesEducations",
                columns: new[] { "EducationId", "ResumeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ResumesEducations_EducationId",
                table: "ResumesEducations",
                column: "EducationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumesEducations");

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "027b84d6-6870-4403-bfc7-02b3222ad20f", "AQAAAAIAAYagAAAAEPmIOs+VbfTlHb4VIXaJ3rYjfnanj+IQRa62QFdNmftMqWrzG8DeRikHmZjZYMfLRA==", "ff80d053-a6d3-4c84-9113-b81e2dc21ab0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "591df74d-ecd2-4259-a3d3-1deaff804924", "AQAAAAIAAYagAAAAEMYyPfNbUZvmdgFfwXi+gCwVmAon3WKnqp/tCF2JRlSmCkn141LRU4BtNEsbQLzeuQ==", "7a984b2e-4782-46cc-b9df-6d8de54d07ba" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7030), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7080), new Guid("3a1a775d-2555-42e2-8a0d-476b16459ac0"), 1 });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7100), new Guid("dfcfdd81-c6f0-4c21-a24f-9a6cfb4b3b9a"), 1 });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7110), new Guid("e9ecbcc6-4616-478a-b44e-97b506272eb4"), 1 });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7110), new Guid("7f9cc66e-f79c-43e7-9181-6e0f75ba476b"), 1 });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7120), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7120), new Guid("aaa42f5d-441f-4a5d-8880-443b3ec57031"), 1 });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7610), new Guid("2576ac15-8214-4329-b74d-92fce207016e") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8020), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8020), new Guid("73221a89-f3e7-4ac7-b1d7-0181455a7e37") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8020), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8020), new Guid("9034c0a6-0999-42e1-8ecf-be2f633744ad") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8030), new Guid("0263ec82-d056-420e-b089-c9b893579b9d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8030), new Guid("2a140850-2b6b-4a8e-8688-04daa55f71de") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8040), new Guid("7475f258-e7a4-44f6-bb3e-d38fdc13f610") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8040), new Guid("447804de-305f-4a70-a907-dc84e5c31767") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8050), new Guid("0bfeda0f-c591-4cc2-9387-06bddcda3b2d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8050), new Guid("b02b8db6-1fda-4d94-b508-e3e3503c4157") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8060), new Guid("59486219-0d08-48ee-ba74-d61aba32fbdd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8060), new Guid("162c4806-11cf-4034-9ce0-9fb587db9acb") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8070), new Guid("3bcea012-2e1d-49d5-a1e4-082f367c2898") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8070), new Guid("3c8fa407-c08b-409f-96ff-30b8709ee5c0") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8080), new Guid("76017c9b-602e-4d6f-9eb2-844c74d384b6") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8080), new Guid("d17aada8-628a-4b3f-ad24-65664dd66a9a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8090), new Guid("5cab1a66-b30c-482e-bbd1-9f74ac2f1641") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(8480), new Guid("4f422a12-a9b5-4cb7-8c1f-4d6ca2b9cf88") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9660), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9670), new Guid("0a2f290c-0c06-4e70-8d39-58d82eef179f") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9680), new Guid("922755c1-e6b1-43da-90c8-b89ffc3f6822") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9690), new Guid("1ae9fcbe-163f-481b-b0db-1eff8838312d") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9700), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9700), new Guid("2af1a8ba-5b98-469b-9da7-8b493fca19b8") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9700), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(9700), new Guid("66fd2d20-44fc-4ff0-bc56-fb3ab4490263") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(60), new Guid("eae244a6-e1d2-4711-8c5a-d02243b88e9a") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(60), new Guid("5e46c9e9-1b79-417d-ba75-f9288be4c67a") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(70), new Guid("69143dbb-fb09-4115-9bce-01f4921a8ba5") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 5, 29, 20, 7, 32, 777, DateTimeKind.Local).AddTicks(420), new Guid("5bbd6467-e6d1-4956-ace2-55d0ff01aa0e") });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Resumes_ResumeId",
                table: "Educations",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
