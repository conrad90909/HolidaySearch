using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;
using OnTheBeach.HolidaySearch.Api.Models;
using Xunit;
using System;
using System.Linq;

namespace OnTheBeach.HolidaySearch.Api.Test
{
    public class FlightSearchTests
    {
        [Fact]
        public void Customer1_TestFlightSearchWorks()
        {
            /*
             * Departing from: Manchester Airport (MAN)
                Traveling to: Malaga Airport (AGP)
                Departure Date: 2023/07/01
                Duration: 7 nights

                Flight 2
             */

            var flightData = new Data<Flight>();

            var flighSearch = new FlightSearch(flightData);

            var flightCriteria = new HolidayCriteria
            {
                DepartingFrom = "MAN",
                TravellingTo = "AGP",
                DepartureDate = DateTime.Parse("2023-07-01"),
                Duration = 7
            };

            var result = flighSearch.Search(flightCriteria);

            Assert.Equal(2, result.FirstOrDefault().Id);
        }

        [Fact]
        public void Customer2_TestFlightSearchWorks()
        {
            /*
             * Departing from: Manchester Airport (MAN)
                Traveling to: Malaga Airport (AGP)
                Departure Date: 2023/07/01
                Duration: 7 nights

                Flight 2
             */

            var flightData = new Data<Flight>();

            var flighSearch = new FlightSearch(flightData);

            var flightCriteria = new HolidayCriteria
            {
                DepartingFrom = "ANY LON",
                TravellingTo = "PMI",
                DepartureDate = DateTime.Parse("2023-06-15"),
                Duration = 10
            };

            var result = flighSearch.Search(flightCriteria);

            Assert.Equal(6, result.FirstOrDefault().Id);
        }
    }
}