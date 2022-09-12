using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Disciplina
    {
        private int id;
        private string nomeDisciplina;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeDisciplina
        {
            get { return nomeDisciplina; }
            set { nomeDisciplina = value; }
        }

    }
}
