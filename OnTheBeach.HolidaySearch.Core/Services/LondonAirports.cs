using OnTheBeach.HolidaySearch.Core.Interface;

namespace OnTheBeach.HolidaySearch.Core.Services
{
    public class LondonAirports : ILondonAirports
    {
        private readonly ILogger _logger;
        private readonly IFileReader _fileReader;
        private readonly string _fileName;
        private readonly string _separator = ",";


        public LondonAirports(ILogger logger, IFileReader fileReader, string fileName, string separator)
        {
            _logger = logger;
            _fileReader = fileReader;
            _fileName = fileName;
            _separator = separator; 
        }

        public IList<string> GetLondonAirports()
        {
            try { 
                string airports = _fileReader.ReadFile(_fileName);
                return airports.Split(_separator).ToList();
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
        }
    }
}
