using Newtonsoft.Json;

namespace WheatherApi
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Day
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

    }
    public class WeatherDto
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("days")]
        public List<Day> Days { get; set; }

    }


}
