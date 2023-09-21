using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Lib.Created_Models;
using TravelAgency.Lib.Models;

namespace TravelAgency.BLL.Interfaces
{
    public interface IAgentDetsRepository
    {
        public IList<AgentDetails> getAllAgentDetails();
    }

}
