using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Nota
    {
        private int id;
        private int id_Aluno;
        private int id_Turma;
        private int id_Diario;
        private float nota;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Aluno
        {
            get { return id_Aluno; }
            set { id_Aluno = value; }
        }

        public int Id_Turma
        {
            get { return id_Turma; }
            set { id_Turma = value; }
        }

        public int Id_Diario
        {
            get { return id_Diario; }
            set { id_Diario = value; }
        }

        public float Lancar_Nota
        {
            get { return nota; }
            set { nota = value; }
        }


    }
}
