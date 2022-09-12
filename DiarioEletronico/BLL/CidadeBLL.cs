using DAL;
using Model;

namespace BLL
{
    public class CidadeBLL
    {
        public Cidade Inserir(Cidade cidade)
        {
            CidadeDAL cidadeDAL = new CidadeDAL();
            return cidadeDAL.Inserir(cidade);
        }
    }
}
