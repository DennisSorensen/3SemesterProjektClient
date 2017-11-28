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
        CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();
        DataTable table = new DataTable();
        string Tid;
        UserServiceReference.User User;
        public CalendarManagement(UserServiceReference.User user)
        {
            InitializeComponent();

            User = user;

            dgvSupportCalendar.AllowUserToResizeColumns = false;
            dgvSupportCalendar.AllowUserToResizeRows = false;
            table.Columns.Add("Tid", typeof(string));
            table.Columns.Add("Mandag", typeof(string));
            table.Columns.Add("Tirsdag", typeof(string));
            table.Columns.Add("Onsdag", typeof(string));
            table.Columns.Add("Torsdag", typeof(string));
            table.Columns.Add("Fredag", typeof(string));
            table.Columns.Add("Lørdag", typeof(string));
            table.Columns.Add("Søndag", typeof(string));
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
                dgvSupportCalendar.DataSource = table;
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

        }
    }
}
