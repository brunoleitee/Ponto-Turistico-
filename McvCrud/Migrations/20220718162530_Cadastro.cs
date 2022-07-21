using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace McvCrud.Migrations
{
    public partial class Cadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
