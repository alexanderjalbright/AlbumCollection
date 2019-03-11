using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

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
                columns: new[] { "AlbumId", "Artist", "ImageURL", "Name" },
                values: new object[] { 1, "Modest Mouse", "/images/LongDrive.jpg", "This Is a Long Drive for Someone with Nothing to Think About" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Artist", "ImageURL", "Name" },
                values: new object[] { 2, "Modest Mouse", "/images/CrowdedWest.jpg", "The Lonesome Crowded West" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Artist", "ImageURL", "Name" },
                values: new object[] { 3, "Modest Mouse", "/images/Moon.jpg", "The Moon & Antarctica" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Dramamine" },
                    { 2, 1, "Breakthrough" },
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

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
