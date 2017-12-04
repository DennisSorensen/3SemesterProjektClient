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

        UserService userService = new UserService();
        
        public ShowSupportBookingForm(BookingServiceReference.Booking booking, BookingServiceReference.SupportBooking supportBooking)
        {
            InitializeComponent();

            lblStartDate.Text = booking.StartDate.ToString();
            lblEndDate.Text = booking.EndDate.ToString();

            UserServiceReference.User user = userService.GetUser(booking.User_Id);
            lblCreatedBy.Text = user.FirstName + " " + user.LastName;

            lblName.Text = supportBooking.FirstName + " " + supportBooking.LastName;
            lblPhone.Text = supportBooking.Phone.ToString();
            txtDescription.Text = supportBooking.Description;
        }

        private void ShowSupportBookingForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
