using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto1.Migrations
{
    public partial class Juan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bancos",
                columns: table => new
                {
                    BancoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sucursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Encargado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bancos", x => x.BancoId);
                });

            migrationBuilder.CreateTable(
                name: "prestamos",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Plazo = table.Column<int>(type: "int", nullable: false),
                    Interes = table.Column<int>(type: "int", nullable: false),
                    CuotaMensual = table.Column<int>(type: "int", nullable: false),
                    TotalDeuda = table.Column<int>(type: "int", nullable: false),
                    BancoId = table.Column<int>(type: "int", nullable: false),
                    MicrempresarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.PrestamoId);
                    table.ForeignKey(
                        name: "FK_prestamos_bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "bancos",
                        principalColumn: "BancoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_BancoId",
                table: "prestamos",
                column: "BancoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prestamos");

            migrationBuilder.DropTable(
                name: "bancos");
        }
    }
}
