using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTTSite.Migrations
{
    /// <inheritdoc />
    public partial class consulnameFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefonNummer",
                table: "Consultations",
                newName: "TelefonNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefonNumber",
                table: "Consultations",
                newName: "TelefonNummer");
        }
    }
}
