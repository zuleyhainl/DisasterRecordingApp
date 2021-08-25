using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Migration_two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisasterImgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisasterId = table.Column<int>(type: "int", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisasterImgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisasterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisasterTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlideNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    PlaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CauseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisasterImgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disasters_DisasterImgs_DisasterImgId",
                        column: x => x.DisasterImgId,
                        principalTable: "DisasterImgs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disasters_DisasterTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "DisasterTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disasters_DisasterImgId",
                table: "Disasters",
                column: "DisasterImgId");

            migrationBuilder.CreateIndex(
                name: "IX_Disasters_TypeId",
                table: "Disasters",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disasters");

            migrationBuilder.DropTable(
                name: "DisasterImgs");

            migrationBuilder.DropTable(
                name: "DisasterTypes");
        }
    }
}
