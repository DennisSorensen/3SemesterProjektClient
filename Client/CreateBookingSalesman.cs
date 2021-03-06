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
    public partial class CreateBookingSalesman : Form
    {
        UserServiceReference.User user = new UserServiceReference.User();

        BookingService bookingService = new BookingService();
        public CreateBookingSalesman(UserServiceReference.User user)
        {
            InitializeComponent(); //Starter komponenter
            this.user = user;
            lblUser.Text = user.FirstName + " " + user.LastName;
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
            DateTime date;
            DateTime time;
            DateTime dateTime;
            //Udfylder felter til RTG
            date = dtpDate.Value.Date;

            //Tjekker på hvilken service det er, og sætter tid efter dette
            time = Convert.ToDateTime(cbEndDate.Text);
            dateTime = date.Date + time.TimeOfDay;
            if (cbService.Text == "Pc")
            {
                if (chbOffice.Checked)
                {
                    readyToGo.EndDate = Convert.ToDateTime(dateTime).AddHours(-1.5); //Regner slut tid tilbage
                    readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.5); //Regner start tid ud fra slut tid
                }
                else
                {
                    readyToGo.EndDate = Convert.ToDateTime(dateTime).AddHours(-1.67);
                    readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.33);
                }
                
            }
            else if (cbService.Text == "Tv")
            {
                readyToGo.EndDate = Convert.ToDateTime(dateTime);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.42);
            }
            else if (cbService.Text == "Mobil")
            {
                readyToGo.EndDate = Convert.ToDateTime(dateTime);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.5);
            }
            else if (cbService.Text == "Tablet")
            {
                readyToGo.EndDate = Convert.ToDateTime(dateTime);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.33);
            }
            else if (cbService.Text == "Gps")
            {
                readyToGo.EndDate = Convert.ToDateTime(dateTime).AddHours(-4.0);
                readyToGo.StartDate = readyToGo.EndDate.AddMinutes(-3.33);
            }
            else if (cbService.Text == "Ur")
            {
                readyToGo.EndDate = Convert.ToDateTime(dateTime);
                readyToGo.StartDate = readyToGo.EndDate.AddHours(-0.58);
            }
            else if (cbService.Text == "Spillekonsol")
            {
                readyToGo.EndDate = Convert.ToDateTime(dateTime);
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
            if (calendarId > 0)
            {
                readyToGo.Calendar_Id = calendarId;
                try
                {
                    bookingService.CreateReadyToGo(readyToGo); //Sender RTG'en vidre til service, og bliver senere gemt i db.
                    string s = string.Format("RTG oprettet og kan afhentes kl: {0}", Convert.ToDateTime(dateTime));
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

        private void btnCreateRTG_Click(object sender, EventArgs e)
        {

        }

        private void CreateBookingSalesman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Kan ikke sætte en task i fortiden", "Fejl");
                dtpDate.Value = DateTime.Now;
            }
            else
            {

            }
        }

        private void CreateBookingSalesman_Load(object sender, EventArgs e)
        {

        }
    }
}
