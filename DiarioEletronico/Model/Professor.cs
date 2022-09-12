using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        private int id;
        private int id_sexo;
        private int id_cidade;
        private string nome;
        private string cpf;
        private string email;
        private string telefone;
        private string dataDeNascimento;
        private string endereco;
        private string complemento;
        private string setor;
        private int numero;
        private string cep;
        private string nomeUsuario;
        private string senha;

        public int Id //Id do Professor
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Sexo
        {
            get { return id_sexo; }
            set { id_sexo = value; }
        }

        public int Id_cidade
        {
            get { return id_cidade; }
            set { id_cidade = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco= value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
