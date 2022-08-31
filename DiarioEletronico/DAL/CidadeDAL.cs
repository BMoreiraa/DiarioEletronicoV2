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
    public class CidadeDAL
    {
        public Cidade Inserir(Cidade _cidade)
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
                    Value = _cidade.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_UF", SqlDbType.Int)
                {
                    Value = _cidade.Id_UF
                });

                cmd.Parameters.Add(new SqlParameter("@NomeCidade", SqlDbType.VarChar)
                {
                    Value = _cidade.NomeCidade
                });

                cn.Open();

                _cidade.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _cidade;
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
