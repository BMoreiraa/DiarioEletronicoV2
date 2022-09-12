using DAL;
using Model;

namespace BLL
{
    public class AgenteBLL
    {
        public AgenteP Inserir(AgenteP agente)
        {
            AgenteDAL agenteDAL = new AgenteDAL();
            return agenteDAL.Inserir(agente);
        }
    }
}
