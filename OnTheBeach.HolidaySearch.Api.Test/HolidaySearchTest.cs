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
            /*
             * Departing from: Manchester Airport (MAN)
                Traveling to: Malaga Airport (AGP)
                Departure Date: 2023/07/01
                Duration: 7 nights

                Flight 2
                Hotel 9
             */

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
            /*
             * Departing from: Manchester Airport (MAN)
                Traveling to: Malaga Airport (AGP)
                Departure Date: 2023/07/01
                Duration: 7 nights

                Flight 6
                Hotel 5
             */

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
    }
}