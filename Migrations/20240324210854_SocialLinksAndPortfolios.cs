using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseOwnerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class SocialLinksAndPortfolios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Agencies_AgencyId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Announcments_AnnouncmentId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolio_InterierCompanies_InterierCompanyId",
                table: "Portfolio");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialLink_Agencies_AgencyId",
                table: "SocialLink");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AgencyId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AnnouncmentId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialLink",
                table: "SocialLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio");

            migrationBuilder.RenameTable(
                name: "SocialLink",
                newName: "SocialLinks");

            migrationBuilder.RenameTable(
                name: "Portfolio",
                newName: "Portfolios");

            migrationBuilder.RenameIndex(
                name: "IX_SocialLink_AgencyId",
                table: "SocialLinks",
                newName: "IX_SocialLinks_AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolio_InterierCompanyId",
                table: "Portfolios",
                newName: "IX_Portfolios_InterierCompanyId");

            migrationBuilder.AlterColumn<Guid>(
                name: "AnnouncmentId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AgencyId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialLinks",
                table: "SocialLinks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AgencyId",
                table: "Addresses",
                column: "AgencyId",
                unique: true,
                filter: "[AgencyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AnnouncmentId",
                table: "Addresses",
                column: "AnnouncmentId",
                unique: true,
                filter: "[AnnouncmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Agencies_AgencyId",
                table: "Addresses",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Announcments_AnnouncmentId",
                table: "Addresses",
                column: "AnnouncmentId",
                principalTable: "Announcments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_InterierCompanies_InterierCompanyId",
                table: "Portfolios",
                column: "InterierCompanyId",
                principalTable: "InterierCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialLinks_Agencies_AgencyId",
                table: "SocialLinks",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Agencies_AgencyId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Announcments_AnnouncmentId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_InterierCompanies_InterierCompanyId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialLinks_Agencies_AgencyId",
                table: "SocialLinks");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AgencyId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AnnouncmentId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialLinks",
                table: "SocialLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.RenameTable(
                name: "SocialLinks",
                newName: "SocialLink");

            migrationBuilder.RenameTable(
                name: "Portfolios",
                newName: "Portfolio");

            migrationBuilder.RenameIndex(
                name: "IX_SocialLinks_AgencyId",
                table: "SocialLink",
                newName: "IX_SocialLink_AgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_InterierCompanyId",
                table: "Portfolio",
                newName: "IX_Portfolio_InterierCompanyId");

            migrationBuilder.AlterColumn<Guid>(
                name: "AnnouncmentId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AgencyId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialLink",
                table: "SocialLink",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AgencyId",
                table: "Addresses",
                column: "AgencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AnnouncmentId",
                table: "Addresses",
                column: "AnnouncmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Agencies_AgencyId",
                table: "Addresses",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Announcments_AnnouncmentId",
                table: "Addresses",
                column: "AnnouncmentId",
                principalTable: "Announcments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_InterierCompanies_InterierCompanyId",
                table: "Portfolio",
                column: "InterierCompanyId",
                principalTable: "InterierCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialLink_Agencies_AgencyId",
                table: "SocialLink",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }
    }
}
