using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FrequenciaDAL
    {
        public Frequencia Inserir(Frequencia _frequencia)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirFrequencia";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _frequencia.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", SqlDbType.Int)
                {
                    Value = _frequencia.Id_Aluno
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Diario", SqlDbType.Int)
                {
                    Value = _frequencia.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@Faltas", SqlDbType.Float)
                {
                    Value = _frequencia.Faltas
                });

                cmd.Parameters.Add(new SqlParameter("@Data_", SqlDbType.DateTime)
                {
                    Value = _frequencia.Data_
                });

                cn.Open();

                _frequencia.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _frequencia;
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
