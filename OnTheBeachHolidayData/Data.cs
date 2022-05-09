using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OnTheBeach.HolidaySearch.Data.Models;
using System.Collections.Generic;

namespace OnTheBeachHolidayData
{
    public class Data<T>
    {

        public IList<T> GetData()
        {
            string fileName = "FlightData.json";

            if (typeof(T) == typeof(Hotel)) 
            {
                fileName = "HotelData.json";
            }

            var file = File.ReadAllText(@"Data/" + fileName);
            return JsonConvert.DeserializeObject<List<T>>(file);

        }
        
    }
}