using OnTheBeach.HolidaySearch.Core.Interface;

namespace OnTheBeach.HolidaySearch.Data.Services
{
    public class FileReader
    {
        private readonly ILogger _logger;

        public FileReader(ILogger logger)
        {
            _logger = logger;
        }

        public string ReadFile(string fileName)
        {
            try
            {
                return File.ReadAllText(@"Data/" + fileName);
            }catch(Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}