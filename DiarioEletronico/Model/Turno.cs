using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Turno
    {
        private int id;
        private string nome_Turno;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome_Turno
        {
            get { return nome_Turno; }
            set { nome_Turno = value; }
        }

    }
}
