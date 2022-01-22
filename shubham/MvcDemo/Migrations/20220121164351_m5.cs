using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcDemo.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_location_LocationId",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_location",
                table: "location");

            migrationBuilder.RenameTable(
                name: "location",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_Locations_LocationId",
                table: "customers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Locations_LocationId",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_location",
                table: "location",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_location_LocationId",
                table: "customers",
                column: "LocationId",
                principalTable: "location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
