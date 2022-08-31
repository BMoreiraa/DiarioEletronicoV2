namespace Model
{
    public class AgenteP
    {
        private int id;
        private string nomeAgente;
        private string senha;
        private string nomeUsuario;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeAgente
        {
            get { return nomeAgente; }
            set { nomeAgente = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

    }
}
