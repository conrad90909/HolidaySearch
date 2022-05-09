using OnTheBeach.HolidaySearch.Api.Models;
using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;

namespace OnTheBeach.HolidaySearch.Api
{
    public class HolidaySearch
    {

        private readonly HolidayCriteria _holidayCriteria;

        private readonly FlightSearch _flightSearch;
        private readonly HotelSearch _hotelSearch;


        public HolidaySearch(HolidayCriteria holidayCriteria, 
                                Data<Flight> flights,
                                Data<Hotel> hotels)
        {
            _holidayCriteria = holidayCriteria;
            _flightSearch = new FlightSearch(flights);
            _hotelSearch = new HotelSearch(hotels);
        }

        public HolidayResult Search()
        {
            return new HolidayResult
            {
                //
                // This should really combine the lists to return multiple results based on destination, I will come back and do that.
                //
                Flight = _flightSearch.Search(_holidayCriteria).FirstOrDefault(),
                Hotel = _hotelSearch.Search(_holidayCriteria).FirstOrDefault()
            };
        }

    }
}
