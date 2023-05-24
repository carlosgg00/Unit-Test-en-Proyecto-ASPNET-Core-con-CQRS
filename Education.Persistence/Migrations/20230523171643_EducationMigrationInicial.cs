using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Education.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EducationMigrationInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Descripcion", "FechaCreacion", "FechaPublicacion", "Precio", "Titulo" },
                values: new object[,]
                {
                    { new Guid("01c21bc7-bb24-4a17-b985-32a0ed6262b8"), "Curso de Unit Test para NET Core", new DateTime(2023, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5812), new DateTime(2025, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5813), 1000m, "Master en Unit Test con CQRS" },
                    { new Guid("53a13360-2e32-4f91-bd4f-0552c919eafc"), "Curso de C# Java", new DateTime(2023, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5804), new DateTime(2025, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5805), 25m, "Master en Java Spring desde las raices" },
                    { new Guid("ff3596b4-e701-4809-aebb-68d61c25b567"), "Curso de C# basico", new DateTime(2023, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5767), new DateTime(2025, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5774), 56m, "C# desde cero hasta avanzado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
