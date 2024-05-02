using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_People_PersonId",
                table: "Interests");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Interests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "PersonId", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6230), "", new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ", 1, "Elektrik Teknisyeni", new DateTime(2012, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), "", new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU", 1, "Elektrik Teknikeri", new DateTime(2015, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), "", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Mekatronik Mühendisi", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), "", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "SOFYA TEKNİK ÜNİVERSİTESİ", 1, "Yüksek Lisans Mekatronik Mühendisi", new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "ACUNMEDYA AKADEMİ", 1, ".Net Core Backend Developer", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "PersonId" },
                values: new object[] { 1, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6870), new Guid("00000000-0000-0000-0000-000000000000"), "map-icon map-icon-bicycling", true, false, "Bisiklet", 1 });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Content", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Owner" },
                values: new object[,]
                {
                    { 1, "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Bill Gates" },
                    { 2, "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Bill Gates" },
                    { 3, "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Bill Gates" },
                    { 4, "Gelecek, bugünü nasıl geçirdiğimize bağlıdır.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Bill Gates" },
                    { 5, "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Bill Gates" },
                    { 6, "Teknolojinin kalbi insan ruhudur.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Steve Jobs" },
                    { 7, "Noktaları birleştirmek ancak geriye baktığınızda mümkündür.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Steve Jobs" },
                    { 8, "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Steve Jobs" },
                    { 9, "Harika işler yapmak için tutkulu olmanız gerekir.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Steve Jobs" },
                    { 10, "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Steve Jobs" },
                    { 11, "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Mark Zuckerberg" },
                    { 12, "Her zaman daha iyisini yapmanin bir yolu vardir.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Larry Page" },
                    { 13, "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Elon Musk" },
                    { 14, "Basitlik, karmaşıklığın en üst noktasıdır.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Tim Cook" },
                    { 15, "Teknolojinin iyilik için bir güç olduğuna inanıyorum.", new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Satya Nadella" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IsActive", "IsDeleted", "Name", "Percent", "PersonId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Asp.Net Core", 80, 1 },
                    { 2, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "C#", 75, 1 },
                    { 3, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Javascript", 60, 1 },
                    { 4, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "MS SQL", 72, 1 },
                    { 5, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "HTML & CSS", 82, 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "DateCreated", "DateModified", "Guid", "IconCssClass", "IsActive", "IsDeleted", "Name", "PersonId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8180), new Guid("00000000-0000-0000-0000-000000000000"), "rsicon rsicon-github", true, false, "Github", 1, "https://github.com/kagankuscu" },
                    { 2, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new Guid("00000000-0000-0000-0000-000000000000"), "rsicon rsicon-linkedin", true, false, "LinkedIn", 1, "https://www.linkedin.com/in/kagan-kuscu/" },
                    { 3, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new Guid("00000000-0000-0000-0000-000000000000"), "rsicon rsicon-instagram", true, false, "Instagram", 1, "https://www.instagram.com/kagan_kuscu/" }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "EndDate", "Guid", "IsActive", "IsDeleted", "Name", "PersonId", "Role", "StartDate" },
                values: new object[] { 1, new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8920), ".Net Backend Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Deadline Bilişim", 1, ".Net Backend Developer", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_People_PersonId",
                table: "Interests",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_People_PersonId",
                table: "Interests");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Interests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 6, 29, 876, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 5, 2, 17, 6, 29, 876, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_People_PersonId",
                table: "Interests",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
