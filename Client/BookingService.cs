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

        public IEnumerable<BookingServiceReference.SupportTask> GetAllSupportTask(int userId)
        {
            return bookingService.GetAllSupportTask(userId);
        }

        public IEnumerable<BookingServiceReference.SupportBooking> GetAllSupportBooking(int userId)
        {
            return bookingService.GetAllSupportBooking(userId);
        }

        public IEnumerable<BookingServiceReference.ReadyToGo> GetAllReadyToGo(int userId)
        {
            return bookingService.GetAllReadyToGo(userId);
        }
    }
}
