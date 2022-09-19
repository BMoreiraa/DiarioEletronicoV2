using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class AlunoBLL
    {
        public Aluno Inserir(Aluno aluno)
        {
           AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.Inserir(aluno);
        }

        public DataTable Buscar(string _filtro)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.Buscar(_filtro);
        }
        public DataTable BuscarPorTurma(string _filtro)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.BuscarPorTurma(_filtro);
        }
    }
}
