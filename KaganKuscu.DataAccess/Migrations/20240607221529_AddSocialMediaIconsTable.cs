using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSocialMediaIconsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconCssClass",
                table: "SocialMedias");

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaIconId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SocialMediaIcons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaIcons", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "SocialMediaIcons",
                columns: new[] { "Id", "CssClass", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "rsicon rsicon-github", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new Guid("2298f162-2aea-40d6-a681-e1d0480322db"), true, false, "Github" },
                    { 2, "rsicon rsicon-linkedin", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(280), new Guid("6b061abf-581b-4324-81f8-e04f7a9c9dc0"), true, false, "LinkedIn" },
                    { 3, "rsicon rsicon-instagram", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new Guid("675a7197-de16-495f-b591-3ddf77d87c95"), true, false, "Instagram" },
                    { 4, "rsicon rsicon-facebook", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(290), new Guid("502a78df-8ac0-4a8d-b839-6b02cc7105bc"), true, false, "Facebook" },
                    { 5, "rsicon rsicon-youtube", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new Guid("6a235ff6-db7a-418a-b275-f2096d0bc626"), true, false, "Youtube" },
                    { 6, "rsicon rsicon-twitter", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(300), new Guid("58d73de6-fc11-4456-bbc0-897afa8e09fc"), true, false, "X (Twitter)" },
                    { 7, "rsicon rsicon-slack", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new Guid("0d792daa-53e3-4123-b144-bc06f49ece9e"), true, false, "Slack" },
                    { 8, "rsicon rsicon-reddit", new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(310), new Guid("c73c86b2-f752-401c-9d9f-3bbe72bffddc"), true, false, "Reddit" }
                });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid", "SocialMediaIconId" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9900), new Guid("5e8cdb7e-c64e-4498-959c-6d3447547b30"), 1 });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid", "SocialMediaIconId" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9900), new Guid("04572fa5-bdb4-4a7f-b299-29ccd1c98f0d"), 2 });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid", "SocialMediaIconId" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 6, 8, 1, 15, 29, 406, DateTimeKind.Local).AddTicks(9910), new Guid("3d66e410-6b77-4d5e-9020-de09af6947c0"), 3 });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 6, 8, 1, 15, 29, 407, DateTimeKind.Local).AddTicks(680), new Guid("ebd20cfb-5db6-49fc-a16f-41c107052a03") });

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_SocialMediaIconId",
                table: "SocialMedias",
                column: "SocialMediaIconId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_SocialMediaIcons_SocialMediaIconId",
                table: "SocialMedias",
                column: "SocialMediaIconId",
                principalTable: "SocialMediaIcons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_SocialMediaIcons_SocialMediaIconId",
                table: "SocialMedias");

            migrationBuilder.DropTable(
                name: "SocialMediaIcons");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_SocialMediaIconId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "SocialMediaIconId",
                table: "SocialMedias");

            migrationBuilder.AddColumn<string>(
                name: "IconCssClass",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateCreated", "DateModified", "Guid", "IconCssClass" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3530), new Guid("b2b7d76d-f20d-4b6d-adbb-b4ee35c7e1cb"), "rsicon rsicon-github" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Guid", "IconCssClass" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3540), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3540), new Guid("274dc21a-0a62-48ca-b69c-8df05e9ce921"), "rsicon rsicon-linkedin" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Guid", "IconCssClass" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3550), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3550), new Guid("f5904740-bbdf-41aa-87cc-ecb616f4feb5"), "rsicon rsicon-instagram" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Guid" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 6, 7, 17, 22, 51, 112, DateTimeKind.Local).AddTicks(3910), new Guid("d3ab1e3e-6272-422a-bb25-2b2862bb26b7") });
        }
    }
}
