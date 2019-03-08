using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class Songs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Song_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Artist", "Name" },
                values: new object[,]
                {
                    { 2, "Modest Mouse", "The Lonesome Crowded West" },
                    { 3, "Modest Mouse", "The Moon & Antarctica" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Dramamine" },
                    { 2, 1, "Breakthrough" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "Name" },
                values: new object[,]
                {
                    { 3, 2, "Teeth Like God's Shoeshine" },
                    { 4, 2, "Heart Cooks Brain" },
                    { 5, 3, "3rd Planet" },
                    { 6, 3, "Gravity Rides Everything" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);
        }
    }
}
