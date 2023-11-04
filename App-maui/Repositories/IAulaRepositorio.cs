using App_maui.Models.PortalProfessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftEd.Repositories
{
    internal interface IAulaRepositorio
    {
        void Add(Aula aula);
        void Delete(Aula aula);
        void Update(Aula aula);
        List<Aula> GetAll();
    }
}
