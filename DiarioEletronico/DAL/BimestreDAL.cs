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
    public class BimestreDAL
    {
        public Bimestre Inserir(Bimestre _bimestre)
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
                    Value = _bimestre.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Bimestres", SqlDbType.VarChar)
                {
                    Value = _bimestre.Bimestres
                });

                cn.Open();

                _bimestre.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _bimestre;
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
