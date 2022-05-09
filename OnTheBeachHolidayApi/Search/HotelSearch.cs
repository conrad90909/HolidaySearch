using OnTheBeach.HolidaySearch.Api.Models;
using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;

namespace OnTheBeach.HolidaySearch.Api
{
    public class HotelSearch
    {
        private readonly Data<Hotel> _hotels;

        public HotelSearch(Data<Hotel> hotels)
        {
            _hotels = hotels;
        }

        public List<Hotel> Search(HolidayCriteria criteria)
        {
            var hotels = _hotels.GetData().Where(
                    x => x.LocalAirports.Contains(criteria.TravellingTo)
                    && x.ArrivalDate == criteria.DepartureDate
                    && x.Nights == criteria.Duration
                    ).OrderBy(o => o.PricePerNight).ToList();
            return hotels;
        }
    }
}
