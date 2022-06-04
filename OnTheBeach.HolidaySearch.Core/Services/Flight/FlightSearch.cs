using OnTheBeach.HolidaySearch.Core.Interface;
using OnTheBeach.HolidaySearch.Core.Models;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class FlightSearch
    {
        private readonly ILogger _logger;
        private readonly List<string> _londonAirports;
        private readonly IFlightSource _flightSource;

        public FlightSearch(ILogger logger, IFlightSource flightSource, List<string> londonAirports)
        {
            _logger = logger;
            _londonAirports = londonAirports;
            _flightSource = flightSource;
        }

        public IList<Flight> Search(HolidayCriteria criteria)
        {
            try { 
                var flights = _flightSource.GetFlightSource(criteria);
                return flights;
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}
