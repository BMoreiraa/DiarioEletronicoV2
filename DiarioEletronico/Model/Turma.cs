using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Turma
    {
        private int id;
        private int id_TURNO;
        private string serie;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_TURNO
        {
            get { return id_TURNO; }
            set { id_TURNO = value; }
        }

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

    }
}
