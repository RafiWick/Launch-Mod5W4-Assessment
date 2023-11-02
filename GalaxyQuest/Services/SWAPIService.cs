using GalaxyQuest.Interfaces;
using GalaxyQuest.Models;
using System.Text.Json;

namespace GalaxyQuest.Services
{
    public class SWAPIService : ISWAPIService
    {
        private readonly HttpClient _client;
        public SWAPIService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("SWAPI");
        }

        public async Task<List<SWPlanet>> GetPlanets()
        {
            var result = new List<SWPlanet>();
            for (int i=0; i < 6; i++)
            {
                var url = string.Format($"/api/planets/?page={i + 1}");
                
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    result.AddRange(JsonSerializer.Deserialize<SWPlanetPage>(stringResponse,
                        new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }).Results);
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
            
            return result;
        }

        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }
    }
}
