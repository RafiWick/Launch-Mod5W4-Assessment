namespace GalaxyQuest.Models
{
    public class SWPlanetPage
    {
        public int Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<SWPlanet> Results { get; set; }



    }
}
