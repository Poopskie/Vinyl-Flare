using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vinyl_Flare.Migrations
{
    public partial class Songcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Albums_AlbumId",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song",
                table: "Song");

            migrationBuilder.RenameTable(
                name: "Song",
                newName: "Songs");

            migrationBuilder.RenameIndex(
                name: "IX_Song_AlbumId",
                table: "Songs",
                newName: "IX_Songs_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "Song");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_AlbumId",
                table: "Song",
                newName: "IX_Song_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song",
                table: "Song",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Albums_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId");
        }
    }
}
