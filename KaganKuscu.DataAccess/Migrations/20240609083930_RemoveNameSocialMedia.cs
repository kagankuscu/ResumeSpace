using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNameSocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SocialMedias");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74f4aa28-535f-4308-a0de-5d268bdca859", "AQAAAAIAAYagAAAAELI5ogz/D3GRdm/Eay/ioIKWuGf00C0onHbaTZgo0ov3LZD8KEQjjGtXQBZ+mf0fRA==", "451db715-eef5-4328-b9a5-d63d4140fca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22381357-2c01-46ef-a8e6-9fe0cba9db72", "AQAAAAIAAYagAAAAEIIVnQyfSTsuaQQmob/F5/ntbOonT8DvXlgwuI6KQbm+3bn0W4SukN++NfA4X51KZA==", "f402a82b-d826-416d-9d2a-ec8f309e1743" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5780), new Guid("c7eda39d-293f-445a-8622-c91cf4c3b37e") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5810), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5810), new Guid("3c218ce4-59f2-40e1-93eb-ea7d9e56be92") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5820), new Guid("c3357b3a-515f-4f32-8121-9b81e5dabd20") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5820), new Guid("6dc49446-17a9-4302-a577-42b0f224ec70") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(5830), new Guid("98eb4484-2c16-4f91-87df-551a0eb5bf14") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6390), new Guid("7bfa5f5b-25b6-4fa3-8e18-8f367d8544af") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6830), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6840), new Guid("8b6f3083-4cca-4d4d-a64c-47aefc347a05") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6840), new Guid("e2341a3e-f32b-496b-a2a9-87fa759433da") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6850), new Guid("9f7d1d0b-0c3e-4f8c-8e59-048b7cefa4be") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6850), new Guid("2d38e405-517b-482b-91ee-fe9e8d9b2f6f") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6860), new Guid("31d335f3-37f1-470b-8c1c-d0d38896c1fd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6860), new Guid("0cd2dac5-d3b5-4c9a-8af7-8956eb30d9ac") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6870), new Guid("14536e49-45e9-4160-8580-fb7ca8b2f1f1") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6870), new Guid("d84d8352-8e0e-451f-a6e9-7415795bd822") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6880), new Guid("b513351d-66e9-4542-9dc4-7ad055400ff4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6880), new Guid("4fd08e72-43b6-4b3b-8df6-b61877bf5834") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6890), new Guid("1f7e2445-0fe7-4fad-a0ad-823526089548") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6890), new Guid("d5a15b29-28a5-428b-be3e-66f57d1076c9") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6900), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6900), new Guid("51f6730a-0a7c-4b5a-8c01-1cb40a95712c") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6900), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6900), new Guid("31b5b149-ff53-4708-b2dd-2a89e3a29a3b") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(6910), new Guid("19203eee-8503-4951-8729-8fa0b70c03c3") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(7370), new Guid("4ec3e8cb-8b7e-4d4e-8000-fa2333db8a47") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9720), new Guid("c636d0bf-5cf9-4f98-8d4b-70e9554414fd") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9730), new Guid("62dd244d-75db-4e00-83d4-4431653bcb8a") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9730), new Guid("6476bf72-cd8a-40cd-ba10-9fb1e3eb3324") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9740), new Guid("51954325-da8d-43b7-90d7-4dbf074694fe") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 6, 9, 11, 39, 29, 930, DateTimeKind.Local).AddTicks(9740), new Guid("05d07147-2d3f-4361-965d-39b4f77fa7e9") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(540), new Guid("4e8300fc-9a2c-40ea-82cd-95e26926b27d") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(550), new Guid("21539014-5aed-49e3-a4df-55382d1e572d") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(550), new Guid("e7538dfd-54fb-45ec-bdb4-a6a3c2c8a8b2") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(560), new Guid("73cfdfd2-dffd-4d18-9fa0-0e3798bacf0f") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(560), new Guid("dd864e70-a166-45bf-92aa-d669903ac27e") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(570), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(570), new Guid("4b63c18e-8412-44e9-b338-d502af725390") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(570), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(570), new Guid("3c12eee0-25af-4f8d-9923-40d5b660b84c") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(580), new Guid("17510367-fb8d-43cf-aa77-d8e514907662") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(160), new Guid("b5df00a0-2399-4249-870b-3f2a97e6645b") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(170), new Guid("6c993950-962e-4642-ae63-7c948f3b5669") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(180), new Guid("09762168-9564-4e78-b880-f51b5eda81dd") });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 6, 9, 11, 39, 29, 931, DateTimeKind.Local).AddTicks(950), new Guid("308a275d-6014-4a16-a7c5-30ae0af44fea") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e922f3c-0adc-4e67-832a-a124b5c79a20", "AQAAAAIAAYagAAAAEFCR/rFqHTuGpWkrbK7xPjbDbnOToJkAkU+p7OdMD9bEv4wI9luMht/VeBYT5tZEIA==", "eeba4ca1-5621-4bf0-82ca-0c04cb78c54b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e94ad48d-2ae3-4cac-8218-e4b0d33e8ea0", "AQAAAAIAAYagAAAAELIjAIcEpI+j5PzCJ/pwsZQ/NGUstxN6VM87/FkRVAbC2gWxzTjWWo2H0C0cKFsOEg==", "d1793c29-cb98-4ea2-962d-cc5d6989d022" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5720), new Guid("9ee6802a-18e0-4625-b1d0-5d184b55bc8d") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5740), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5740), new Guid("92844ecc-82ff-4c09-8f3e-b5114a6cf9f4") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5750), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5750), new Guid("611f57ed-8706-4e99-8865-b9b119eea765") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5760), new Guid("62d6e2f1-c8d1-455a-bd49-8fd12a890cbb") });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(5760), new Guid("f7cc085a-708c-4a71-9785-98346bf482f4") });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6240), new Guid("1a56a4c8-6a7f-4f7f-94df-c1a19ec17c47") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6680), new Guid("3bf20c3b-87db-4b03-aa4b-66500b4dfdb6") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6680), new Guid("9ad1ae16-292e-4035-bcb6-5bb424cc7437") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6690), new Guid("4eb8e1f7-004c-422b-a0aa-797db7ba1426") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6690), new Guid("5391ed1b-1900-410b-a48d-1f391b7dc375") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6700), new Guid("383e54f7-46ce-41ea-9163-06ef59080728") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6700), new Guid("e51dc898-d1cc-4baf-b0a4-dbd64ae19ce3") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6710), new Guid("0b04b08b-33ce-4a81-866c-351879e80942") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6710), new Guid("aa2f4705-e855-4c56-a8db-dcdc2dfd2cbd") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6720), new Guid("c1642267-22b3-4bbe-a574-0189fae491d4") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6720), new Guid("03a1d674-fdfa-40cb-b3a1-8f46f44dbf5f") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6730), new Guid("4fcf40fc-4797-4fc9-853f-ce07df107722") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6730), new Guid("01a4392f-e787-4ee4-bbfb-dca028557495") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6740), new Guid("866bd7c2-8e05-4c1c-9dd6-c267227dc2f1") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6740), new Guid("742ee6cf-ed40-4847-8cb5-ef953931cc8e") });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6750), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(6750), new Guid("652b8163-30be-4736-8722-42d5d99e9d1d") });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(7160), new Guid("ba3ff775-2952-411b-a867-43d9740d526b") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9490), new Guid("685bdf07-ec2d-423d-a59b-4a7b27dc7ce3") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9500), new Guid("a4779f99-5fcd-4585-b435-90704333973f") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9500), new Guid("b0efdf62-1292-4db1-ab32-903b77443b2c") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9510), new Guid("86629e2b-0f9d-47f0-ab36-4043e437fc64") });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9520), new Guid("d21d2702-f533-4ad9-a3f1-899bad3768f6") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new Guid("2298f162-2aea-40d6-a681-e1d0480322db") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new Guid("6b061abf-581b-4324-81f8-e04f7a9c9dc0") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new Guid("675a7197-de16-495f-b591-3ddf77d87c95") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new Guid("502a78df-8ac0-4a8d-b839-6b02cc7105bc") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new Guid("6a235ff6-db7a-418a-b275-f2096d0bc626") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new Guid("58d73de6-fc11-4456-bbc0-897afa8e09fc") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new Guid("0d792daa-53e3-4123-b144-bc06f49ece9e") });

            migrationBuilder.UpdateData(
                table: "SocialMediaIcons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new Guid("c73c86b2-f752-401c-9d9f-3bbe72bffddc") });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid", "Name" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9900), new Guid("5e8cdb7e-c64e-4498-959c-6d3447547b30"), "Github" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid", "Name" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9900), new Guid("04572fa5-bdb4-4a7f-b299-29ccd1c98f0d"), "LinkedIn" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid", "Name" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9910), new Guid("3d66e410-6b77-4d5e-9020-de09af6947c0"), "Instagram" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(680), new Guid("ebd20cfb-5db6-49fc-a16f-41c107052a03") });
        }
    }
}
