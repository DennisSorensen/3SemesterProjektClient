﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class CalendarService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        CalendarServiceReference.ICalendarService calendarService = new CalendarServiceReference.CalendarServiceClient();
        UserServiceReference.IUserService userService = new UserServiceReference.UserServiceClient();

        //Tager mod en user fra gui, og sender den op til wcf'en
        public void CreateCalendar(CalendarServiceReference.Calendar calendar)
        {
            calendarService.Create(calendar);
        }
    }
}