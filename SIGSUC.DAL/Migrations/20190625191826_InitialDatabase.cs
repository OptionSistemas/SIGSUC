using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGSUC.DAL.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continentes",
                columns: table => new
                {
                    ContinenteId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continentes", x => x.ContinenteId);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    PaisId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    CodigoArea = table.Column<string>(type: "varchar(4)", nullable: true),
                    ContinenteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.PaisId);
                    table.ForeignKey(
                        name: "FK_Paises_Continentes_ContinenteId",
                        column: x => x.ContinenteId,
                        principalTable: "Continentes",
                        principalColumn: "ContinenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regioes",
                columns: table => new
                {
                    PaisId = table.Column<int>(nullable: false),
                    RegiaoId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioes", x => new { x.PaisId, x.RegiaoId });
                    table.ForeignKey(
                        name: "FK_Regioes_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UFs",
                columns: table => new
                {
                    PaisId = table.Column<int>(nullable: false),
                    SiglaId = table.Column<string>(type: "varchar(2)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    RegiaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UFs", x => new { x.PaisId, x.SiglaId });
                    table.ForeignKey(
                        name: "FK_UFs_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UFs_Regioes_PaisId_RegiaoId",
                        columns: x => new { x.PaisId, x.RegiaoId },
                        principalTable: "Regioes",
                        principalColumns: new[] { "PaisId", "RegiaoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paises_ContinenteId",
                table: "Paises",
                column: "ContinenteId");

            migrationBuilder.CreateIndex(
                name: "IX_UFs_PaisId_RegiaoId",
                table: "UFs",
                columns: new[] { "PaisId", "RegiaoId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UFs");

            migrationBuilder.DropTable(
                name: "Regioes");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Continentes");
        }
    }
}
