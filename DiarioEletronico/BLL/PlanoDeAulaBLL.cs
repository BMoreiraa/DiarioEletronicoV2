using DAL;
using Model;

namespace BLL
{
    public class PlanoDeAulaBLL
    {
        public PlanoDeAula Inserir(PlanoDeAula _planoDeAula)
        {

            PlanoDeAulaDAL planoDeAulaDAL = new PlanoDeAulaDAL();
            return planoDeAulaDAL.Inserir(_planoDeAula);
        }
    }
}
