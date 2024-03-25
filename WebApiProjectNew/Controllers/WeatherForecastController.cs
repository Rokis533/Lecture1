using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiProjectNew.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private static readonly List<WeatherForecast> _forecasts = [];

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        // GET localhost/WeatherForecast

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        [ActionName("GetListNew")]
        [Route("/GetMyWeather/[action]")]
        public List<WeatherForecast> GetList()
        {
            return _forecasts;
        }
        [HttpPost]
        public void Create(WeatherForecast weatherForecast)
        {
            _forecasts.Add(weatherForecast);
        }
        [HttpGet]
        public ActionResult<List<WeatherForecast>> GetBydate(DateOnly? dateOnly)
        {
            if(dateOnly == null)
            {
                throw new ArgumentNullException(nameof(dateOnly));
            }
            
            return Ok(_forecasts.Where(x => x.Date == dateOnly).ToList());
        }
    }
}
