using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTTSite.Migrations
{
    /// <inheritdoc />
    public partial class RoomBookingV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "RoomBookings");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "RoomBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "RoomBookings");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "RoomBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
