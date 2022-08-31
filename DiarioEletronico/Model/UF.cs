using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UF
    {
        private int id;
        private string nomeUF;
        private string abreviacaoUF;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeUF
        {
            get { return nomeUF; }
            set { nomeUF = value; }
        }

        public string AbreviacaoUF
        {
            get { return abreviacaoUF; }
            set { abreviacaoUF = value; }
        }

    }
}
