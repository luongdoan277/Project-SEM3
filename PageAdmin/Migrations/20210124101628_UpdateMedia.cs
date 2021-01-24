using Microsoft.EntityFrameworkCore.Migrations;

namespace PageAdmin.Migrations
{
    public partial class UpdateMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Movies_MovieID",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Shops_ShopID",
                table: "Medias");

            migrationBuilder.AlterColumn<int>(
                name: "ShopID",
                table: "Medias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Medias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Medias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_ProductID",
                table: "Medias",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Movies_MovieID",
                table: "Medias",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Products_ProductID",
                table: "Medias",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Shops_ShopID",
                table: "Medias",
                column: "ShopID",
                principalTable: "Shops",
                principalColumn: "ShopID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Movies_MovieID",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Products_ProductID",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Shops_ShopID",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Medias_ProductID",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Medias");

            migrationBuilder.AlterColumn<int>(
                name: "ShopID",
                table: "Medias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Medias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Movies_MovieID",
                table: "Medias",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Shops_ShopID",
                table: "Medias",
                column: "ShopID",
                principalTable: "Shops",
                principalColumn: "ShopID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
