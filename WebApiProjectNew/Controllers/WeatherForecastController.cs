using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiProjectNew.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        // GET localhost/WeatherForecast/GetWeatherForecastList

        [HttpGet("GetWeatherForecastList")]
        public List<WeatherForecast> GetList()
        {
            return _forecasts;
        }
        [HttpPost]
        public void Create([FromBody] WeatherForecast weatherForecast)
        {
            _forecasts.Add(weatherForecast);
        }

        // GET localhost/WeatherForecast/{dateOnly}
        // GET localhost/WeatherForecast/2024-03-26
        // GET localhost/Student/264

        [HttpGet("{id}")]
        public ActionResult<List<WeatherForecast>> GetById([FromRoute] int id)
        {
            return Ok();
        }
        [HttpGet("GetBy")]
        public ActionResult<List<WeatherForecast>> GetBydate2([FromQuery] DateOnly? dateOnly, [FromQuery] string message, [FromQuery] int number)
        {
            if (dateOnly == null)
            {
                throw new ArgumentNullException(nameof(dateOnly));
            }

            return Ok(_forecasts.Where(x => x.Date == dateOnly).ToList());
        }
        //[HttpPost("SendFile")]
        //public ActionResult<IFormFile> Send(List<IFormFile> file)
        //{
        //    return Ok(file);
        //}
    }
}
