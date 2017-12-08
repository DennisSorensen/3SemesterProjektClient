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
    public partial class CreateBookingSælger : Form
    {
        UserServiceReference.User user = new UserServiceReference.User();

        BookingService bookingService = new BookingService();
        public CreateBookingSælger(UserServiceReference.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CreateBookingSælger_Load(object sender, EventArgs e)
        {
            
        }

        private void cbService_TextChanged(object sender, EventArgs e)
        {
            hideAndUncheckAdditionalServices();

            switch (cbService.Text)
            {
                case "Pc":
                    chbOffice.Show();
                    chbInstallPrinter.Show();
                    break;
                case "Tv":
                    break;
                case "Mobil":
                    chbOffice.Show();
                    break;
                case "Tablet":
                    chbOffice.Show();
                    break;
                case "Gps":
                    break;
                case "Ur":
                    break;
                case "Spillekonsol":
                    break;
                default:
                    MessageBox.Show("Dette er ikke en ting vi kan lave en RTG på", "Forkert device");
                    break;
            }

            
            
        }

        private void hideAndUncheckAdditionalServices()
        {
            chbOffice.Hide();
            chbInstallPrinter.Hide();
            chbOffice.Checked = false;
            chbInstallPrinter.Checked = false;
        }

        private void btnCreateRTG_MouseClick(object sender, MouseEventArgs e)
        {
            BookingServiceReference.ReadyToGo readyToGo = new BookingServiceReference.ReadyToGo(); //Opretter en tom RTG

            //Udfylder felter til RTG

            //Tjekker på hvilken service det er, og sætter tid efter dette
            if (cbService.Text == "Pc")
            {
                if (chbOffice.Checked)
                {
                    readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text).AddHours(-1.5);
                    readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.5);
                }
                else
                {
                    readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text).AddHours(-1.67);
                    readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.33);
                }
                
            }
            else if (cbService.Text == "Tv")
            {
                readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.42);
            }
            else if (cbService.Text == "Mobil")
            {
                readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.5);
            }
            else if (cbService.Text == "Tablet")
            {
                readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.33);
            }
            else if (cbService.Text == "Gps")
            {
                readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text).AddHours(-4.0);
                readyToGo.StartDate = readyToGo.EndDate.AddMinutes(-3.33);
            }
            else if (cbService.Text == "Ur")
            {
                readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.58);
            }
            else if (cbService.Text == "Spillekonsol")
            {
                readyToGo.EndDate = Convert.ToDateTime(cbEndDate.Text);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-2.0);
            }

            //Tilføjer tillægsydelser til RTG'en
            if (chbOffice.Checked && chbInstallPrinter.Checked)
            {
                readyToGo.AdditionalServices = "Installer offige og printer";
            }
            else if (chbOffice.Checked)
            {
                readyToGo.AdditionalServices = "Installer office";
            }
            else if (chbInstallPrinter.Checked)
            {
                readyToGo.AdditionalServices = "Installer printer";
            }
            else
            {
                readyToGo.AdditionalServices = "";
            }

            readyToGo.AppendixNr = Convert.ToInt32(txtAppendixNr.Text);
            readyToGo.ProductNr = txtProductNr.Text;

            //Tjekker om RTG her en kontrakt
            if (rbYesContract.Checked)
            {
                readyToGo.Contract = true;
            }
            else
            {
                readyToGo.Contract = false;
            }

            //Tilføjer userid
            readyToGo.User_Id = user.Id;
            readyToGo.BookingType = "ReadyToGo";

            int calendarId = bookingService.FindAvaibleCalendar(readyToGo.StartDate, readyToGo.EndDate);
            if (calendarId > 0) {
                //Skal tilføje et kalender id, men den skal tjekke for ledige tider i alle kalendre først
                readyToGo.Calendar_Id = calendarId;
                try
                {
                    bookingService.CreateReadyToGo(readyToGo); //Sender RTG'en vidre til service, og bliver senere gemt i db.
                    string s = string.Format("RTG oprettet og kan afhentes kl: {0}", Convert.ToDateTime(cbEndDate.Text));
                    MessageBox.Show(s, "RTG oprettet");
                }
                catch
                {
                    MessageBox.Show("Kunne ikke oprette booking", "Fejl");
                }
            }
            else
            {
                MessageBox.Show("Der er en tid på dette tidspunkt","Tid taget");
            }
            
        }
    }
}
