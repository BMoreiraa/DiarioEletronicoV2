using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Frequencia
    {
        private int id;
        private int id_Aluno;
        private int id_Diario;
        private bool faltas;
        private DateTime data_;

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

        public int Id_Diario
        {
            get { return id_Diario; }
            set { id_Diario = value; }
        }

        public bool Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }

        public DateTime Data_
        {
            get { return data_; }
            set { data_ = value; }
        }

    }
}
