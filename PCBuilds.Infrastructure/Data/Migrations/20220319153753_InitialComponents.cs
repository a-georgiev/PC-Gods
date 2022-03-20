using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCBuilds.Data.Migrations
{
    public partial class InitialComponents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sockets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sockets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coolers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinRpm = table.Column<int>(type: "int", nullable: false),
                    MaxRpm = table.Column<int>(type: "int", nullable: false),
                    Noise = table.Column<int>(type: "int", nullable: false),
                    SocketId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocketId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coolers_Sockets_SocketId1",
                        column: x => x.SocketId1,
                        principalTable: "Sockets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoresCount = table.Column<int>(type: "int", nullable: false),
                    CoreClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BoostClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Tdp = table.Column<int>(type: "int", nullable: false),
                    Series = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Microarchitecture = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HasIntegratedGraphic = table.Column<bool>(type: "bit", nullable: false),
                    MaxMemmory = table.Column<int>(type: "int", nullable: false),
                    HasCooler = table.Column<bool>(type: "bit", nullable: false),
                    SocketId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocketId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cpus_Sockets_SocketId1",
                        column: x => x.SocketId1,
                        principalTable: "Sockets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coolers_SocketId1",
                table: "Coolers",
                column: "SocketId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_SocketId1",
                table: "Cpus",
                column: "SocketId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coolers");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Sockets");
        }
    }
}
