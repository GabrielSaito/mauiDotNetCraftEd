using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_maui.Models.PortalProfessor
{
    internal class Professor
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Contato { get; set; }
        public List<Aula> Aulas { get; set; }
    }
}
