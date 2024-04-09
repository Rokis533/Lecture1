using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace WheatherApi
{
    public class ExternalApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ExternalApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetMeal(string meal)
        {
            HttpClient client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://www.themealdb.com/api/json/v1/1/search.php?s={meal}")
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            var myDeserializedClass = JsonConvert.DeserializeObject(body);


            return JsonConvert.SerializeObject(myDeserializedClass, Formatting.Indented);
        }

    }
}
