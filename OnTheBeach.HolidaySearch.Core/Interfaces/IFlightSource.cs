using OnTheBeach.HolidaySearch.Core.Models;

namespace OnTheBeach.HolidaySearch.Core.Interface
{
    public interface IFlightSource
    {
        IList<Flight> GetFlightSource(HolidayCriteria? holidayCriteria);
    }
}
