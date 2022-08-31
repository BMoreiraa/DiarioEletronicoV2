namespace Model
{
    public class Diario
    {
        private int id;
        private int id_Discplina;
        private int id_Professor;
        private int id_Turma;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Discplina
        {
            get { return id_Discplina; }
            set { id_Discplina = value; }
        }

        public int Id_Professor
        {
            get { return id_Professor; }
            set { id_Professor = value; }
        }

        public int Id_Turma
        {
            get { return id_Turma; }
            set { id_Turma = value; }
        }

    }
}
