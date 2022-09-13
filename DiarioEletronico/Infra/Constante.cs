using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Constante
    {
        public static string DiretorioDoEnderecoBanco = Environment.CurrentDirectory + @"\Servididor\";
        public static string NomeArquivoBanco = "Endereço do servido.txt";
    }

        public static void GravaStringDeConexaoNoArquivo(string _texto)
        {
            string nomeArquivo = "BD";

            if (!Directory.Exists(Constante.DiretorioDoEnderecoBanco))
            Directory.CreateDirectory(Constante.DiretorioDoEnderecoBanco);

        for (int i = 1; i > 0; i++)
        {
            if (!File.Exists(Constante.DiretorioDoEnderecoBanco + nomeArquivo + i + ".txt"))
            {
                FileStream fileStream = new FileStream(Constante.DiretorioDoEnderecoBanco + nomeArquivo + ".txt", FileMode.Create);

            }
        }

    }
}
