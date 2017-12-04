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
        UserService userService = new UserService();

        public ShowTaskForm(BookingServiceReference.Booking booking, BookingServiceReference.SupportTask supportTask)
        {
            InitializeComponent();

            lblStartDate.Text = booking.StartDate.ToString();
            lblEndDate.Text = booking.EndDate.ToString();

            UserServiceReference.User user = userService.GetUser(booking.User_Id);
            lblCreatedBy.Text = user.FirstName + " " + user.LastName;

            lblName.Text = supportTask.Name.ToString();
            txtDescription.Text = supportTask.Description.ToString();

            
        }

        private void ShowTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
