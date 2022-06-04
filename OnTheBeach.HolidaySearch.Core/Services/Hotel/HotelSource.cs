using OnTheBeach.HolidaySearch.Core.Interface;
using OnTheBeach.HolidaySearch.Core.Models;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class HotelSource: IHotelSource
    {
        private readonly ILogger _logger;
        private readonly IFileReader _fileReader;
        private readonly IDeserializer _deserializer;
        private readonly string _fileName;

        public HotelSource(ILogger logger, IFileReader fileReader, IDeserializer deserializer, string fileName)
        {
            _logger = logger;
            _fileReader = fileReader;
            _deserializer = deserializer;
            _fileName = fileName;
        }

        public IList<Hotel> GetHotelSource(HolidayCriteria? holidayCriteria = null)
        {
            try { 
                var json = _fileReader.ReadFile(_fileName);
                var hotels = _deserializer.Deserialize<Hotel>(json);

                var result = hotels.Where(
                      x => x.LocalAirports.Contains(holidayCriteria.TravellingTo)
                      && x.ArrivalDate == holidayCriteria.DepartureDate
                      && x.Nights == holidayCriteria.Duration
                      ).OrderBy(o => o.PricePerNight).ToList();
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