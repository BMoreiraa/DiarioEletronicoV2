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
    class OcorrenciaDAL
    {
        public Ocorrencia Inserir(Ocorrencia _ocorrencia)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirOcorrencia";

                cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.Int)
                {
                    Value = _ocorrencia.Id
                });

                cmd.Parameters.Add(new SqlParameter("Id_Aluno", SqlDbType.Int)
                {
                    Value = _ocorrencia.Id_Aluno
                });

                cmd.Parameters.Add(new SqlParameter("Id_Diario", SqlDbType.Int)
                {
                    Value = _ocorrencia.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("Descricao", SqlDbType.VarChar)
                {
                    Value = _ocorrencia.Descricao
                });

                return _ocorrencia;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
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
