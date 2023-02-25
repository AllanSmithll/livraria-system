using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APILivraria.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DataNascimento = table.Column<int>(type: "int", nullable: false),
                    Obras = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.IdAutor);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Isbn = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Subtitulo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Resumo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    QuantPaginas = table.Column<int>(type: "int", nullable: false),
                    DataPublicacao = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    Edicao = table.Column<int>(type: "int", nullable: (true)),
                    NomeAutor = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NomeEditora = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Isbn);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
