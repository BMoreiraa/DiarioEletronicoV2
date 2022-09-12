namespace Model
{
    public class Aluno
    {
        private int id;
        private int id_sexo;
        private int id_cidade;
        private int id_turma;
        private string nomeAluno;
        private string dataDeNascimento;
        private string telefoneResponsavel;
        private string cpf;
        private string email;
        private string nomeDoResponsavel;
        private string enderecoAluno;
        private string complemento;
        private string setor;
        private int numero;
        private string cep;
        private string nomeUsuario;
        private string senha;

        public int Matricula //Id do Aluno
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

        public int Id_Turma
        {
            get { return id_turma; }
            set { id_turma = value; }
        }

        public string NomeAluno
        {
            get { return nomeAluno; }
            set { nomeAluno = value; }
        }

        public string DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        public string TelefoneResponsavel
        {
            get { return telefoneResponsavel; }
            set { telefoneResponsavel = value; }
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

        public string NomeDoResponsavel
        {
            get { return nomeDoResponsavel; }
            set { nomeDoResponsavel = value; }
        }

        public string EnderecoAluno
        {
            get { return enderecoAluno; }
            set { enderecoAluno = value; }
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
