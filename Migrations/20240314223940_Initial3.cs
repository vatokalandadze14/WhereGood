using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitute = table.Column<double>(type: "float", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncmentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_Announcments_AnnouncmentId",
                        column: x => x.AnnouncmentId,
                        principalTable: "Announcments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_AnnouncmentId",
                table: "Adresses",
                column: "AnnouncmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
