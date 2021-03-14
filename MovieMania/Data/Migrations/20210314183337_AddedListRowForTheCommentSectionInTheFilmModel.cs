using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMania.Data.Migrations
{
    public partial class AddedListRowForTheCommentSectionInTheFilmModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FilmId",
                table: "Comment",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_FilmId",
                table: "Comment",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Film_FilmId",
                table: "Comment",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Film_FilmId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_FilmId",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "FilmId",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
