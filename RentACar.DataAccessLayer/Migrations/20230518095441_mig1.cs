using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutUsID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogContentTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogContentTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogContentDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogContentDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "ContactMes",
                columns: table => new
                {
                    ContactMeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactMeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMeImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMes", x => x.ContactMeID);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    HeaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderVideo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.HeaderID);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    ReferenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ReferenceID);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    ReserveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PıckUpLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DropOffLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PıckUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropOfDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.ReserveID);
                });

            migrationBuilder.CreateTable(
                name: "ReserveServices",
                columns: table => new
                {
                    ReserveServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReserveServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReserveServiceIcon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveServices", x => x.ReserveServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    StatisticID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatisticTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatisticValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.StatisticID);
                });

            migrationBuilder.CreateTable(
                name: "TagClouds",
                columns: table => new
                {
                    TagCloudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagCloudTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagClouds", x => x.TagCloudID);
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    BlogCommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCommentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCommentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCommentEMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCommentMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.BlogCommentID);
                    table.ForeignKey(
                        name: "FK_BlogComments_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogWithTagClouds",
                columns: table => new
                {
                    BlogWithTagCloudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogID = table.Column<int>(type: "int", nullable: false),
                    TagCloudID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogWithTagClouds", x => x.BlogWithTagCloudID);
                    table.ForeignKey(
                        name: "FK_BlogWithTagClouds_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogWithTagClouds_TagClouds_TagCloudID",
                        column: x => x.TagCloudID,
                        principalTable: "TagClouds",
                        principalColumn: "TagCloudID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogID",
                table: "BlogComments",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogWithTagClouds_BlogID",
                table: "BlogWithTagClouds",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogWithTagClouds_TagCloudID",
                table: "BlogWithTagClouds",
                column: "TagCloudID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "BlogWithTagClouds");

            migrationBuilder.DropTable(
                name: "ContactMes");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "ReserveServices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "TagClouds");
        }
    }
}
