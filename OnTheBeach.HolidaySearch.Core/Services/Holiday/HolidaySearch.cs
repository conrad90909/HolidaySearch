using OnTheBeach.HolidaySearch.Core.Interface;
using OnTheBeach.HolidaySearch.Core.Models;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class HolidaySearch
    {
        private readonly ILogger _logger;
        private readonly FlightSearch _flightSearch;
        private readonly HotelSearch _hotelSearch;


        public HolidaySearch(ILogger logger, FlightSearch flights, HotelSearch hotels)
        {
            _logger = logger;
            _flightSearch = flights;
            _hotelSearch = hotels;
        }

        public HolidayResult Search(HolidayCriteria holidayCriteria)
        {
            try { 
                return new HolidayResult
                {
                    Flight = _flightSearch.Search(holidayCriteria).FirstOrDefault(),
                    Hotel = _hotelSearch.Search(holidayCriteria).FirstOrDefault()
                };
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}
