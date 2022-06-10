using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class buggFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Bookings_BookingId",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Movies_MovieId",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Salons_SalonId",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Showings_BookingId",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Showings");

            migrationBuilder.RenameColumn(
                name: "SalonId",
                table: "Showings",
                newName: "SalonId1");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Showings",
                newName: "MovieId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_SalonId",
                table: "Showings",
                newName: "IX_Showings_SalonId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_MovieId",
                table: "Showings",
                newName: "IX_Showings_MovieId1");

            migrationBuilder.AddColumn<int>(
                name: "ShowingId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ShowingId",
                table: "Bookings",
                column: "ShowingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Showings_ShowingId",
                table: "Bookings",
                column: "ShowingId",
                principalTable: "Showings",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Movies_MovieId1",
                table: "Showings",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Salons_SalonId1",
                table: "Showings",
                column: "SalonId1",
                principalTable: "Salons",
                principalColumn: "SalonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Showings_ShowingId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Movies_MovieId1",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Salons_SalonId1",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ShowingId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ShowingId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "SalonId1",
                table: "Showings",
                newName: "SalonId");

            migrationBuilder.RenameColumn(
                name: "MovieId1",
                table: "Showings",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_SalonId1",
                table: "Showings",
                newName: "IX_Showings_SalonId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_MovieId1",
                table: "Showings",
                newName: "IX_Showings_MovieId");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Showings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Showings_BookingId",
                table: "Showings",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Bookings_BookingId",
                table: "Showings",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Movies_MovieId",
                table: "Showings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Salons_SalonId",
                table: "Showings",
                column: "SalonId",
                principalTable: "Salons",
                principalColumn: "SalonId");
        }
    }
}
