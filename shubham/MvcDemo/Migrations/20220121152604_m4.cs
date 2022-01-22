using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcDemo.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_LocationId",
                table: "customers",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_location_LocationId",
                table: "customers",
                column: "LocationId",
                principalTable: "location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_location_LocationId",
                table: "customers");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropIndex(
                name: "IX_customers_LocationId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "customers");
        }
    }
}
