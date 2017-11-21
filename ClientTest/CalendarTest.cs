using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;

namespace ClientTest
{
    [TestClass]
    public class CalendarTest
    {

        [TestMethod]
        public void TestCalendarIsCreated()
        {
            /*
            //Arrange
            CalendarService calendarService = new CalendarService();
            Client.CalendarServiceReference.Calendar calendar = new Client.CalendarServiceReference.Calendar();// oprettet et nyt calender object
            Client.CalendarServiceReference.Calendar testCalendar = new Client.CalendarServiceReference.Calendar();// oprettet et nyt calender object
            calendar.Id = 999998;
            testCalendar.Id = 999999;
            //Act
            calendarService.CreateCalendar(calendar);

            //Assert

            Assert.Equals(calendar, testCalendar);
            */
        }


        [TestMethod]
        public void TestCalendarFound()
        {
            /*
            //Arrange
            CalendarService calendarService = new CalendarService();
            Client.CalendarServiceReference.Calendar calendar = new Client.CalendarServiceReference.Calendar();// oprettet et nyt calender object

            //Act
            calendar = calendarService.Get(999999);
            
            //Assert
            Assert.Equals(calendar.Id, 999999);
            */
        }
    }
}
