using DAL;
using Model;

namespace BLL
{
    public class NotaBLL
    {
        public Nota Inserir(Nota _nota)
        {

            NotaDAL notaDAL = new NotaDAL();
            return notaDAL.Inserir(_nota);
        }
    }
}
