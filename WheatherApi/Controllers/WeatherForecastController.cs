using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Globalization;

namespace WheatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration _configuration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<WeatherForecast> Get()
        {
            string apiKey = _configuration.GetValue<string>("ApiKey");
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Kaunas/today?unitGroup=metric&key={apiKey}&contentType=json")
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            WeatherDto myDeserializedClass = JsonConvert.DeserializeObject<WeatherDto>(body);

            WeatherForecast weatherForecast = new WeatherForecast
            {
                TemperatureC = (int)myDeserializedClass.Days[0].Temp,
                Date = DateOnly.ParseExact(myDeserializedClass.Days[0].Datetime, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Summary = myDeserializedClass.Description
            };
            return weatherForecast;
        }
        //[HttpGet("GetFromApiRecipes")]
        //public async Task<string> Get2(string meal)
        //{
        //    return await _externalApi.GetMeal(meal);
        //}

        [HttpGet("GetFromApiCars")]
        public async Task<string> Get3()
        {
            var client = new HttpClient();

            var requestBody = new StringContent(JsonConvert.SerializeObject(new WeatherForecast()));

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"https://carapi.app/api/models"),
                Content = requestBody,
            };
            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            var myDeserializedClass = JsonConvert.DeserializeObject(body);


            return JsonConvert.SerializeObject(myDeserializedClass, Formatting.Indented);
        }
    }
}
