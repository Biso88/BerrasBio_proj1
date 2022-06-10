using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId1",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Salon_SalonId1",
                table: "Showing");

            migrationBuilder.DropIndex(
                name: "IX_Showing_MovieId1",
                table: "Showing");

            migrationBuilder.DropIndex(
                name: "IX_Showing_SalonId1",
                table: "Showing");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Showing");

            migrationBuilder.DropColumn(
                name: "SalonId1",
                table: "Showing");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Showing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Showing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MovieTitle",
                table: "Movie",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Booking",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Booking",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Showing_MovieId",
                table: "Showing",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Showing_SalonId",
                table: "Showing",
                column: "SalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Salon_SalonId",
                table: "Showing",
                column: "SalonId",
                principalTable: "Salon",
                principalColumn: "SalonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Salon_SalonId",
                table: "Showing");

            migrationBuilder.DropIndex(
                name: "IX_Showing_MovieId",
                table: "Showing");

            migrationBuilder.DropIndex(
                name: "IX_Showing_SalonId",
                table: "Showing");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Showing");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Showing");

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "Showing",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonId1",
                table: "Showing",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MovieTitle",
                table: "Movie",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Booking",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Booking",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Showing_MovieId1",
                table: "Showing",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Showing_SalonId1",
                table: "Showing",
                column: "SalonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Movie_MovieId1",
                table: "Showing",
                column: "MovieId1",
                principalTable: "Movie",
                principalColumn: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Salon_SalonId1",
                table: "Showing",
                column: "SalonId1",
                principalTable: "Salon",
                principalColumn: "SalonId");
        }
    }
}
