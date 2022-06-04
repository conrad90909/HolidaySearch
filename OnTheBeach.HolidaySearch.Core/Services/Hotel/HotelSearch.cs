using OnTheBeach.HolidaySearch.Core.Interface;
using OnTheBeach.HolidaySearch.Core.Models;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class HotelSearch
    {
        private ILogger _logger;
        private readonly IHotelSource _hotelSource;

        public HotelSearch(ILogger logger, IHotelSource hotelSource)
        {
            _logger = logger;
            _hotelSource = hotelSource;
        }

        public IList<Hotel> Search(HolidayCriteria criteria)
        {
            try
            {
                var hotels = _hotelSource.GetHotelSource(criteria);
                return hotels;
            }catch (Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}
