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

        public int FindAvaibleCalendar(DateTime startDate, DateTime endDate)
        {
            return bookingService.FindAvaliableCalendar(startDate, endDate);
        }

        public void CreateTask(BookingServiceReference.SupportTask supportTask)
        {
            bookingService.CreateSupportTask(supportTask);
        }

        public void CreateReadyToGo(BookingServiceReference.ReadyToGo readyToGo)
        {
            bookingService.CreateReadyToGo(readyToGo);
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

        public IEnumerable<BookingServiceReference.Booking> GetAllBookingSpecificDay(int calendarId, DateTime date)
        {
            return bookingService.GetAllBookingSpecificDay(calendarId, date);
        }

        public BookingServiceReference.Booking GetBooking(int bookingId)
        {
            return bookingService.GetBooking(bookingId);
        }

        public BookingServiceReference.ReadyToGo GetReadyToGo(int bookingId)
        {
            return bookingService.GetReadyToGo(bookingId);
        }

        public BookingServiceReference.SupportTask GetSupportTask(int bookingId)
        {
            return bookingService.GetSupportTask(bookingId);
        }

        public BookingServiceReference.SupportBooking GetSupportBooking(int bookingId)
        {
            return bookingService.GetSupportBooking(bookingId);
        }
    }
}
