using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AlunoDAL
    {
        public Aluno Inserir(Aluno _aluno)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString =
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
