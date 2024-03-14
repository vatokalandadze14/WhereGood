using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalGEL = table.Column<int>(type: "int", nullable: false),
                    TotalUSD = table.Column<int>(type: "int", nullable: false),
                    SquareMeterGEL = table.Column<int>(type: "int", nullable: false),
                    SquareMeterUSD = table.Column<int>(type: "int", nullable: false),
                    AnnouncmentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Announcments_AnnouncmentId",
                        column: x => x.AnnouncmentId,
                        principalTable: "Announcments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prices_AnnouncmentId",
                table: "Prices",
                column: "AnnouncmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
