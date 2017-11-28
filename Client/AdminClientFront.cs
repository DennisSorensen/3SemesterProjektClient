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
    public partial class AdminClientFront : Form
    {
        UserServiceReference.User User;
        public AdminClientFront(UserServiceReference.User user)
        {
            InitializeComponent();
            User = user;
        }
        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement um = new UserManagement(User);
            um.Show();
        }

        private void btnCalManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarManagement cm = new CalendarManagement(User);
            cm.Show();
        }

        private void btnLogUd_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
