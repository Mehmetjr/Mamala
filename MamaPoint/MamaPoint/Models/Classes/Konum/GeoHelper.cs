using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MamaPoint.Models.Classes
{
    public class GeoHelper
    {
        private readonly HttpClient _httpClient;
        public GeoHelper()
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5)
            };
        }

        private async Task<string> GetIPAddress()
        {
            var ipAdress = await _httpClient.GetAsync($"http://ipinfo.io/ip");
            if (ipAdress.IsSuccessStatusCode)
            {
                var json = await ipAdress.Content.ReadAsStringAsync();
                return json.ToString();
            }
            return "";
        }

        public async Task<string> GetGeoInfo()
        {
            var ipAdress = await GetIPAddress();

            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAdress + "?access_key = 31da0d786ac6e3dea4ff64c12f362057");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }
    }
}