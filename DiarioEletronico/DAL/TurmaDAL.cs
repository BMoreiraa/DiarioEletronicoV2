using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TurmaDAL
    {
        public Turma Inserir(Turma _turma)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirTurma";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _turma.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.Int)
                {
                    Value = _turma.Serie
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Turno", SqlDbType.Int)
                {
                    Value = _turma.Id_TURNO
                });

                cn.Open();
                _turma.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _turma;


            }
            catch (SqlException ex)
            {

                throw new Exception("Serviço SQL Erro:" + ex.Message);

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
