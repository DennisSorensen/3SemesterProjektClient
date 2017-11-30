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
    public partial class CalendarManagement : Form
    {
        UserService userService = new UserService();
        CalendarService calendarService = new CalendarService();
        BookingService bookingService = new BookingService();

        DateTime selectedDate = new DateTime();

        //Opret en listView
        ListView listView = new ListView();
        

        CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();
        //DataTable table = new DataTable();
        //string Tid;
        UserServiceReference.User User;
        public CalendarManagement(UserServiceReference.User user)
        {
            InitializeComponent();
            listView = lvViewCalendar;


            User = user;
            lblLoggedInUser.Text = User.FirstName + " " + User.LastName;
            //dgvSupportCalendar.AllowUserToResizeColumns = false;
            //dgvSupportCalendar.AllowUserToResizeRows = false;
            /*
            table.Columns.Add("Tid", typeof(string));
            table.Columns.Add("Mandag", typeof(string));
            table.Columns.Add("Tirsdag", typeof(string));
            table.Columns.Add("Onsdag", typeof(string));
            table.Columns.Add("Torsdag", typeof(string));
            table.Columns.Add("Fredag", typeof(string));
            table.Columns.Add("Lørdag", typeof(string));
            table.Columns.Add("Søndag", typeof(string));
            */
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

        private void btnFindCalendar_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtUserId.Text); //Laver bruger id om til en int
            CalendarServiceReference.Calendar calendar = calendarService.Get(userId); //Finder kalender med bruger id
            
            //Henter de tre forskellige bookinger, med det ovenstående kalender id
            bookingService.GetAllReadyToGo(calendar.Id);
            bookingService.GetAllSupportBooking(calendar.Id);
            bookingService.GetAllSupportTask(calendar.Id);

            //Skal sorterer de forskellige bookings


            //Smide booking ind i listViewItem
            ListViewItem item = new ListViewItem();
            item.Text = "9:00";
            item.SubItems.Add("Hej");
            item.SubItems.Add("med");
            
            ListViewItem item2 = new ListViewItem();
            item2.Text = "10:00";
            item2.SubItems.Add("Hej2");
            item2.SubItems.Add("med2");

            listView.Items.Add(item);
            listView.Items.Add(item2);
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminClientFront adminClientFront = new AdminClientFront(User);
            adminClientFront.Show();
            this.Close();

        }

        //Tager den valgte dag, og sætter den ind i selectedDate
        private void mclDaySelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;

            //Klader bookingService, og får fat i bookingerne for dagen

            List<BookingServiceReference.Booking> bookings = new List<BookingServiceReference.Booking>();

            //Her smider vi bookinger i den.

            //presenter dem, for de er sorteret i wcf
            foreach(var booking in bookings)
            {
                ListViewItem item = new ListViewItem();
                string s = string.Format("{0} {1} - {2}", booking.StartDate.ToShortTimeString(), booking.EndDate.ToShortTimeString(), booking.BookingType);
                item.Text = s;
                listView.Items.Add(item);
            }
        }
    }
}
