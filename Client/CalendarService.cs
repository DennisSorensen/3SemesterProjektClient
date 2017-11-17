using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class CalendarService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();

        //Tager mod en user fra gui, og sender den op til wcf'en
        public void CreateCalendar(CalendarServiceReference.Calendar calendar)
        {
            service.Create(calendar);
        }
    }
}
