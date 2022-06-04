using OnTheBeach.HolidaySearch.Core.Interface;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class AirportFilter : IAirportFilter
    {

        private readonly ILogger _logger;
        private readonly ILondonAirports _londonAirports;

        public AirportFilter(ILogger logger, ILondonAirports londonAirports)
        {
            _logger = logger;
            _londonAirports = londonAirports;
        }

        public bool CheckAirport(string from, string? DepartingFrom)
        {
            try
            {
                if (DepartingFrom == null || DepartingFrom == "ANY")
                {
                    return true;
                }
                else if (DepartingFrom == "ANY LON")
                {
                    var londonAirports = _londonAirports.GetLondonAirports();
                    return londonAirports.Contains(from);
                }
                else
                {
                    return false;
                }
            }catch (Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}
