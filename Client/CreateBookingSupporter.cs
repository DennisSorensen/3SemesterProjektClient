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
            dtpDate.Value = DateTime.Now.Date;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            DateTime date;
            DateTime time;
            DateTime dateTime;
            BookingServiceReference.SupportTask supportTask = new BookingServiceReference.SupportTask();
            supportTask.User_Id = User.Id;
            date = dtpDate.Value.Date;

            time = Convert.ToDateTime(cbTaskStatDate.Text);
            dateTime = date.Date + time.TimeOfDay;
            supportTask.StartDate = dateTime;

            time = Convert.ToDateTime(cbTaskEndDate.Text);
            dateTime = date.Date + time.TimeOfDay;
            supportTask.EndDate = dateTime;
            
            supportTask.Name = txtTaskName.Text;
            supportTask.Description = txtTaskDescription.Text;
            CalendarServiceReference.Calendar calendar = calendarService.Get(User.Id);
            supportTask.Calendar_Id = calendar.Id;
            supportTask.BookingType = "Task";
            if (cbTaskEndDate.Text != null && cbTaskStatDate != null)
            {
                if (supportTask.EndDate > supportTask.StartDate)
                {
                    try
                    {
                        bookingService.CreateTask(supportTask);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kunne ikke oprette booking", "Fejl");
                    }
                }
                else
                {
                    MessageBox.Show("Slut tid er mindre end Start tid", "Fejl");
                }
            }
            else
            {
                MessageBox.Show("Ikke alle tidspunkter er udfyldt", "Fejl");
            }
        }

        private void CreateBookingSupporter_Load(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Kan ikke sætte en task i fortiden", "Fejl");
                dtpDate.Value = DateTime.Now;
            }
            else
            {

            }
        }
    }
}
