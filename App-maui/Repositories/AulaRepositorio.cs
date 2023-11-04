using App_maui.Models.PortalProfessor;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftEd.Repositories
{
    public class AulaRepositorio : IAulaRepositorio
    {
        private readonly LiteDatabase _bancodeDados;
        private readonly string coluna = "Aula";

        public AulaRepositorio(LiteDatabase bancoDeDados) {
            _bancodeDados = bancoDeDados;
        }  
        public List<Aula> GetAll()
        {
            return _bancodeDados
           .GetCollection<Aula>(coluna).Query().OrderByDescending(a => a.Data).ToList();
        }
        public void Add(Aula aula)
        {
            var col = _bancodeDados.GetCollection<Aula>(coluna);
            col.Insert(aula);
            col.EnsureIndex(a => a.Data);  
        }
        public void Update(Aula aula)
        {
            var col = _bancodeDados.GetCollection<Aula>(coluna);
            col.Update(aula);
        }
        public void Delete(Aula aula)
        {
            var col = _bancodeDados.GetCollection<Aula>(coluna);
            col.Delete(aula.Id);    
        }
    }
}
