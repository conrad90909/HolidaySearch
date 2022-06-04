using OnTheBeach.HolidaySearch.Core.Models;

namespace OnTheBeach.HolidaySearch.Core.Interface
{
    public interface IHotelSource
    {
        IList<Hotel> GetHotelSource(HolidayCriteria? holidayCriteria);
    }
}
