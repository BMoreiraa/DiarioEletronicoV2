using DAL;
using Model;

namespace BLL
{
    public class DiarioBLL
    {
        public Diario Inserir(Diario diario)
        {
            DiarioDAL diarioDAL = new DiarioDAL();
            return diarioDAL.Inserir(diario);
        }
    }
}
