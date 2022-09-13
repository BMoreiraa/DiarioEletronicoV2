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
    public static class UsuarioLogado
    {
        public static string conexaoAtual = "";
    }

    public static class ArquivoBanco
    {
        public static void GravaStringDeConexaoNoArquivo(string _texto)
        {
            string nomeArquivo = "BD";

            if (!Directory.Exists(Constante.DiretorioDoEnderecoBanco))
                Directory.CreateDirectory(Constante.DiretorioDoEnderecoBanco);

            for (int i = 1; i > 0; i++)
            {
                if (!File.Exists(Constante.DiretorioDoEnderecoBanco + nomeArquivo + i + ".txt"))
                {
                    FileStream fileStream = new FileStream(Constante.DiretorioDoEnderecoBanco + nomeArquivo + i + ".txt", FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
                    streamWriter.Write(FuncoesGlobais.Base64Encode(_texto));
                    streamWriter.Flush();
                    streamWriter.Close();
                    fileStream.Close();
                    break;
                }
            }
        }
        public static void GravarEnderecoBancoNoArquivo(string _texto, string _caminho)
        {
            FileStream fileStream = new FileStream(_caminho, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.Write(_texto);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public static void CriarPasta(string _caminho)
        {
            Directory.CreateDirectory(_caminho);
        }

        public static void Gravarbanco(string _texto)
        {
            CriarPasta(Constante.DiretorioDoEnderecoBanco);
            GravarEnderecoBancoNoArquivo(_texto, Constante.DiretorioDoEnderecoBanco + "\\" + Constante.NomeArquivoBanco);
        }
    }
}
