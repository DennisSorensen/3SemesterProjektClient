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
    public partial class Login : Form
    {

        UserService userService = new UserService();
        UserServiceReference.User User;
        public Login()
        {
            InitializeComponent();
            ListAllUsers();
        }

        //Metode som bliver kaldt hver gang se bruger fanen bliver trykket på
        private void ListAllUsers()
        {
            List<UserServiceReference.User> users = userService.GetAllUsers().ToList();

            tevAllUsers.Nodes.Clear();

            foreach (var user in users)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = user.Id + ", " + user.FirstName + " " + user.LastName;
                treeNode.Tag = user;
                tevAllUsers.Nodes.Add(treeNode);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserServiceReference.User selectedUser = new UserServiceReference.User(); //Opretter en nu user
            selectedUser = tevAllUsers.SelectedNode.Tag as UserServiceReference.User; //Tager den selected user fra treeView, og sætter den lig user variabel

            //Skriver selected user ud på labels og søgefelt id
            User = selectedUser;
            if (User.Role == "Admin")
            {
                this.Hide();
                AdminClientFront adminClientFront = new AdminClientFront(User);
                adminClientFront.Show();
            }
            else if (User.Role == "Supporter")
            {
                this.Hide();
                SupporterCalendar supporterCalendar = new SupporterCalendar(User);
                supporterCalendar.Show();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
