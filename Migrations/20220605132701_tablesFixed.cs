using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class tablesFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Showings",
                table: "Showings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salons",
                table: "Salons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ShowingId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ShowingId",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Showings",
                newName: "Showing");

            migrationBuilder.RenameTable(
                name: "Salons",
                newName: "Salon");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_SalonId1",
                table: "Showing",
                newName: "IX_Showing_SalonId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showings_MovieId1",
                table: "Showing",
                newName: "IX_Showing_MovieId1");

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

            migrationBuilder.AddColumn<int>(
                name: "ShowingId1",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Showing",
                table: "Showing",
                column: "ShowingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salon",
                table: "Salon",
                column: "SalonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ShowingId1",
                table: "Booking",
                column: "ShowingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Showing_ShowingId1",
                table: "Booking",
                column: "ShowingId1",
                principalTable: "Showing",
                principalColumn: "ShowingId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Showing_ShowingId1",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId1",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Salon_SalonId1",
                table: "Showing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Showing",
                table: "Showing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salon",
                table: "Salon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ShowingId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ShowingId1",
                table: "Booking");

            migrationBuilder.RenameTable(
                name: "Showing",
                newName: "Showings");

            migrationBuilder.RenameTable(
                name: "Salon",
                newName: "Salons");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_Showing_SalonId1",
                table: "Showings",
                newName: "IX_Showings_SalonId1");

            migrationBuilder.RenameIndex(
                name: "IX_Showing_MovieId1",
                table: "Showings",
                newName: "IX_Showings_MovieId1");

            migrationBuilder.AlterColumn<string>(
                name: "MovieTitle",
                table: "Movies",
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
                table: "Bookings",
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
                table: "Bookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowingId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Showings",
                table: "Showings",
                column: "ShowingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salons",
                table: "Salons",
                column: "SalonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingId");

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
    }
}
