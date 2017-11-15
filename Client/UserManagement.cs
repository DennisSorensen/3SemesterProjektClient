﻿using System;
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

        public UserManagement()
        {
            InitializeComponent();
            
        }

        
        private void UserManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            //Laver en user, og kalder create over i WCFConnection

            //Sprøg brian hvorfor den kan se dette uden noget reference osv.

            int numberId = 0;

            try
            {
                numberId = Convert.ToInt32(tbUserId);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Det er ikke tal som ser skrevet");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Tallet er for stort til en int32");
            }
            catch (Exception e)
            {
                Console.WriteLine("Fejl med bruger id");
            }

            userService.CreateUser(numberId, cbUserRole.ToString(), tbUserFirstName.ToString(), tbUserLastName.ToString(), tbPassword.ToString());
            
        }

        
    }
}
