namespace OnTheBeach.HolidaySearch.Core.Models
{
    public class HolidayCriteria
    {
        public string? DepartingFrom { get; set; }
        public string? TravellingTo { get; set; }
        public DateTime DepartureDate { get; set; } 
        public int Duration { get; set; }
    }
}
