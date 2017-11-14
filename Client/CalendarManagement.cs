using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;

namespace Client
{
    public partial class CalendarManagement : Form
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        

        public CalendarManagement()
        {
            InitializeComponent();
            
            List<User> supporters = new List<User>(); 
            supporters = service.GetAllSupporters();

            foreach (var User in supporters)
            {
                listAllSupport.Items.Add()
            }
            
            // kode til at sætte liste i listbox
            
        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {

        }
    }
}
