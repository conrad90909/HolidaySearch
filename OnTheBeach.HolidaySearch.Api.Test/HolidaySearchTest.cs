using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;
using OnTheBeach.HolidaySearch.Api.Models;
using Xunit;
using System;
using System.Linq;

namespace OnTheBeach.HolidaySearch.Api.Test
{
    public class HolidaySearchTests
    {
        [Fact]
        public void Customer1_TestHolidaySearchWorks()
        {
            var holidayCriteria = new HolidayCriteria
            {
                DepartingFrom = "MAN",
                TravellingTo = "AGP",
                DepartureDate = DateTime.Parse("2023-07-01"),
                Duration = 7
            };

            var flightData = new Data<Flight>();
            var hotelData = new Data<Hotel>();

            var holidaySearch = new HolidaySearch(holidayCriteria, flightData, hotelData);

            var result = holidaySearch.Search();

            Assert.Equal(2, result.Flight.Id);
            Assert.Equal(9, result.Hotel.Id);
        }

        [Fact]
        public void Customer2_TestHolidaySearchWorks()
        { 
            var holidayCriteria = new HolidayCriteria
            {
                DepartingFrom = "ANY LON",
                TravellingTo = "PMI",
                DepartureDate = DateTime.Parse("2023-06-15"),
                Duration = 10
            };

            var flightData = new Data<Flight>();
            var hotelData = new Data<Hotel>();

            var holidaySearch = new HolidaySearch(holidayCriteria, flightData, hotelData);

            var result = holidaySearch.Search();

            Assert.Equal(6, result.Flight.Id);
            Assert.Equal(5, result.Hotel.Id);
        }

        [Fact]
        public void Customer3_TestHolidaySearchWorks()
        {
            var holidayCriteria = new HolidayCriteria
            {
                DepartingFrom = "ANY",
                TravellingTo = "LPA",
                DepartureDate = DateTime.Parse("2022-11-10"),
                Duration = 14
            };

            var flightData = new Data<Flight>();
            var hotelData = new Data<Hotel>();

            var holidaySearch = new HolidaySearch(holidayCriteria, flightData, hotelData);

            var result = holidaySearch.Search();

            Assert.Equal(7, result.Flight.Id);
            Assert.Equal(6, result.Hotel.Id);
        }
    }
}