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
            btnLogin.Focus();
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
            int userId;
            bool result = Int32.TryParse(txtUserId.Text, out userId);
            if (result)
            {
                UserServiceReference.User user = userService.Login(userId, txtPassword.Text);
                if(user != null)
                {
                    ShowSelectedForm(user);
                }
                else
                {
                    string s = string.Format("Koden er forkert", txtUserId.Text);
                    MessageBox.Show(s, "Login Fejl");
                }
            }
            else
            {
                string s = string.Format("Bruger forkert", txtUserId.Text);
                MessageBox.Show(s, "Login Fejl");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void ShowSelectedForm(UserServiceReference.User user)
        {
            if (user.Role == "Admin")
            {
                this.Hide();
                AdminClientFront adminClientFront = new AdminClientFront(user);
                adminClientFront.Show();
            }
            else if (user.Role == "Supporter")
            {
                this.Hide();
                SupporterCalendar supporterCalendar = new SupporterCalendar(user);
                supporterCalendar.Show();
            }
            else if (user.Role == "Sælger")
            {
                this.Hide();
                CreateBookingSalesman createBookingSælger = new CreateBookingSalesman(user);
                createBookingSælger.Show();
            }
        }

        private void tevAllUsers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Skriver selected user ud på labels og søgefelt id
            UserServiceReference.User user = e.Node.Tag as UserServiceReference.User;
            Console.WriteLine(user.FirstName);
            User = user;
            ShowSelectedForm(User);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
