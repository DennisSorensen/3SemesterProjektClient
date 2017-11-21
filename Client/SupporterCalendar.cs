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
        DataTable table = new DataTable();

        public SupporterCalendar()
        {
            InitializeComponent();

            table.Columns.Add("Tid", typeof(string));
            table.Columns.Add("Mandag", typeof(string));
            table.Columns.Add("Tirsdag", typeof(string));
            table.Columns.Add("Onsdag", typeof(string));
            table.Columns.Add("Torsdag", typeof(string));
            table.Columns.Add("Fredag", typeof(string));
            table.Columns.Add("Lørdag", typeof(string));
            table.Columns.Add("Søndag", typeof(string));
        }

        private void SupporterCalendar_Load(object sender, EventArgs e)
        {
            dgvSupporterCalendar.DataSource = table;
        }
    }
}
