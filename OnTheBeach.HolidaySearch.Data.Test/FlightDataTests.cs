using System;
using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;
using Xunit;
using System.Linq;

namespace OnTheBeach.HolidaySearch.Data.Test
{
    public class FlightDataTests
    {
        [Fact]
        public void GetFlightData_ReturnsValidObject()
        {

            var firstObject = new Flight
            {
                Id = 1,
                Airline = "First Class Air",
                From = "MAN",
                To = "TFS",
                Price = 470,
                DepartureDate = DateTime.Parse("2023-07-01")
            };

            var flightData = new Data<Flight>();
            var data = flightData.GetData();

            Assert.Equal(firstObject.Id, data.FirstOrDefault().Id);
            Assert.Equal(firstObject.Airline, data.FirstOrDefault().Airline);
            Assert.Equal(12, data.Count());
        }
    }
}