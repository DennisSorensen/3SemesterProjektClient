using Client.ShowBookingForms;
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
    public partial class SupporterCalendar : Form
    {
        UserService userService = new UserService();
        CalendarService calendarService = new CalendarService();
        BookingService bookingService = new BookingService();

        DateTime selectedDate = new DateTime();

        //Opret en listView
        ListView listView = new ListView();
        UserServiceReference.User User;
        public SupporterCalendar(UserServiceReference.User user)
        {
            InitializeComponent();

            listView = lvViewCalendar;
            User = user;
            lblUserLoggedIn.Text = User.FirstName + " " + User.LastName;
            

        }

        private void SupporterCalendar_Load(object sender, EventArgs e)
        {

        }

        private void btnOpretTask_Click(object sender, EventArgs e)
        {
            CreateBookingSupporter createBookingSupporter = new CreateBookingSupporter(User);
            createBookingSupporter.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void LoadCalendar()
        {

        }
        

        private void showBookingWithType(int bookingId, string bookingType)
        {
            BookingServiceReference.Booking booking = bookingService.GetBooking(bookingId);

            if (bookingType == "ReadyToGo")
            {
                BookingServiceReference.ReadyToGo readyToGo = bookingService.GetReadyToGo(bookingId);

                //Viser formen
                ShowBookingForms.ShowReadyToGoForm showReadyToGoForm = new ShowReadyToGoForm(booking, readyToGo);
                showReadyToGoForm.Show();
            }
            else if (bookingType == "Task")
            {
                BookingServiceReference.SupportTask supportTask = bookingService.GetSupportTask(bookingId);

                //Viser formen
                ShowBookingForms.ShowTaskForm showTaskForm = new ShowTaskForm(booking, supportTask);
                showTaskForm.Show();
            }
            else if (bookingType == "SupportBooking")
            {
                BookingServiceReference.SupportBooking supportBooking = bookingService.GetSupportBooking(bookingId);

                //Viser formen
                ShowBookingForms.ShowSupportBookingForm showSupportBookingForm = new ShowSupportBookingForm(booking, supportBooking);
                showSupportBookingForm.Show();
            }
            else
            {
                MessageBox.Show("Fejl kunne ikke hente booking typen", "Booking type fejl");
            }
        }

        private void lvViewCalendar_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = listView.SelectedItems[0];
            BookingServiceReference.Booking booking = item.Tag as BookingServiceReference.Booking;

            //Kalde metode
            showBookingWithType(booking.Id, booking.BookingType);
        }

        private void mclDaySelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            CalendarServiceReference.Calendar calendar = calendarService.Get(User.Id);//Finder kalender med bruger id
            listView.Items.Clear();
            
            selectedDate = e.Start;
            //Klader bookingService, og får fat i bookingerne for dagen

            IEnumerable<BookingServiceReference.Booking> bookings = new List<BookingServiceReference.Booking>();

            //Her smider vi bookinger i den.
            bookings = bookingService.GetAllBookingSpecificDay(calendar.Id, selectedDate);
            //presenter dem, for de er sorteret i wcf
            foreach (var booking in bookings)
            {
                ListViewItem item = new ListViewItem();
                string s = string.Format("{0} - {1}", booking.StartDate.ToShortTimeString(), booking.EndDate.ToShortTimeString());
                string sSub = string.Format("{0}", booking.BookingType);
                item.Text = s;
                item.SubItems.Add(sSub);
                item.Tag = booking;
                listView.Items.Add(item);

            }
        }

        private void SupporterCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
