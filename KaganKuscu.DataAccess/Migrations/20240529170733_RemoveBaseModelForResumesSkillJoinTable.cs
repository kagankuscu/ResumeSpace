using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBaseModelForResumesSkillJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ResumeSkill");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "ResumeSkill");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "ResumeSkill");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ResumeSkill");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ResumeSkill");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ResumeSkill");

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
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7030), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7080), new Guid("3a1a775d-2555-42e2-8a0d-476b16459ac0") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7100), new Guid("dfcfdd81-c6f0-4c21-a24f-9a6cfb4b3b9a") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7110), new Guid("e9ecbcc6-4616-478a-b44e-97b506272eb4") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7110), new Guid("7f9cc66e-f79c-43e7-9181-6e0f75ba476b") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7120), new DateTime(2024, 5, 29, 20, 7, 32, 776, DateTimeKind.Local).AddTicks(7120), new Guid("aaa42f5d-441f-4a5d-8880-443b3ec57031") });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ResumeSkill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "ResumeSkill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "ResumeSkill",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ResumeSkill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ResumeSkill",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ResumeSkill",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20609285-47dd-4796-beb5-a6ba63f5c153", "AQAAAAIAAYagAAAAEE4YPZWElHSvyIVjDlnXQ0yn30gyp18yuXxRiCZgDplCF6NiJVr+dAhXpyzCWBwNRw==", "ea73e879-1dc5-4ef9-84d7-8ca0d705f321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c5b560-c7ef-4bb6-81f3-49bf347b40f7", "AQAAAAIAAYagAAAAEAUYnFSKgrX71mrTAyCvLhnicf6Fwb/eDcpsfjrwx7Bz4PW0wEjyd2O2u1wySv6VWQ==", "bc0c4e82-48fc-4bba-bf56-fef6a5f3fe58" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1310), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1350), new Guid("1697d1ae-c108-4fda-a5cd-1458af648e9c") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1360), new Guid("4508fd67-567c-49bc-abd5-6a3d588e7a66") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), new Guid("1c08ea89-da13-4940-a234-30b92089b101") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1370), new Guid("60a62392-cde3-4b78-82b4-4cfbb8a57c7d") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1380), new Guid("2887a658-6dcc-4d39-800e-29bb3d79a021") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1800), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(1810), new Guid("a5c77d71-5386-4a87-b4fe-52770b320c88") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2190), new Guid("9fc52642-2788-4154-8203-9a9ba49fdb30") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new Guid("74663eb7-b0c5-4ced-a17a-6bd55aa78307") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new Guid("e83e8ba6-2485-48f3-8c37-59be6b258aab") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new Guid("f20638c2-c284-477b-9017-f33ab01a5f3d") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new Guid("77282db5-432b-4f7e-b4d2-6ff4bde18ab2") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2210), new Guid("d913466a-67e9-4c64-b2c0-0f3a64ecae10") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2220), new Guid("95d28a95-6f8f-494b-a33e-15a56bf62b24") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new Guid("99534c07-10a0-47bc-be5d-c947e5e6238b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new Guid("5646cbc9-9830-49c5-9617-e34071947725") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2230), new Guid("b09549bb-a317-482e-ac51-a99567dcc8ed") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new Guid("d7fbe824-008c-426c-8c32-459b3bfda5ba") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2240), new Guid("09de37b0-bda4-4eb4-8283-67bdfc108d12") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new Guid("6112b62b-af95-4bed-b4f3-89195a54c1e4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2250), new Guid("51984f9b-ea51-496f-83f9-75472c146739") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2260), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2260), new Guid("a9e22cf2-b67c-4aba-a86c-e82b386da0d9") });

            migrationBuilder.UpdateData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3030), new Guid("a1a9a7a5-c232-4b8c-ae81-49676d752b91"), 0, true, false });

            migrationBuilder.UpdateData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new Guid("0e219fc0-9df0-4d8d-bdd5-16546fdd8815"), 0, true, false });

            migrationBuilder.UpdateData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3040), new Guid("f5f56cb5-b21f-49c8-96b2-cccb566604eb"), 0, true, false });

            migrationBuilder.UpdateData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new Guid("bf2251a1-7660-4f7c-b65e-08c6ffcfd91c"), 0, true, false });

            migrationBuilder.UpdateData(
                table: "ResumeSkill",
                keyColumns: new[] { "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "DateCreated", "DateModified", "Guid", "Id", "IsActive", "IsDeleted" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3050), new Guid("2709fc93-c607-4bb3-99f6-43e7b15af89f"), 0, true, false });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(2640), new Guid("e7641569-9643-4f2a-ad92-0451079055d3") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3770), new Guid("3feba83f-8119-4cec-8869-90810aae11a5") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3790), new Guid("1e79228b-292c-4cd4-87f9-4d47154f0ef1") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3790), new Guid("fc2c6eb1-38d2-4ea9-9350-7913f20c608a") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new Guid("c7a31588-635b-4106-a16c-a25cbba76c35") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(3800), new Guid("0f3f30b8-94e9-44a6-93cf-9027cff62733") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4160), new Guid("2b2176fb-0293-435d-a9f9-86aaa1d0f2f6") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4160), new Guid("8587b663-c4dd-43f8-bf0f-594ab01113c7") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4170), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4170), new Guid("2f472e97-76c4-4f44-9173-665f29428478") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 5, 28, 18, 39, 14, 709, DateTimeKind.Local).AddTicks(4530), new Guid("f865dced-08b3-4d1b-8939-807087adb243") });
        }
    }
}
