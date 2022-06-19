using Microsoft.EntityFrameworkCore;
using ProjetoApiDesafio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoApiDesafio
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .HasData(
                    new Tarefa
                    {
                        Codigo = 1,
                        Fase = "Em Andamento",
                        Titulo = "CRIAR MIGRATION",
                        Projeto = "Company",
                        DataHoraPrevisao = DateTime.Now,
                        Descricao = "Usar...",
                        Equipe = "DESENVOLVIMENTO",
                        Sequencia = 1
                    }
                );
        }
    }
}
