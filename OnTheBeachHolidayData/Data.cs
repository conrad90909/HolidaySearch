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
            var fileName = (string)typeof(T).GetField("FileName").GetValue("");

            var file = File.ReadAllText(@"Data/" + fileName);
            return JsonConvert.DeserializeObject<List<T>>(file);
        }
    }
}