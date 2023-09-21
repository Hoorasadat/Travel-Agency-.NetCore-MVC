

// Developer: Jashish


using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TravelAgency.BLL.Interfaces;
using TravelAgency.Lib.Created_Models;
using TravelAgency.Web.ViewModel.Agents;

namespace TravelAgency.Web.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IAgentDetsRepository _agentRepo;

        public ContactUsController(IAgentDetsRepository agentRepo)
        {
            _agentRepo = agentRepo;
        }



        // GET: AgentsController
        public async Task<ActionResult> Index()
        {
            try
            {
                IList<AgentDetails> agentsInfo= _agentRepo.getAllAgentDetails();
                IList<AgentIndexVM> agentsListVM = new List<AgentIndexVM>();

                foreach (var item in agentsInfo)
                {
                    AgentIndexVM agentsVM = new AgentIndexVM()
                    {
                        agentInfo = item
                    };

                    agentsListVM.Add(agentsVM);

                }
                return View(agentsListVM);
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }



        // GET: BookingsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookingsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookingsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
