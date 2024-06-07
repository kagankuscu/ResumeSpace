using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationSocialMediaConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a093aa5-24e8-4432-a907-0e3898d2d4d2", "AQAAAAIAAYagAAAAEHTSaAhOBKHDMZUhli1CYOSg5wGRuSR+ab2l0L/yNk20CDQA0vl2TBrOoE4PxW97hQ==", "3de45f8b-0201-4991-92b2-e02c487fcd6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f20ff03-8a97-4098-82bd-0e866edbb8a8", "AQAAAAIAAYagAAAAEP+hDHYQ+5mLhSArBk5QDFeFX2lhvQObKaahIuME3cVSxnspWev+s3NgKyPVtJm4+Q==", "60be719f-b697-437a-8f84-5609b0045a55" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9120), new Guid("f1749e86-c5e2-4d03-8b9b-c430603a2098") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9180), new Guid("5979086f-72b7-44d7-9b43-e53179df748e") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9190), new Guid("2b5372b5-e711-4cec-b143-1dd4ea0519ce") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9190), new Guid("eec0520c-4420-4443-987b-7d5d79b88433") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9200), new Guid("cf469e7f-cd74-4909-9420-448d45c96763") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 6, 7, 17, 22, 51, 111, DateTimeKind.Local).AddTicks(9690), new Guid("b73c7205-994a-4566-b049-5b88c48a59cf") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(90), new Guid("8fb4d93f-1381-49d9-9e6b-dd4ef6d2dd71") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(100), new Guid("2308ae4c-2cf1-45a9-9898-f335a9a719d5") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(100), new Guid("bd3e4401-b511-403d-8b9d-1fa51bf08212") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(110), new Guid("d0217582-b7c4-448d-b7f5-c70be4b7d471") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(110), new Guid("9e263058-e08b-43ac-874f-a7c5ff3f078e") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(110), new Guid("13f3a4e2-6974-4b75-a554-653e71f51932") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(170), new Guid("71c222d1-b40c-4224-9cd0-8a97a95fcb1b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(170), new Guid("72e52ce1-f9f7-4c7d-8dd5-c4a93ba288f8") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(180), new Guid("1819680f-5d34-480e-8f13-e7f9f3976edf") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(180), new Guid("46ba7dd0-14b3-47a1-b9a8-776f7aa89aa3") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(180), new Guid("64b86e64-61ce-4af3-8254-4bba28d53b5a") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(190), new Guid("dd588817-9a92-4857-8d47-3ced19de7028") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(190), new Guid("630f61a6-f038-4931-a626-aeb26a299f68") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(200), new Guid("4e6ac655-7c33-459b-9882-68b420aadb55") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(200), new Guid("6411f8db-d49f-4653-9825-7f92bd85a1d2") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(640), new Guid("41c6de63-bc5a-4e11-874c-87c3071c4316") });

            migrationBuilder.InsertData(
                table: "ResumesSocialMedias",
                columns: new[] { "ResumeId", "SocialMediaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2850), new Guid("90d19070-9dfb-4c44-9920-20ad9ea87e9b") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2850), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2850), new Guid("ff6293ba-616c-4dfc-9bbd-8e752f4baa9c") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2860), new Guid("93d46bff-b5d7-457b-8f7d-6b4b18771cc6") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2860), new Guid("fa955147-32e8-4ffd-8715-d7cfd4fc5f7e") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(2870), new Guid("b96ed340-2fc9-43f6-ad17-f28ccc9da51d") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3530), new Guid("b2b7d76d-f20d-4b6d-adbb-b4ee35c7e1cb") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3540), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3540), new Guid("274dc21a-0a62-48ca-b69c-8df05e9ce921") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3550), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3550), new Guid("f5904740-bbdf-41aa-87cc-ecb616f4feb5") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3910), new Guid("d3ab1e3e-6272-422a-bb25-2b2862bb26b7") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResumesSocialMedias",
                keyColumns: new[] { "ResumeId", "SocialMediaId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumesSocialMedias",
                keyColumns: new[] { "ResumeId", "SocialMediaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumesSocialMedias",
                keyColumns: new[] { "ResumeId", "SocialMediaId" },
                keyValues: new object[] { 1, 3 });

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
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7490), new Guid("1cfbb130-fa05-4124-aca0-4cffabec511c") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new Guid("e7e9dd2f-f587-4efb-868e-689e71c9b5f7") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(7500), new Guid("d39fd59c-c6ca-4744-960b-5bbfd26d2080") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 6, 7, 17, 14, 1, 234, DateTimeKind.Local).AddTicks(8130), new Guid("8740db75-76fe-430e-9256-ab04121e3342") });
        }
    }
}
