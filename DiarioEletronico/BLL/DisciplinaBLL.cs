using DAL;
using Model;

namespace BLL
{
    public class DisciplinaBLL
    {
        public Disciplina Inserir(Disciplina disciplina)
        {
            DisciplinaDAL disciplinaDAL = new DisciplinaDAL();
            return disciplinaDAL.Inserir(disciplina);
        }
    }
}
