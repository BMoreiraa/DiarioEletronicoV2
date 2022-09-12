using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NotaDAL
    {
        public Nota Inserir(Nota _nota)
        {

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirNota";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _nota.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", SqlDbType.Int)
                {
                    Value = _nota.Id_Aluno
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", SqlDbType.Int)
                {
                    Value = _nota.Id_Turma
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Diario", SqlDbType.Int)
                {
                    Value = _nota.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@notaAluno", SqlDbType.Float)
                {
                    Value = _nota.Lancar_Nota
                });

                cn.Open();

                _nota.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _nota;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        /*###################################################################################################################################*/
    }
}
