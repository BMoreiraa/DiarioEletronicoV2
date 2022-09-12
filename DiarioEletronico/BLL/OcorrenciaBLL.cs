using DAL;
using Model;

namespace BLL
{
    public class OcorrenciaBLL
    {
        public Ocorrencia Inserir(Ocorrencia _ocorrencia)
        {
            OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();
            return ocorrenciaDAL.Inserir(_ocorrencia);

        }
    }
}
