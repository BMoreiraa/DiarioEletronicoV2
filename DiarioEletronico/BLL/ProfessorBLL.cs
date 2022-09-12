using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProfessorBLL
    {
        public Professor Inserir(Professor _professor)
        {
            ProfessorDAL professorDAL = new ProfessorDAL();
            /*_professor.Senha = Infra.Criptografia.GetHash(_professor.Senha);*/
            return professorDAL.Inserir(_professor);

        }
    }
}
