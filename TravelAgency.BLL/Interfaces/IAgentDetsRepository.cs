

// Developer: Jashish


using TravelAgency.Lib.Created_Models;

namespace TravelAgency.BLL.Interfaces
{
    public interface IAgentDetsRepository
    {
        public IList<AgentDetails> getAllAgentDetails();
    }
}
