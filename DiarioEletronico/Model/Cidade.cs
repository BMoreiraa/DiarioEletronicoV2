namespace Model
{
    public class Cidade
    {
        private int id;
        private int id_UF;
        private string nomeCidade;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_UF
        {
            get { return id_UF; }
            set { id_UF = value; }
        }

        public string NomeCidade
        {
            get { return nomeCidade; }
            set { nomeCidade = value; }
        }

    }
}
