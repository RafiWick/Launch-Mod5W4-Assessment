using GalaxyQuest.Interfaces;
using GalaxyQuest.Models;
using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly ISWAPIService _SWAPIService;

        public PlanetsController(ISWAPIService SWAPIService)
        {
            _SWAPIService = SWAPIService;
        }
        public async Task<IActionResult> Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            var FullSWPlanets = await _SWAPIService.GetPlanets();
            var SWPlanets = FullSWPlanets.Select(p => new Planet { Name = p.Name, Population = p.Population});
            var allPlanets = new List<Planet>();
            allPlanets.AddRange(milkyWayPlanets);
            allPlanets.AddRange(SWPlanets);
            return View(allPlanets);
        }
    }
}
