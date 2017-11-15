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
        //Lav en service reference, sådan vi kan kalde metoder
        

        public CalendarManagement()
        {
            InitializeComponent();
            
            List<User> supporters = new List<User>();
            ServiceReference1.IService1 service = new ServiceReference1.Service1Client();
            supporters = service.GetAllSupporters();
            foreach (var user in supporters)
            {

                String s = String.Format("{0} {1}", user.FirstName, user.LastName);
                listAllSupport.Items.Add(s);
            }
            
            // kode til at sætte liste i listbox
            
        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {

        }
    }
}
