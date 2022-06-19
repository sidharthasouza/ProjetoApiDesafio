using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoApiDesafio.Model
{
    public class Tarefa
    {
        [Key]
        public int Codigo { get; set; }
        public string Fase { get; set; } //Aguardando, Em Andamento, Pendência, Finalizado, Outros
        public string Titulo { get; set; }
        public string Projeto { get; set; }
        public DateTime DataHoraPrevisao { get; set; } //Guarda a data e hora prevista
        public string Descricao { get; set; }
        public string Equipe { get; set; } //Desenvolvimento, Ux/Ui, Financeiro
        public int Sequencia { get; set; }

    }
}
