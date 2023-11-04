using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_maui.Models.PortalProfessor
{
    public class Aula
    {
        [BsonId]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Materia { get; set; }
        public string Conteudo { get; set; }
        public string Observacoes { get; set; }
        public List<Aluno> AlunosPresentes { get; set; }
    }
}
