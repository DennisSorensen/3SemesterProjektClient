using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CreateBookingSupporter : Form
    {
        BookingService bookingService = new BookingService();
        CalendarService calendarService = new CalendarService();
        UserServiceReference.User User;

       public CreateBookingSupporter(UserServiceReference.User user)
        {
            InitializeComponent();
            User = user;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            BookingServiceReference.SupportTask supportTask = new BookingServiceReference.SupportTask();
            supportTask.User_Id = User.Id;
            supportTask.StartDate = Convert.ToDateTime(cbTaskStatDate.Text);
            supportTask.EndDate = Convert.ToDateTime(cbTaskEndDate.Text);
            supportTask.Name = txtTaskName.Text;
            supportTask.Description = txtTaskDescription.Text;
            CalendarServiceReference.Calendar calendar = calendarService.Get(User.Id);
            supportTask.Calendar_Id = calendar.Id;
            supportTask.BookingType = "Task";

            bookingService.CreateTask(supportTask);
            this.Close();
            
        }

        private void CreateBookingSupporter_Load(object sender, EventArgs e)
        {

        }
    }
}
