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
        UserServiceReference.User User;
        public SupporterCalendar(UserServiceReference.User user)
        {
            InitializeComponent();

            User = user;
            lblUserLoggedIn.Text = User.FirstName + " " + User.LastName;


            ListViewItem item = new ListViewItem();
            item.Text = "9:00";
            item.SubItems.Add("SubItem");
            ListViewSupport.Items.Add(item);

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


    }
}
