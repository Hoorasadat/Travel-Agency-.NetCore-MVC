

// Developer: Jashish


using TravelAgency.BLL.Interfaces;
using TravelAgency.Data.Data;
using TravelAgency.Lib.Created_Models;

namespace TravelAgency.BLL.Repositories
{
    public class SQLAgentDetsRepository : IAgentDetsRepository
    {
        private readonly TravelExpertsContext _context;

        public SQLAgentDetsRepository(TravelExpertsContext context)
        {
            _context = context;
        }

        public IList<AgentDetails> getAllAgentDetails()
        {
            var allAgentsInfo = (from agent in _context.Agents
                                 join agency in _context.Agencies on agent.AgencyId equals agency.AgencyId
                                 select new
                                 {
                                     agent.AgentId,
                                     agent.AgtFirstName, agent.AgtLastName, agent.AgtMiddleInitial,
                                     agent.AgtEmail,
                                     agent.AgtBusPhone,
                                     agent.AgtPosition,

                                     agency.AgencyId,
                                     agency.AgncyCity,
                                     agency.AgncyAddress,
                                     agency.AgncyProv,
                                     agency.AgncyCountry,
                                     agency.AgncyPostal,
                                     agency.AgncyPhone,
                                 }).ToList();
            IList<AgentDetails> agentDetails = new List<AgentDetails>();
            foreach (var agent in allAgentsInfo)
            {
                agentDetails.Add(new AgentDetails()
                {
                    AgentId =agent.AgentId,
                    AgtFirstName =agent.AgtFirstName,
                    AgtLastName =agent.AgtLastName, 
                    AgtMiddleInitial = agent.AgtMiddleInitial,
                    AgtEmail = agent.AgtEmail,
                    AgtBusPhone = agent.AgtBusPhone,
                    AgtPosition = agent.AgtPosition,

                    AgencyId = agent.AgencyId,
                    AgncyCity = agent.AgncyCity,
                    AgncyAddress = agent.AgncyAddress,
                    AgncyProv = agent.AgncyProv,
                    AgncyCountry = agent.AgncyCountry,
                    AgncyPostal = agent.AgncyPostal,
                    AgncyPhone = agent.AgncyPhone,

                });
            }

            return agentDetails;
        }
    }
}
