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
    public class DiarioDAL
    {
        public Diario Inserir(Diario _diario)
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
                    Value = _diario.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Discplina", SqlDbType.Int)
                {
                    Value = _diario.Id_Discplina
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Professor", SqlDbType.Int)
                {
                    Value = _diario.Id_Professor
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", SqlDbType.Int)
                {
                    Value = _diario.Id_Turma
                });

                cn.Open();

                _diario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _diario;
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
