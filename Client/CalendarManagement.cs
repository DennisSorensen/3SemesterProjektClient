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
        public CalendarManagement()
        {
            InitializeComponent();
            // kode til at finde en liste af supportere 
            List<User> supporters = new List<User>(); // lav ref til service.
            supporters = service.GetAll();      // Lav et type-input i getAll med role?

            // kode til at sætte liste i listbox
            
        }

        private void btnCreateCal_Click(object sender, EventArgs e)
        {

        }
    }
}
