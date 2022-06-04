using OnTheBeach.HolidaySearch.Core.Models;
using OnTheBeach.HolidaySearch.Core.Interface;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class FlightSource: IFlightSource
    {
        private readonly ILogger _logger;
        private readonly IFileReader _fileReader;
        private readonly IDeserializer _deserializer;
        private readonly string _fileName;
        private readonly IAirportFilter _airportFilter;

        public FlightSource(ILogger logger, IFileReader fileReader, IDeserializer deserializer, string fileName, IAirportFilter airportFilter)
        {
            _logger = logger;
            _fileReader = fileReader;
            _deserializer = deserializer;
            _fileName = fileName;
            _airportFilter = airportFilter;
        }

        public IList<Flight> GetFlightSource(HolidayCriteria? holidayCriteria = null)
        {
            try
            {
                var json = _fileReader.ReadFile(_fileName);
                var flights = _deserializer.Deserialize<Flight>(json);

                var result = flights.Where(
                        x => x.To == holidayCriteria.TravellingTo
                        && _airportFilter.CheckAirport(x.From, holidayCriteria.DepartingFrom)
                        && x.DepartureDate == holidayCriteria.DepartureDate
                        ).OrderBy(o => o.Price).ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}