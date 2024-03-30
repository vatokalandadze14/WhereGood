using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class CompaniesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Announcments_AnnouncmentId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_InterierCompanies_InterierCompanyId",
                table: "Portfolios");

            migrationBuilder.DropTable(
                name: "InterierCompanies");

            migrationBuilder.AlterColumn<Guid>(
                name: "InterierCompanyId",
                table: "Portfolios",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AnnouncmentId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Agencies",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Announcments_AnnouncmentId",
                table: "Images",
                column: "AnnouncmentId",
                principalTable: "Announcments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Agencies_InterierCompanyId",
                table: "Portfolios",
                column: "InterierCompanyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Announcments_AnnouncmentId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Agencies_InterierCompanyId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Agencies");

            migrationBuilder.AlterColumn<Guid>(
                name: "InterierCompanyId",
                table: "Portfolios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AnnouncmentId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "InterierCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterierCompanies", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Announcments_AnnouncmentId",
                table: "Images",
                column: "AnnouncmentId",
                principalTable: "Announcments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_InterierCompanies_InterierCompanyId",
                table: "Portfolios",
                column: "InterierCompanyId",
                principalTable: "InterierCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
