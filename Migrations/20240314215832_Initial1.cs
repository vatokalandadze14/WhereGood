using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HouseOwners",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Agent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    HouseOwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcments_HouseOwners_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "HouseOwners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcments_HouseOwnerId",
                table: "Announcments",
                column: "HouseOwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcments");

            migrationBuilder.DropTable(
                name: "HouseOwners");
        }
    }
}
