namespace OnTheBeach.HolidaySearch.Core.Interface
{
    public interface IDeserializer
    {
        IList<T> Deserialize<T>(string json);
    }
}
