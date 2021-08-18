using System.Net.Http;
using System.Threading.Tasks;

namespace Code_Challenge.Clients
{
    public interface IGeoClient
    {
        Task<string> GetCountry(double lattitude, double longitude);
    }

    public class GeoClient : IGeoClient
    {
        private readonly HttpClient _httpClient;

        private readonly string _geoServiceUrl;

        public GeoClient(HttpClient httpClient, string geoServiceUrl)
        {
            _httpClient = httpClient;
            _geoServiceUrl = geoServiceUrl;
        }

        public async Task<string> GetCountry(double lattitude, double longitude)
        {
            return await _httpClient.GetStringAsync($"{_geoServiceUrl}/?lat={lattitude}&lng={longitude}");
        }
    }
}
