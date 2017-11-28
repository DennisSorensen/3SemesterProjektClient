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
    public partial class UserManagement : Form
    {
        UserService userService = new UserService();
        UserServiceReference.User User;
        
        public UserManagement(UserServiceReference.User user)
        {
            InitializeComponent();
            User = user;

        }

        
        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            
            //Laver en user, og kalder create over i WCFConnection

            //Sprøg brian hvorfor den kan se dette uden noget reference osv.

            //Int værdi til id, som skal laves om fra string i gui, til int
            int numberId = 0;

            try
            {
                numberId = Convert.ToInt32(tbUserId.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Det er ikke tal som er skrevet");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Tallet er for stort til en int32");
            }
            
            catch (Exception)
            {
                Console.WriteLine("Fejl med bruger id");
            }

            //Opretter user obj med værdier fra gui
            UserServiceReference.User user = new UserServiceReference.User() { Id = numberId,
                                                                         Role = cbUserRole.Text.ToString(),
                                                                         FirstName = tbUserFirstName.Text.ToString(),
                                                                         LastName = tbUserLastName.Text.ToString(),
                                                                         Password = tbPassword.Text.ToString(),
                                                                         DepartmentId = Convert.ToInt32(txtDepartment.Text)
                                                                        };

            //Messagebox til og fortælle om bruger er oprettet eller ej
            if (userService.CreateUser(user) == true)
            {
                //Sucess
                MessageBox.Show("Bruger oprettet korrekt", "Sucess");
            }
            else
            {
                //Fail
                MessageBox.Show("Bruger med dette id eksisterer allerede", "Id fejl");
            }
            
        }

        private void tpCreateUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            //Int værdi til id, som skal laves om fra string i gui, til int
            int numberId = 0;

            try
            {
                numberId = Convert.ToInt32(txtInputUserId.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Det er ikke tal som er skrevet");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Tallet er for stort til en int32");
            }

            catch (Exception)
            {
                Console.WriteLine("Fejl med bruger id");
            }

            //Opretter et user obj til og gemme user i fra UserService
            UserServiceReference.User user = userService.GetUser(numberId);

            if (user != null) //Tjekker om det er en bruger, eller om det er en null bruger
            {
                //Sætter variabler på gui
                lblRole.Text = user.Role;
                lblFirstName.Text = user.FirstName;
                lblLastName.Text = user.LastName;
                lblPassword.Text = user.Password;
                lblDepartment.Text = user.DepartmentId.ToString();
            }
            else
            {
                MessageBox.Show("Der er ingen bruger med dette id", "Forkert bruger id");
            }
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

        //Metode som kan bestemme hvilken fane man er i
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) //Når se bruger fanen klikkes på
            {
                ListAllUsers();
            }
        }

        //Metode som indeholder den selected user fra treeView
        private void tevAllUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UserServiceReference.User user = new UserServiceReference.User(); //Opretter en nu user
            user = e.Node.Tag as UserServiceReference.User; //Tager den selected user fra treeView, og sætter den lig user variabel
            
            //Skriver selected user ud på labels og søgefelt id
            txtInputUserId.Text = user.Id.ToString();
            lblRole.Text = user.Role;
            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
            lblPassword.Text = user.Password;
            lblDepartment.Text = user.DepartmentId.ToString();
        }
        
    }
}
