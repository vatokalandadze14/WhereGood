using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class PriceMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "HouseOwners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "PriceId",
                table: "Announcments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcments_PriceId",
                table: "Announcments",
                column: "PriceId",
                unique: true,
                filter: "[PriceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcments_Prices_PriceId",
                table: "Announcments",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcments_Prices_PriceId",
                table: "Announcments");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Announcments_PriceId",
                table: "Announcments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HouseOwners");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Announcments");

            migrationBuilder.AlterColumn<Guid>(
                name: "PriceId",
                table: "Announcments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
