using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class mig_addCarPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CarPrice",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarPrice",
                table: "Cars");
        }
    }
}
