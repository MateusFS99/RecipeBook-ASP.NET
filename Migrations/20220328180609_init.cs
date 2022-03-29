using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook_ASP.NET.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ingredientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "receitas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(type: "TEXT", nullable: false),
                    instrucoes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receitas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "receitasIngredientes",
                columns: table => new
                {
                    receitaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ingredienteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receitasIngredientes", x => new { x.receitaId, x.ingredienteId });
                    table.ForeignKey(
                        name: "FK_receitasIngredientes_ingredientes_ingredienteId",
                        column: x => x.ingredienteId,
                        principalTable: "ingredientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_receitasIngredientes_receitas_receitaId",
                        column: x => x.receitaId,
                        principalTable: "receitas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ingredientes",
                columns: new[] { "id", "nome" },
                values: new object[] { 1, "Feijão" });

            migrationBuilder.InsertData(
                table: "ingredientes",
                columns: new[] { "id", "nome" },
                values: new object[] { 2, "Fubá" });

            migrationBuilder.InsertData(
                table: "ingredientes",
                columns: new[] { "id", "nome" },
                values: new object[] { 3, "Chocolate" });

            migrationBuilder.InsertData(
                table: "ingredientes",
                columns: new[] { "id", "nome" },
                values: new object[] { 4, "Farinha" });

            migrationBuilder.InsertData(
                table: "receitas",
                columns: new[] { "id", "instrucoes", "titulo" },
                values: new object[] { 1, "", "Feijoada" });

            migrationBuilder.InsertData(
                table: "receitas",
                columns: new[] { "id", "instrucoes", "titulo" },
                values: new object[] { 2, "", "Cuzcuz" });

            migrationBuilder.InsertData(
                table: "receitas",
                columns: new[] { "id", "instrucoes", "titulo" },
                values: new object[] { 3, "", "Brigadeiro" });

            migrationBuilder.InsertData(
                table: "receitas",
                columns: new[] { "id", "instrucoes", "titulo" },
                values: new object[] { 4, "", "Bolo de Chocolate" });

            migrationBuilder.InsertData(
                table: "receitasIngredientes",
                columns: new[] { "ingredienteId", "receitaId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "receitasIngredientes",
                columns: new[] { "ingredienteId", "receitaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "receitasIngredientes",
                columns: new[] { "ingredienteId", "receitaId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "receitasIngredientes",
                columns: new[] { "ingredienteId", "receitaId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "receitasIngredientes",
                columns: new[] { "ingredienteId", "receitaId" },
                values: new object[] { 4, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_receitasIngredientes_ingredienteId",
                table: "receitasIngredientes",
                column: "ingredienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "receitasIngredientes");

            migrationBuilder.DropTable(
                name: "ingredientes");

            migrationBuilder.DropTable(
                name: "receitas");
        }
    }
}
