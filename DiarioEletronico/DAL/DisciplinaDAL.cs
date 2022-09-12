using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DisciplinaDAL
    {
        public Disciplina Inserir(Disciplina _disciplina)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirDisciplina";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _disciplina.Id
                });

                cmd.Parameters.Add(new SqlParameter("@NomeDisciplina", SqlDbType.VarChar)
                {
                    Value = _disciplina.NomeDisciplina
                });

                cn.Open();

                _disciplina.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _disciplina;
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
    }
}
