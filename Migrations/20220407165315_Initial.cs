using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vinyl_Flare.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Albums_AlbumId",
                table: "Song");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "Song",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Albums",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Albums_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Albums_AlbumId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Albums");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "Song",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Albums_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
