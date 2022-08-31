using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AgenteDAL
    {
        public AgenteP Inserir(AgenteP _agentep)
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
                    Value = _agentep.Id
                });

                cmd.Parameters.Add(new SqlParameter("@NomeAgente", SqlDbType.VarChar)
                {
                    Value = _agentep.NomeAgente
                });

                cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)
                {
                    Value = _agentep.Senha
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _agentep.NomeUsuario
                });

                cn.Open();

                _agentep.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _agentep;
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
