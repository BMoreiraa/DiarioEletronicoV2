using DAL;
using Model;

namespace BLL
{
    public class FrequenciaBLL
    {
        public Frequencia Inserir(Frequencia frequencia)
        {
            FrequenciaDAL frequenciaDAL = new FrequenciaDAL();
            return frequenciaDAL.Inserir(frequencia);
        }
    }
}
