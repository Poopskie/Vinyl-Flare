using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vinyl_Flare.Migrations
{
    public partial class UpdatingAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Albums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Albums",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
