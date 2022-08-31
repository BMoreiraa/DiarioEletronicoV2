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
    public class PlanoDeAulaDAL
    {
        public PlanoDeAula Inserir(PlanoDeAula _planoDeAula)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirPlanoDeAula";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _planoDeAula.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_professor", SqlDbType.Int)
                {
                    Value = _planoDeAula.Id_professor
                });

                cmd.Parameters.Add(new SqlParameter("@Id_diario", SqlDbType.Int)
                {
                    Value = _planoDeAula.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@conteudo", SqlDbType.VarChar)
                {
                    Value = _planoDeAula.Conteudo
                });

                return _planoDeAula;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
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
