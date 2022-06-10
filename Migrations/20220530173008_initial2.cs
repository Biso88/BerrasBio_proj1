using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class initial2 : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Showings_MovieId",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Showings_SalonId",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Showings");

            migrationBuilder.AddColumn<int>(
                name: "BookingId1",
                table: "Showings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "Showings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonId1",
                table: "Showings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Showings_BookingId1",
                table: "Showings",
                column: "BookingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Showings_MovieId1",
                table: "Showings",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Showings_SalonId1",
                table: "Showings",
                column: "SalonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Bookings_BookingId1",
                table: "Showings",
                column: "BookingId1",
                principalTable: "Bookings",
                principalColumn: "BookingId");

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
                name: "FK_Showings_Bookings_BookingId1",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Movies_MovieId1",
                table: "Showings");

            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Salons_SalonId1",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Showings_BookingId1",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Showings_MovieId1",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Showings_SalonId1",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "BookingId1",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "SalonId1",
                table: "Showings");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Showings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Showings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Showings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Showings_BookingId",
                table: "Showings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Showings_MovieId",
                table: "Showings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Showings_SalonId",
                table: "Showings",
                column: "SalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Bookings_BookingId",
                table: "Showings",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Movies_MovieId",
                table: "Showings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Salons_SalonId",
                table: "Showings",
                column: "SalonId",
                principalTable: "Salons",
                principalColumn: "SalonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
