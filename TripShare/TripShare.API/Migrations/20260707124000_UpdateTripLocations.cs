using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripShare.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTripLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StartLocation",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartLocation",
                table: "Trips");
        }
    }
}
