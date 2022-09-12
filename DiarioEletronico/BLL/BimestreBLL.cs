using DAL;
using Model;

namespace BLL
{
    public class BimestreBLL
    {
        public Bimestre Inserir(Bimestre bimestre)
        {
            BimestreDAL bimestreDAL = new BimestreDAL();   
            return bimestreDAL.Inserir(bimestre);
        }
    }
}
