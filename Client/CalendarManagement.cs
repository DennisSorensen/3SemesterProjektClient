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
            
            List<UserServiceReference.User> supporters = new List<UserServiceReference.User>();
            CalendarServiceReference.ICalendarService service = new CalendarServiceReference.CalendarServiceClient();
            supporters = userService.GetAllSupporters().ToList();
            foreach (var user in supporters)
            {

                string s = string.Format("{0}, {1} {2}", user.Id, user.FirstName, user.LastName);
                listAllSupport.Items.Add(s);
            }
           
                        
        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {
            /*
            UserServiceReference.User selectedUser = listAllSupport.SelectedItem as UserServiceReference.User;
            CalendarServiceReference.Calendar calendar = new CalendarServiceReference.Calendar();
            calendar.UserId = selectedUser.Id;
            calendarService.CreateCalendar(calendar);
            
            string s = string.Format("{0} {1}'s kalender er blevet lavet", selectedUser.FirstName, selectedUser.LastName);
            MessageBox.Show(s, "Kalender lavet");
          */

            var selectedObj = listAllSupport.SelectedItem; //Henter obj fra listen
            string ss = Convert.ToString(selectedObj); //Formaterer obj til string
            string[] words = ss.Split(',');//Deler strengen op
            int i = Int32.Parse(words[0]);//Tager den første string i listen og formaterer den fra string til int
            UserServiceReference.User user = userService.GetUser(i);// Henter user med den int id vi har fundet ovenover
            CalendarServiceReference.Calendar calendar = new CalendarServiceReference.Calendar();// oprettet et nyt calender object
            calendar.UserId = user.Id;// den nye calendar får et user id
            calendarService.CreateCalendar(calendar);// oprettet calender objectet

            //printer en messagebox til skærmen ang succes
            string s = string.Format("{0} {1}'s kalender er blevet lavet", user.FirstName, user.LastName);
            MessageBox.Show(s, "Kalender lavet");
        }

     
    }
}
