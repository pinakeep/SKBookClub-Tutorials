using Microsoft.EntityFrameworkCore.Migrations;

namespace SKBookClub.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsBookOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreName" },
                values: new object[] { 1, null, "Horror" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreName" },
                values: new object[] { 2, null, "Supernatural" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreName" },
                values: new object[] { 3, null, "Thriller" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "GenreId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBookOfTheWeek", "LongDescription", "Price", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, 1, "https://i.ibb.co/VB0f6BM/Theshinning-small.jpg", "https://i.ibb.co/GMT7m40/theshinning.jpg", true, true, "The Shining is a horror novel by American author Stephen King. Published in 1977. It is Kings third published novel and first hardback bestseller", 9.99m, "A Stephen King Horror Novel", "The Shining" },
                    { 4, 1, "https://i.ibb.co/8NSKgr3/Petsematary-small.jpg", "https://i.ibb.co/F3Jyvbm/petsematary.jpg", true, false, "Pet Sematary is a 1983 horror novel by American writer Stephen King. The novel was nominated for a World Fantasy Award for Best Novel in 1986, and adapted into two films: one in 1989 and another in 2019", 4.99m, "A Stephen King Horror", "Pet Sematary" },
                    { 5, 1, "https://i.ibb.co/GRkqJXk/ifitbleeds.jpg", "https://i.ibb.co/GRkqJXk/ifitbleeds.jpg", true, false, "If It Bleeds is a 2020 collection of four previously unpublished novellas by American writer Stephen King. The stories in the collection are titled If It Bleeds Mr Harrigans Phone The Life of Chuck and Rat", 12.99m, "Latest from Stephen King", "If It Bleeds" },
                    { 3, 2, "https://i.ibb.co/CBJDP2G/It-small.jpg", "https://i.ibb.co/NKVYZK4/it.jpg", true, false, "It is a 1986 horror novel by American author Stephen King. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey", 7.99m, "Stephen King Bestselling Horror", "IT" },
                    { 2, 3, "https://i.ibb.co/1Xfpnvx/Theinstitute-small.jpg", "https://i.ibb.co/ngj9Xgy/theinstitute.jpg", true, false, "The Institute is a science fiction-horror thriller novel by American author Stephen King", 7.99m, "A Sci-Fi Thriller", "The Institute" },
                    { 6, 3, "https://i.ibb.co/nn3WnSW/Finderskeepers-small.jpg", "https://i.ibb.co/3Yy2YnP/finderskeepers.jpg", true, false, "Finders Keepers is a crime novel by American writer Stephen King published on June 2 2015. It is the second volume in a trilogy focusing on Detective Bill Hodges following Mr Mercedes", 4.99m, "Second in Bill Hodges Trilogy", "Finders Keepers" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
