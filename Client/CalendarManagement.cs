using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ShowBookingForms;


namespace Client
{
    public partial class CalendarManagement : Form
    {
        UserService userService = new UserService();
        CalendarService calendarService = new CalendarService();
        BookingService bookingService = new BookingService();

        DateTime selectedDate = new DateTime();
        bool back = false;
        //Opret en listView
        ListView listView = new ListView();
        

        CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();
        UserServiceReference.User User;
        public CalendarManagement(UserServiceReference.User user)
        {
            InitializeComponent();
            listView = lvViewCalendar;


            User = user;
            lblLoggedInUser.Text = User.FirstName + " " + User.LastName;
            SupporterList();

        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {

            UserServiceReference.User selectedUser = tevAllSupport.SelectedNode.Tag as UserServiceReference.User;
            CalendarServiceReference.Calendar calendar = new CalendarServiceReference.Calendar();
            calendar.UserId = selectedUser.Id;
            calendarService.CreateCalendar(calendar);
            
            string s = string.Format("{0} {1}'s kalender er blevet lavet", selectedUser.FirstName, selectedUser.LastName);
            MessageBox.Show(s, "Kalender lavet");
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 0)
            {
                SupporterList();
            }
            else if(e.TabPageIndex == 1)
            {
                //dgvSupportCalendar.DataSource = table;
            }

        }

        private void SupporterList()
        {
            List<UserServiceReference.User> supporters = new List<UserServiceReference.User>();
            supporters = userService.GetAllSupporters().ToList();
            tevAllSupport.Nodes.Clear();
            foreach (var user in supporters)
            {
                string s = string.Format("{0}, {1} {2}", user.Id, user.FirstName, user.LastName);
                TreeNode treeNode = new TreeNode();
                treeNode.Text = user.Id + ", " + user.FirstName + " " + user.LastName;
                treeNode.Tag = user;
                tevAllSupport.Nodes.Add(treeNode);
            }
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            back = false;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();

        }

        //Tager den valgte dag, og sætter den ind i selectedDate
        private void mclDaySelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            listView.Items.Clear();
            int userId;
            bool result = Int32.TryParse(txtUserId.Text, out userId);


            CalendarServiceReference.Calendar calendar = calendarService.Get(userId); //Finder kalender med bruger id
            selectedDate = e.Start;
            if (result && txtUserId.Text != null)
            {
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
            else
            {
                string s = string.Format("{0} er ikke et nummer", txtUserId.Text);
                MessageBox.Show(s, "Fejl");
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            int userId;
            bool result = Int32.TryParse(txtUserId.Text, out userId);

            if (result)
            {
                //Henter user ud fra id, og sætter navnet på user ind i label
                UserServiceReference.User user = userService.GetUser(userId);
                lblViewCalUserName.Text = user.FirstName + " " + user.LastName;
            }
            else
            {
                string s = string.Format("{0} er ikke et nummer", txtUserId.Text);
                MessageBox.Show(s, "Fejl");
            }

        }

        private void lvViewCalendar_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = listView.SelectedItems[0];
            BookingServiceReference.Booking booking = item.Tag as BookingServiceReference.Booking;

            //Kalde metode
            showBookingWithType(booking.Id, booking.BookingType);
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
            else {
                MessageBox.Show("Fejl kunne ikke hente booking typen", "Booking type fejl");
            }
        }

        private void CalendarManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (back == false)
            {
                Login login = new Login();
                login.Show();
            }
            else
            {
                AdminClientFront adminClientFront = new AdminClientFront(User);
                adminClientFront.Show();
            }
        }
    }
}

