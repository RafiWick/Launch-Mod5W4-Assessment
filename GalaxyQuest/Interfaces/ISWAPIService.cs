using GalaxyQuest.Models;

namespace GalaxyQuest.Interfaces
{
    public interface ISWAPIService
    {
        Task<List<SWPlanet>> GetPlanets();
    }
}
