using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class AgenteBLL
    {
        public AgenteP Inserir(AgenteP agente)
        {
            AgenteDAL agenteDAL = new AgenteDAL();
            return agenteDAL.Inserir(agente);
        }

        public DataTable Buscar(string _filtro)
        {
            AgenteDAL agenteDAL = new AgenteDAL();
            return agenteDAL.Buscar(_filtro);
        }
    }
}
