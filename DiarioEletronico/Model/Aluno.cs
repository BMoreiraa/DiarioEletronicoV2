using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aluno
    {
        private int id;
        private int id_Sexo;

        public int Matricula //Id do Aluno
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Sexo
        {
            get { return id_Sexo; }
            set { id_Sexo = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
