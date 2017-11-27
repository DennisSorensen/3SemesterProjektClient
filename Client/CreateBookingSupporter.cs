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

        int userId = 2;

       public CreateBookingSupporter(/*int userId*/)
        {
            InitializeComponent();
            //this.userId = userId;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            BookingServiceReference.SupportTask supportTask = new BookingServiceReference.SupportTask();
            supportTask.StartDate = Convert.ToDateTime(cbTaskStatDate.Text);
            supportTask.EndDate = Convert.ToDateTime(cbTaskEndDate.Text);
            supportTask.Name = txtTaskName.Text;
            supportTask.Description = txtTaskDescription.Text;
            CalendarServiceReference.Calendar calendar = calendarService.Get(userId);
            supportTask.Calendar_Id = calendar.Id;
            supportTask.User_Id = userId;
            supportTask.BookingType = "Task";

            bookingService.CreateTask(supportTask);
            
        }

        private void CreateBookingSupporter_Load(object sender, EventArgs e)
        {

        }
    }
}
