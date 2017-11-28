using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.BookingServiceReference;
using System.Data;

namespace Client
{
    public class BookingService
    {
        BookingServiceReference.IBookingService bookingService = new BookingServiceReference.BookingServiceClient();
        DataTable table;


        public void CreateTask(BookingServiceReference.SupportTask supportTask)
        {
            bookingService.CreateSupportTask(supportTask);
        }

        public IEnumerable<BookingServiceReference.SupportTask> GetAllSupportTask(int calendarId)
        {
            return bookingService.GetAllSupportTask(calendarId);
        }

        public IEnumerable<BookingServiceReference.SupportBooking> GetAllSupportBooking(int calendarId)
        {
            return bookingService.GetAllSupportBooking(calendarId);
        }

        public IEnumerable<BookingServiceReference.ReadyToGo> GetAllReadyToGo(int calendarId)
        {
            return bookingService.GetAllReadyToGo(calendarId);
        }
    }
}
