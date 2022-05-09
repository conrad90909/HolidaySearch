using OnTheBeach.HolidaySearch.Api.Models;
using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;

namespace OnTheBeach.HolidaySearch.Api
{
    public class FlightSearch
    {
        private readonly Data<Flight> _flights;

        public FlightSearch(Data<Flight> flights)
        {
            _flights = flights;
        }


        public List<Flight> Search(HolidayCriteria criteria)
        {
            var flights = _flights.GetData().Where(
                    x => x.To == criteria.TravellingTo
                    && x.From == criteria.DepartingFrom
                    && x.DepartureDate == criteria.DepartureDate
                    ).OrderBy(o => o.Price).ToList();
            return flights;
        }
    }
}
