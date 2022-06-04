using Newtonsoft.Json;
using OnTheBeach.HolidaySearch.Core.Interface;

namespace OnTheBeach.HolidaySearch.Data.Services
{
    public class Deserializer: IDeserializer
    {
        private readonly ILogger _logger;
        public Deserializer(ILogger logger)
        {
            _logger = logger;
        }
        public IList<T> Deserialize<T>(string json)
        {
            try
            {
                var result = JsonConvert.DeserializeObject<IList<T>>(json);
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