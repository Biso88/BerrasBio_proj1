using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class showingFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Bookings_BookingId1",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Movies_MovieId1",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Salons_SalonId1",
                table: "Showings");

            migrationBuilder.RenameColumn(
                name: "SalonId1",
                table: "Showings",
                newName: "SalonId");

            migrationBuilder.RenameColumn(
                name: "MovieId1",
                table: "Showings",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "BookingId1",
                table: "Showings",
                newName: "BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_SalonId1",
                table: "Showings",
                newName: "IX_Showings_SalonId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_MovieId1",
                table: "Showings",
                newName: "IX_Showings_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_BookingId1",
                table: "Showings",
                newName: "IX_Showings_BookingId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "SalonId",
                table: "Showings",
                newName: "SalonId1");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Showings",
                newName: "MovieId1");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Showings",
                newName: "BookingId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_SalonId",
                table: "Showings",
                newName: "IX_Showings_SalonId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_MovieId",
                table: "Showings",
                newName: "IX_Showings_MovieId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_BookingId",
                table: "Showings",
                newName: "IX_Showings_BookingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Bookings_BookingId1",
                table: "Showings",
                column: "ShowingId",
                principalTable: "Bookings",
                principalColumn: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Movies_MovieId1",
                table: "Showings",
                column: "ShowingId",
                principalTable: "Movies",
                principalColumn: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Salons_SalonId1",
                table: "Showings",
                column: "ShowingId",
                principalTable: "Salons",
                principalColumn: "SalonId");
        }
    }
}
