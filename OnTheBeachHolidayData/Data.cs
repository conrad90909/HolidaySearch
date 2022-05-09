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
            var field = typeof(T).GetField("FileName");
            var fileName = field.GetValue("");

            var file = File.ReadAllText(@"Data/" + fileName);
            return JsonConvert.DeserializeObject<List<T>>(file);
        }
        
    }
}