using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Price : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Announcments");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "HouseOwners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Announcments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalGEL = table.Column<int>(type: "int", nullable: false),
                    TotalUSD = table.Column<int>(type: "int", nullable: false),
                    SquareMeterGEL = table.Column<int>(type: "int", nullable: false),
                    SquareMeterUSD = table.Column<int>(type: "int", nullable: false),
                    AnnouncmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Announcments_AnnouncmentId",
                        column: x => x.AnnouncmentId,
                        principalTable: "Announcments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prices_AnnouncmentId",
                table: "Prices",
                column: "AnnouncmentId",
                unique: true,
                filter: "[AnnouncmentId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HouseOwners");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Announcments");

            migrationBuilder.AddColumn<Guid>(
                name: "PriceId",
                table: "Announcments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
