using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTTSite.Migrations
{
    /// <inheritdoc />
    public partial class ConsulBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Booked",
                table: "Consultations",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Booked",
                table: "Consultations");
        }
    }
}
