using DAL;
using Model;

namespace BLL
{
    public class TurmaBLL
    {
        public Turma Inserir(Turma _turma)
        {
            TurmaDAL turmaDAL = new TurmaDAL();
            return turmaDAL.Inserir(_turma);
        }
    }
}
