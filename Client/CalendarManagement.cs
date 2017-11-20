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
        public CalendarManagement()
        {
            
            InitializeComponent();
            
            CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();
            DataTable table = new DataTable();
            string Tid;

                        
        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {
            
            /*UserServiceReference.User selectedUser = listAllSupport.SelectedItem as UserServiceReference.User;
            CalendarServiceReference.Calendar calendar = new CalendarServiceReference.Calendar();
            calendar.UserId = selectedUser.Id;
            calendarService.CreateCalendar(calendar);
            */
            
            var selectedUser = listAllSupport.SelectedItem;
            string ss = Convert.ToString(selectedUser);
            string[] words = ss.Split(',');
            int i = Int32.Parse(words[0]);
            UserServiceReference.User user = userService.GetUser(i);
            CalendarServiceReference.Calendar calendar = new CalendarServiceReference.Calendar();
            calendar.UserId = user.Id;
            calendarService.CreateCalendar(calendar);
            
            string s = string.Format("{0} {1}'s kalender er blevet lavet", user.FirstName, user.LastName);
            MessageBox.Show(s, "Kalender lavet");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 0)
            {
                List<UserServiceReference.User> supporters = new List<UserServiceReference.User>();
                supporters = userService.GetAllSupporters().ToList();
                tevAllSupport.Nodes.Clear();
                foreach (var user in supporters)
                {

                    string s = string.Format("{0}, {1} {2}", user.Id, user.FirstName, user.LastName);
                    listAllSupport.Items.Add(s);
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = user.Id + ", " + user.FirstName + " " + user.LastName;
                    treeNode.Tag = user;
                    tevAllSupport.Nodes.Add(treeNode);
                }
            }
            else if(e.TabPageIndex == 1)
            {

            }

        }
    }
}
