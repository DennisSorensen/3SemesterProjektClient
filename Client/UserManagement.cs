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
        public UserManagement()
        {
            InitializeComponent();
        }

        //Laver en instans af vores service reference, sådan vi kan kalde dem
        ServiceReference1.IService1 service = new ServiceReference1.Service1Client();
        
        private void UserManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

        }

        
    }
}
