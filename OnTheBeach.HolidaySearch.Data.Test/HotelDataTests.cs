using System;
using OnTheBeach.HolidaySearch.Data;
using OnTheBeach.HolidaySearch.Data.Models;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace OnTheBeach.HolidaySearch.Data.Test
{
    public class HotelDataTests
    {
        [Fact]
        public void GetHotelData_ReturnsValidObject()
        {

            var firstObject = new Hotel
            {
                Id = 1,
                Name = "Iberostar Grand Portals Nous",
                ArrivalDate = DateTime.Parse("2022-11-05"),
                PricePerNight = 100,
                LocalAirports = new List<string> { "TFS" },
                Nights = 7
            };

            var hotelData = new Data<Hotel>();
            var data = hotelData.GetData();

            Assert.Equal(firstObject.Id, data.FirstOrDefault().Id);
            Assert.Equal(firstObject.Name, data.FirstOrDefault().Name);
            Assert.Equal(13, data.Count());
        }

    }
}