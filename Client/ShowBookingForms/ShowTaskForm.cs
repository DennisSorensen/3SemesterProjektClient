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
    public partial class ShowTaskForm : Form
    {
        public ShowTaskForm(BookingServiceReference.Booking booking, BookingServiceReference.SupportTask supportTask)
        {
            InitializeComponent();
        }

        private void ShowTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
