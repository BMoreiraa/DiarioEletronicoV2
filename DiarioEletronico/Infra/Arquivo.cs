using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Arquivo
    {
        public static ArrayList BuscarConecoesBD()
        {
            ArrayList retornoArray = new ArrayList();

            string[] caminho = Directory.GetFiles(Constante.DiretorioDoEnderecoBanco, "BD*");
            for(int i = 0; i < caminho.Length; i++)
            {
                string conteudo = File.ReadAllText(caminho[i]);
                retornoArray.Add(FuncoesGlobais.Base64Decode(conteudo));
            }
            return retornoArray;
        }
    }
}
