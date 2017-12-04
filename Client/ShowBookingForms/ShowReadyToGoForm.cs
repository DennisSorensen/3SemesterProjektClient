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
    public partial class ShowReadyToGoForm : Form
    {
        public ShowReadyToGoForm(BookingServiceReference.Booking booking, BookingServiceReference.ReadyToGo readyToGo)
        {
            InitializeComponent();
        }

        private void ShowReadyToGoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
