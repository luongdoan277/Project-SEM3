using Microsoft.EntityFrameworkCore.Migrations;

namespace HomePage.Migrations
{
    public partial class AddMovieInMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Medias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_MovieID",
                table: "Medias",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Movies_MovieID",
                table: "Medias",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Movies_MovieID",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Medias_MovieID",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Medias");
        }
    }
}
