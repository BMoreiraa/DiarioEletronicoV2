using DAL;
using Model;

namespace BLL
{
    public class AlunoBLL
    {
        public Aluno Inserir(Aluno aluno)
        {
           AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.Inserir(aluno);
        }
    }
}
