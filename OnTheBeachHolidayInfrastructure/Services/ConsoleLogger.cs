using OnTheBeach.HolidaySearch.Core.Interface;

namespace OnTheBeach.HolidaySearch.Data.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
