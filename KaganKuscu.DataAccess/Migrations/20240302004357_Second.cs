using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaganKuscu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "guid",
                table: "WorkExperiences",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Tags",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "SocialMedias",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Skills",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "References",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Quotes",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Photos",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "People",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Educations",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Comments",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Blogs",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Authors",
                newName: "Guid");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_PersonId",
                table: "WorkExperiences",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PersonId",
                table: "SocialMedias",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersonId",
                table: "Skills",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_References_PersonId",
                table: "References",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonId",
                table: "Educations",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_PersonId",
                table: "Blogs",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_People_PersonId",
                table: "Blogs",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Authors_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_People_PersonId",
                table: "Educations",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_References_People_PersonId",
                table: "References",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_People_PersonId",
                table: "Skills",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_People_PersonId",
                table: "SocialMedias",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_People_PersonId",
                table: "WorkExperiences",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_People_PersonId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Authors_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_People_PersonId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_References_People_PersonId",
                table: "References");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_People_PersonId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_People_PersonId",
                table: "SocialMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_People_PersonId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_PersonId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_PersonId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PersonId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_References_PersonId",
                table: "References");

            migrationBuilder.DropIndex(
                name: "IX_Educations_PersonId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_PersonId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "WorkExperiences",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Tags",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "SocialMedias",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Skills",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "References",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Quotes",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Photos",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "People",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Educations",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Comments",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Blogs",
                newName: "guid");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Authors",
                newName: "guid");
        }
    }
}
