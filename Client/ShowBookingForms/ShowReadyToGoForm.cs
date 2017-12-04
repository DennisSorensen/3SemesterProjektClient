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
        UserService userService = new UserService();

        public ShowReadyToGoForm(BookingServiceReference.Booking booking, BookingServiceReference.ReadyToGo readyToGo)
        {
            InitializeComponent();

            lblStartDate.Text = booking.StartDate.ToString();
            lblEndDate.Text = booking.EndDate.ToString();

            UserServiceReference.User user = userService.GetUser(booking.User_Id);
            lblCreatedBy.Text = user.FirstName + " " + user.LastName;

            lblProductNr.Text = readyToGo.ProductNr.ToString();
            lblAppendixNr.Text = readyToGo.AppendixNr.ToString();

            if (readyToGo.Contract == true)
            {
                lblHasContract.Text = "Ja";
            }
            else
            {
                lblHasContract.Text = "Nej";
            }
            
        }

        private void ShowReadyToGoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
