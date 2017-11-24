using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.BookingServiceReference;

namespace Client
{
    class BookingService
    {
        BookingServiceReference.IBookingService bookingService = new BookingServiceReference.BookingServiceClient();

        public void CreateTask(BookingServiceReference.SupportTask supportTask)
        {
            bookingService.CreateSupportTask(supportTask);
        }

    }
}
