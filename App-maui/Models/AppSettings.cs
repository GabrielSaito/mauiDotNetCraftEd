using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftEd.Models
{
    internal class AppSettings
    {
        public static string BancoDeDadosNome= "bancodedados.db";
        public static string BancoDeDadosDiretorio = FileSystem.AppDataDirectory;
        public static string BancoDeDadosPatch = Path.Combine(BancoDeDadosDiretorio, BancoDeDadosNome);
    }
}
