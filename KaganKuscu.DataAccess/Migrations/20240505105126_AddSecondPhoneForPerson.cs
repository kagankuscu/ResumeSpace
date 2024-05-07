using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSecondPhoneForPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecondPhone",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2770), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Phone", "SecondPhone" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(5120), "0905510973377", "03590893006776" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4310), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4330), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4330), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4730), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(5550), new DateTime(2024, 5, 5, 13, 51, 25, 898, DateTimeKind.Local).AddTicks(5560) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecondPhone",
                table: "People");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Phone" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8560), "TR: (90) 05510973377 / BG: (359) 0893006776" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 5, 2, 17, 50, 32, 153, DateTimeKind.Local).AddTicks(8920) });
        }
    }
}
