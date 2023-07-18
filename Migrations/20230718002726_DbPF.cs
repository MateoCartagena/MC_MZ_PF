using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_MZ_PF.Migrations
{
    public partial class DbPF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsuntoArt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CuerpoArt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaArt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cultura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsuntoCul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CuerpoCul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCul = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsuntoDep = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CuerpoDep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDep = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deporte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsuntoTec = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CuerpoTec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaTec = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arte");

            migrationBuilder.DropTable(
                name: "Cultura");

            migrationBuilder.DropTable(
                name: "Deporte");

            migrationBuilder.DropTable(
                name: "Tecnologia");
        }
    }
}
