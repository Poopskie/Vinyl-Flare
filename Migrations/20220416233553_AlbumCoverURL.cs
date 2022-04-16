using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vinyl_Flare.Migrations
{
    public partial class AlbumCoverURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Song",
                newName: "SongId");

            migrationBuilder.AddColumn<string>(
                name: "AlbumCoverURL",
                table: "Albums",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumCoverURL",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Song",
                newName: "Id");
        }
    }
}
