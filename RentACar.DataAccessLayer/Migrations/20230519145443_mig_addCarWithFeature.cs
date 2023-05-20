using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class mig_addCarWithFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    CarBrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.CarBrandID);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarFeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.CarFeatureID);
                });

            migrationBuilder.CreateTable(
                name: "CarTransmission",
                columns: table => new
                {
                    CarTransmissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarTransmissionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTransmission", x => x.CarTransmissionID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrandID = table.Column<int>(type: "int", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarMillage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarTransmissionID = table.Column<int>(type: "int", nullable: false),
                    CarSeats = table.Column<int>(type: "int", nullable: false),
                    CarLuggage = table.Column<int>(type: "int", nullable: false),
                    CarFuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Cars_CarBrands_CarBrandID",
                        column: x => x.CarBrandID,
                        principalTable: "CarBrands",
                        principalColumn: "CarBrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarTransmission_CarTransmissionID",
                        column: x => x.CarTransmissionID,
                        principalTable: "CarTransmission",
                        principalColumn: "CarTransmissionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarWithFeatures",
                columns: table => new
                {
                    CarWithFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarFeatureID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarWithFeatures", x => x.CarWithFeatureID);
                    table.ForeignKey(
                        name: "FK_CarWithFeatures_CarFeatures_CarFeatureID",
                        column: x => x.CarFeatureID,
                        principalTable: "CarFeatures",
                        principalColumn: "CarFeatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarWithFeatures_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarBrandID",
                table: "Cars",
                column: "CarBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTransmissionID",
                table: "Cars",
                column: "CarTransmissionID");

            migrationBuilder.CreateIndex(
                name: "IX_CarWithFeatures_CarFeatureID",
                table: "CarWithFeatures",
                column: "CarFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_CarWithFeatures_CarID",
                table: "CarWithFeatures",
                column: "CarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarWithFeatures");

            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarBrands");

            migrationBuilder.DropTable(
                name: "CarTransmission");
        }
    }
}
