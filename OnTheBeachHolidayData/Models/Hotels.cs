using Newtonsoft.Json;

namespace OnTheBeach.HolidaySearch.Data.Models
{
    public class Hotel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("arrival_date")]
        public DateTime ArrivalDate { get; set; }

        [JsonProperty("price_per_night")]
        public int PricePerNight { get; set; }

        [JsonProperty("local_airports")]
        public List<string>? LocalAirports { get; set; }

        [JsonProperty("nights")]
        public int Nights { get; set; }

        // "id": 1,
        //"name": "Iberostar Grand Portals Nous",
        //"arrival_date": "2022-11-05",
        //"price_per_night": 100,
        //"local_airports": [ "TFS" ],
        //"nights": 7
    }
}
