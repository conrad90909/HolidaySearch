using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;
using OnTheBeach.HolidaySearch.Api.Models;
using Xunit;
using System;
using System.Linq;

namespace OnTheBeach.HolidaySearch.Api.Test
{
    public class HotelSearchTests
    {
        [Fact]
        public void Customer1_TestHotelSearchWorks()
        {
            var hotelData = new Data<Hotel>();

            var hotelSearch = new HotelSearch(hotelData);

            var hotelCriteria = new HolidayCriteria
            {
                DepartingFrom = "MAN",
                TravellingTo = "AGP",
                DepartureDate = DateTime.Parse("2023-07-01"),
                Duration = 7
            };

            var result = hotelSearch.Search(hotelCriteria);

            Assert.Equal(9, result.FirstOrDefault().Id);
        }
    }
}