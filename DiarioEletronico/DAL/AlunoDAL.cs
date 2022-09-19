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
    public class AlunoDAL
    {
    public Aluno Inserir(Aluno _aluno)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirAluno";

                cmd.Parameters.Add(new SqlParameter("@Matricula", SqlDbType.Int)
                {
                    Value = _aluno.Matricula
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Sexo", SqlDbType.Int)
                {
                    Value = _aluno.Id_Sexo
                });

                cmd.Parameters.Add(new SqlParameter("@Id_cidade", SqlDbType.Int)
                {
                    Value = _aluno.Id_cidade
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", SqlDbType.Int)
                {
                    Value = _aluno.Id_Turma
                });

                cmd.Parameters.Add(new SqlParameter("@NomeAluno", SqlDbType.VarChar)
                {
                    Value = _aluno.NomeAluno
                });

                cmd.Parameters.Add(new SqlParameter("@DataDeNascimento", SqlDbType.VarChar)
                {
                    Value = _aluno.DataDeNascimento
                });

                cmd.Parameters.Add(new SqlParameter("@TelefoneResponsavel", SqlDbType.VarChar)
                {
                    Value = _aluno.TelefoneResponsavel
                });

                cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar)
                {
                    Value = _aluno.CPF
                });

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _aluno.Email
                });

                cmd.Parameters.Add(new SqlParameter("@NomeDoResponsavel", SqlDbType.VarChar)
                {
                    Value = _aluno.NomeDoResponsavel
                });

                cmd.Parameters.Add(new SqlParameter("@EnderecoAluno", SqlDbType.VarChar)
                {
                    Value = _aluno.EnderecoAluno
                });

                cmd.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.VarChar)
                {
                    Value = _aluno.Complemento
                });

                cmd.Parameters.Add(new SqlParameter("@Setor", SqlDbType.VarChar)
                {
                    Value = _aluno.Setor
                });

                cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)
                {
                    Value = _aluno.Numero
                });

                cmd.Parameters.Add(new SqlParameter("@CEP", SqlDbType.VarChar)
                {
                    Value = _aluno.CEP
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _aluno.NomeUsuario
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _aluno.Senha
                });

                cn.Open();

                _aluno.Matricula = Convert.ToInt32(cmd.ExecuteScalar());

                return _aluno;
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

 /*###################################################################################################################################*/

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
            da.SelectCommand.CommandText = "SP_BuscarAluno";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
            pfiltro.Value = _filtro;
            da.SelectCommand.Parameters.Add(pfiltro);

            cn.Open();
            da.Fill(dt);
            return dt;
        }
        catch (SqlException ex)
        {
            throw new Exception("Servidor Sql Erro: " + ex.Message);
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

 /*###################################################################################################################################*/
    public DataTable BuscarPorTurma(string _filtro)
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
            da.SelectCommand.CommandText = "SELECT ALUNO.Id,NomeAluno FROM Aluno INNER JOIN Turma AS T ON Aluno.Id_Turma = T.Id WHERE Serie = @Serie";
            da.SelectCommand.CommandType = CommandType.Text;

            SqlParameter pfiltro = new SqlParameter("@Serie", SqlDbType.VarChar);
            pfiltro.Value = _filtro;
            da.SelectCommand.Parameters.Add(pfiltro);

            cn.Open();
            da.Fill(dt);
            return dt;
        }
        catch (SqlException ex)
        {
            throw new Exception("Servidor Sql Erro: " + ex.Message);
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

 /*###################################################################################################################################*/
    }
}

