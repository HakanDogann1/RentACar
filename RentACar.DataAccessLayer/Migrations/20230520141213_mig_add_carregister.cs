using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class mig_add_carregister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarRegisters",
                columns: table => new
                {
                    CarRegisterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRegisters", x => x.CarRegisterID);
                    table.ForeignKey(
                        name: "FK_CarRegisters_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarRegisters_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarRegisters_AppUserID",
                table: "CarRegisters",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CarRegisters_CarID",
                table: "CarRegisters",
                column: "CarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRegisters");
        }
    }
}
