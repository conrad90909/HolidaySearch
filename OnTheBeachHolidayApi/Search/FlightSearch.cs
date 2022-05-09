using OnTheBeach.HolidaySearch.Api.Models;
using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;

namespace OnTheBeach.HolidaySearch.Api
{
    public class FlightSearch
    {

        private List<string> _londonAirports = new List<string> { "LCY", "LHR", "LGW", "LTN", "STN", "SEN" };

        private readonly Data<Flight> _flights;

        public FlightSearch(Data<Flight> flights)
        {
            _flights = flights;
        }


        public List<Flight> Search(HolidayCriteria criteria)
        {
            var flights = _flights.GetData().Where(
                    x => x.To == criteria.TravellingTo
                    && CheckAirport(x, criteria.DepartingFrom)
                    && x.DepartureDate == criteria.DepartureDate
                    ).OrderBy(o => o.Price).ToList();
            return flights;
        }

        private bool CheckAirport(Flight flight, string DepartingFrom)
        {
            if (DepartingFrom == "ANY")
            {
                return true;
            }
            else if (DepartingFrom == "ANY LON")
            {
                return _londonAirports.Contains(flight.From);
            }
            return flight.From == DepartingFrom;
        }
    }
}
