using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class movieFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Showing",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Showing",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
