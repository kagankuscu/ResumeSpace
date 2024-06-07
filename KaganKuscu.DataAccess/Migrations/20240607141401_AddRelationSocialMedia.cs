using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationSocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Resumes_ResumeId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_ResumeId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "SocialMedias");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "SocialMedias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ResumesSocialMedias",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumesSocialMedias", x => new { x.ResumeId, x.SocialMediaId });
                    table.ForeignKey(
                        name: "FK_ResumesSocialMedias_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumesSocialMedias_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f4b274e-a3e4-43f4-ac85-d2fff6523f86", "AQAAAAIAAYagAAAAEJXBsWCzR97de/mC2U0ztCKZ8bnhq7KsvHpkWUjp7AjJP/QefUlkQJLfGckQqFVlKA==", "e6bc06bb-2a1c-4230-b100-0699d24be5f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f61ff28a-2ec4-4e34-8e0d-3e1f70e3c64f", "AQAAAAIAAYagAAAAEO/wAq+GF07rBAvFgjvu5mkG4Um+OSlcyreDOZ6nnz87YMGvvpMolFPni2RmaGl3RA==", "09a94f05-3937-4389-8f8c-3af5af387d34" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3670), new Guid("1d1e89ec-b4d1-43ac-be11-db64a96a0df1") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3700), new Guid("5e812fe3-05e4-48a4-8905-81afbb2aa73b") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3700), new Guid("d3cdb6a5-ca79-4aef-8179-f7bb85d6b1aa") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3710), new Guid("82f395f1-74e7-4583-8d6f-73900afbf290") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(3710), new Guid("19f19191-5d65-4f6c-8153-bc5ec5c9c622") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4210), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4210), new Guid("6dbce4d9-7d33-418a-9975-f29d18ad6aad") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4640), new Guid("fc1a12ed-1f64-4976-bfc7-b2f19269273a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4650), new Guid("f1e4fc58-7a79-48a0-9cdb-d9fd5857cf3a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4650), new Guid("3fa95c1c-2e84-4e3c-a6cf-22f08295531b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4660), new Guid("4d7ac043-5859-436f-a2fd-cc83f7592cfd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4660), new Guid("8c829fe3-50f6-4769-8732-55887ceff66a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4670), new Guid("9a887c17-2f8a-4236-87ea-5b53155c8714") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4670), new Guid("27305a92-c20a-4776-8461-aaf82a940bdf") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4680), new Guid("b8c4033a-74fc-429a-a0a9-11bc82bdca9b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4680), new Guid("abf8685e-04fa-4bd3-a63a-7734008e17bf") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4690), new Guid("5ff0d6e2-1fad-4856-82dc-f42d17cdff9d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4690), new Guid("adc2e1d2-9204-4ee3-a87d-e7d6107f6400") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4700), new Guid("5d92dafe-3523-451d-945e-d2c3815a3ce5") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4700), new Guid("22469668-cac0-4189-8f31-51cc452613ba") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4710), new Guid("698733ff-ad36-4a3d-8f57-79177f39ccc7") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(4710), new Guid("3c51c83f-f7a0-486f-9b23-95a8b8028f13") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(5160), new Guid("5478fc04-8f8b-43c3-b430-f37c8eff57e0") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7100), new Guid("ad3db085-c06a-4d10-80c2-90a8d19ac409") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7100), new Guid("d855427e-1159-4840-a6a7-096df7530c44") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7110), new Guid("764e95ec-9007-42cf-8eeb-9c25c974be83") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7110), new Guid("5ce027d0-ad0a-4f5f-b5c7-997e389a5b53") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7120), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7120), new Guid("67b9fe3f-03ce-4a75-8ee1-4ae32e1ba018") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7490), new Guid("1cfbb130-fa05-4124-aca0-4cffabec511c") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new Guid("e7e9dd2f-f587-4efb-868e-689e71c9b5f7") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppUserId", "DateCreated", "DateModified", "Guid" },
                values: new object[] { new Guid("d0c23476-68d0-4da0-aad4-3adae20702c0"), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new Guid("d39fd59c-c6ca-4744-960b-5bbfd26d2080") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(8130), new Guid("8740db75-76fe-430e-9256-ab04121e3342") });

            migrationBuilder.CreateIndex(
                name: "IX_ResumesSocialMedias_SocialMediaId",
                table: "ResumesSocialMedias",
                column: "SocialMediaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumesSocialMedias");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "SocialMedias");

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2140), new Guid("50e627ac-e462-4440-97b4-a4a4ed91faf1"), 1 });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new Guid("f6d33455-144b-4351-9707-a7ac2479f379"), 1 });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid", "ResumeId" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2150), new Guid("49443869-f773-4c62-978a-5edb3afd88ab"), 1 });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 6, 4, 17, 21, 1, 369, DateTimeKind.Local).AddTicks(2660), new Guid("6f010ed4-768c-457d-a1c2-352badc34107") });

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_ResumeId",
                table: "SocialMedias",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Resumes_ResumeId",
                table: "SocialMedias",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
