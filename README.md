# HolidaySearch
Technical Test For On The Beach

# On the Beach - Holiday Search programming exercise

## Description

This exercise is designed to measure your understanding of some common programming principles. We've designed it to be language agnostic so please complete it in the programming language you feel most comfortable using.

## Hints and Tips

 * We aim to take up no more than four hours of your personal time.
 * We believe that Test Driven Development will produce higher quality code.
 * It would be great if you can show your process in the form of granular commit messages.
 * We're not looking for a UI or command line output, just the code and some tests to show it works.

## Holiday Search

Taking the two JSON files of flights and hotels as source data, please create a small library of code that provides a basic holiday search feature. 

The first search result should be the best value holiday we can provide, based on the customers requirements.

Use the test cases listed below to verify the success of your work, add more tests as you see fit.

Here is an example of how the finished library could work, you're welcome to put your own spin on it.


    var holidaySearch = new HolidaySearch({
      DepartingFrom: 'MAN',
      TravelingTo: 'AGP',
      DepartureDate: '2023/07/01'
      Duration: 7
      });

    holidaySearch.Results.First() # Returns the Best of the matching results
    holidaySearch.Results.First().TotalPrice # '£900.00'
    holidaySearch.Results.First().Flight.Id # 4
    holidaySearch.Results.First().Flight.DepartingFrom # 'MAN'
    holidaySearch.Results.First().Flight.TravalingTo # 'AGP'
    holidaySearch.Results.First().Flight.Price
    holidaySearch.Results.First().Hotel.Id # 3    
    holidaySearch.Results.First().Hotel.Name
    holidaySearch.Results.First().Hotel.Price


## Test cases

Here are some example test cases

#### Customer #1

##### Input
 * Departing from: Manchester Airport (MAN)
 * Traveling to: Malaga Airport (AGP)
 * Departure Date: 2023/07/01
 * Duration: 7 nights

##### Expected result  
 * Flight 2 and Hotel 9

### Customer #2

##### Input
 * Departing from: Any London Airport
 * Traveling to: Mallorca Airport (PMI)
 * Departure Date: 2023/06/15
 * Duration: 10 nights

##### Expected result  
 * Flight 6 and Hotel 5

### Customer #3

##### Input
 * Departing from: Any Airport
 * Traveling to: Gran Canaria Airport (LPA)
 * Departure Date: 2022/11/10
 * Duration: 14 nights

##### Expected result  
 * Flight 7 and Hotel 6
