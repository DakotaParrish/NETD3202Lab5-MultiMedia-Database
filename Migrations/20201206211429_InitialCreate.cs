using Microsoft.EntityFrameworkCore.Migrations;

namespace NETD3202Lab5_1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    videoGameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videoGameName = table.Column<string>(nullable: true),
                    videoGameRating = table.Column<string>(nullable: true),
                    videoGameGenre = table.Column<string>(nullable: true),
                    videoGameRelease = table.Column<int>(nullable: false),
                    videoGamePlatform = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.videoGameID);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalGameDetails",
                columns: table => new
                {
                    videoGameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videoGameID1 = table.Column<int>(nullable: true),
                    videoGameDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalGameDetails", x => x.videoGameID);
                    table.ForeignKey(
                        name: "FK_AdditionalGameDetails_VideoGames_videoGameID1",
                        column: x => x.videoGameID1,
                        principalTable: "VideoGames",
                        principalColumn: "videoGameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalGameDetails_videoGameID1",
                table: "AdditionalGameDetails",
                column: "videoGameID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalGameDetails");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
