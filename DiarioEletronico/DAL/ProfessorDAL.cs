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
    class ProfessorDAL
    {
        public Professor Inserir(Professor _professor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirProfessor";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _professor.Id
                });

                cmd.Parameters.Add(new SqlParameter("@NomeProfessor", SqlDbType.VarChar)
                {
                    Value = _professor.Nome
                });

                cmd.Parameters.Add(new SqlParameter("@CPF_Professor", SqlDbType.VarChar)
                {
                    Value = _professor.CPF
                });

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _professor.Email
                });

                cmd.Parameters.Add(new SqlParameter("@Telefone", SqlDbType.VarChar)
                {
                    Value = _professor.Telefone
                });

                cmd.Parameters.Add(new SqlParameter("@DataDeNascimento", SqlDbType.VarChar)
                {
                    Value = _professor.DataDeNascimento
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Sexo", SqlDbType.Int)
                {
                    Value = _professor.Id_Sexo
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Cidade", SqlDbType.Int)
                {
                    Value = _professor.Id_cidade
                });

                cmd.Parameters.Add(new SqlParameter("@EnderecoProfessor", SqlDbType.VarChar)
                {
                    Value = _professor.Endereco
                });

                cmd.Parameters.Add(new SqlParameter("@Setor", SqlDbType.VarChar)
                {
                    Value = _professor.Setor
                });

                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)
                {
                    Value = _professor.CEP
                });

                cmd.Parameters.Add(new SqlParameter("@Senha", SqlDbType.VarChar)
                {
                    Value = _professor.Senha
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _professor.NomeUsuario
                });

                cn.Open();

                _professor.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _professor;
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
