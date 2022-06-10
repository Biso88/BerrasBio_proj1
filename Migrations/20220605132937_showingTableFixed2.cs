using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    public partial class showingTableFixed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Showing_ShowingId1",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ShowingId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ShowingId1",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "ShowingId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ShowingId",
                table: "Booking",
                column: "ShowingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Showing_ShowingId",
                table: "Booking",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Showing_ShowingId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ShowingId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ShowingId",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "ShowingId1",
                table: "Booking",
                type: "int",
                nullable: true);

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
        }
    }
}
