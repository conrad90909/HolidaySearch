using Newtonsoft.Json;

namespace OnTheBeach.HolidaySearch.Data.Models
{
    public class Flight
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("airline")]
        public string? Airline { get; set; }

        [JsonProperty("from")]
        public string? From { get; set; }

        [JsonProperty("to")]
        public string? To { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("departure_date")]
        public DateTime DepartureDate { get; set; }

        //"id": 1,
        //"airline": "First Class Air",
        //"from": "MAN",
        //"to": "TFS",
        //"price": 470,
        //"departure_date": "2023-07-01"
    }
}
