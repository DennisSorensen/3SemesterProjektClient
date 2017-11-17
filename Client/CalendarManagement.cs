using Client.ServiceReference1;
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
        public CalendarManagement()
        {
            
            InitializeComponent();
            
            List<User> supporters = new List<User>();
            CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();
            supporters = service.GetAllSupporters();
            foreach (var user in supporters)
            {

                string s = string.Format("{0} {1}", user.FirstName, user.LastName);
                listAllSupport.Items.Add(s);
            }
            
                        
        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {
            
            User selectedUser = listAllSupport.SelectedItem as User;
            
            
            string s = string.Format("{0} {1}'s kalender er blevet lavet", selectedUser.FirstName, selectedUser.LastName);
            MessageBox.Show(s, "Kalender lavet");
            
        }

     
    }
}
