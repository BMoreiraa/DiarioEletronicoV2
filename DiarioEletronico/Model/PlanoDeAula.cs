using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlanoDeAula
    {
        private int id;
        private int id_professor;
        private int id_Diario;
        private string conteudo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_professor
        {
            get { return id_professor; }
            set { id_professor = value; }
        }

        public int Id_Diario
        {
            get { return id_Diario; }
            set { id_Diario = value; }
        }

        public string Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }

    }
}
