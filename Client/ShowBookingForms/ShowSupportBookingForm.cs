using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ShowBookingForms
{
    public partial class ShowSupportBookingForm : Form
    {
        public ShowSupportBookingForm(BookingServiceReference.Booking booking, BookingServiceReference.SupportBooking supportBooking)
        {
            InitializeComponent();
        }

        private void ShowSupportBookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
