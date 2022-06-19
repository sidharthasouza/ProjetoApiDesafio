using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ProjetoApiDesafio.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Tarefa",
            columns: table => new
            {
                Codigo = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                Fase = table.Column<string>(nullable: true),
                Titulo = table.Column<string>(nullable: true),
                Projeto = table.Column<string>(nullable: true),
                DataHoraPrevisao = table.Column<DateTime>(nullable: true),
                Descricao = table.Column<string>(nullable: true),
                Equipe = table.Column<string>(nullable: true),
                Sequencia = table.Column<int>(nullable: true),
            });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
