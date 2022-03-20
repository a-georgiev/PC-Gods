using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCBuilds.Data.Migrations
{
    public partial class Allcomponents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coolers_Sockets_SocketId1",
                table: "Coolers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cpus_Sockets_SocketId1",
                table: "Cpus");

            migrationBuilder.DropTable(
                name: "Sockets");

            migrationBuilder.DropIndex(
                name: "IX_Cpus_SocketId1",
                table: "Cpus");

            migrationBuilder.DropIndex(
                name: "IX_Coolers_SocketId1",
                table: "Coolers");

            migrationBuilder.DropColumn(
                name: "SocketId",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "SocketId1",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "SocketId",
                table: "Coolers");

            migrationBuilder.DropColumn(
                name: "SocketId1",
                table: "Coolers");

            migrationBuilder.AddColumn<string>(
                name: "Socket",
                table: "Cpus",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Socket",
                table: "Coolers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaxMemmory = table.Column<int>(type: "int", nullable: false),
                    MemmoryType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MemmorySlots = table.Column<int>(type: "int", nullable: false),
                    MemmorySpeed = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EfficientyPercent = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Watage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsModular = table.Column<bool>(type: "bit", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Memmory = table.Column<int>(type: "int", nullable: false),
                    MemmoryType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CoreClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BoostClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Tdp = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CpuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoolerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotherboardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VideoCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PowerSupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builds_Coolers_CoolerId",
                        column: x => x.CoolerId,
                        principalTable: "Coolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Cpus_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Motherboards_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_PowerSupplies_PowerSupplyId",
                        column: x => x.PowerSupplyId,
                        principalTable: "PowerSupplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_VideoCards_VideoCardId",
                        column: x => x.VideoCardId,
                        principalTable: "VideoCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memmories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Modules = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Cas = table.Column<int>(type: "int", nullable: false),
                    Voltage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BuildId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memmories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memmories_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Interface = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BuildId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storages_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CoolerId",
                table: "Builds",
                column: "CoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CpuId",
                table: "Builds",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_MotherboardId",
                table: "Builds",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_PowerSupplyId",
                table: "Builds",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_VideoCardId",
                table: "Builds",
                column: "VideoCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Memmories_BuildId",
                table: "Memmories",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_BuildId",
                table: "Storages",
                column: "BuildId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memmories");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "VideoCards");

            migrationBuilder.DropColumn(
                name: "Socket",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "Socket",
                table: "Coolers");

            migrationBuilder.AddColumn<string>(
                name: "SocketId",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "SocketId1",
                table: "Cpus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "SocketId",
                table: "Coolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "SocketId1",
                table: "Coolers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_SocketId1",
                table: "Cpus",
                column: "SocketId1");

            migrationBuilder.CreateIndex(
                name: "IX_Coolers_SocketId1",
                table: "Coolers",
                column: "SocketId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Coolers_Sockets_SocketId1",
                table: "Coolers",
                column: "SocketId1",
                principalTable: "Sockets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cpus_Sockets_SocketId1",
                table: "Cpus",
                column: "SocketId1",
                principalTable: "Sockets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
