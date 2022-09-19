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
                cmd.CommandText = "SP_InserirAgente";

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

        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarAgente";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt; ;

            }
            catch (SqlException ex)
            {

                throw new Exception("servidor SQL Erro" + ex.Message);
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
