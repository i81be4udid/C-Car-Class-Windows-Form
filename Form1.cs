using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Proj
{
    public partial class Form1 : Form
    {
        private Car myCar;

        public Form1()
        {
            myCar = new Car();

            InitializeComponent();
        }
        /*
        private void GetCarData(Car car)
        {
            try
            {
                myCar.Make = txtMake.Text;

                

                myCar.Speed = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Must enter a valid make and year model for the car. ", ex.Message, "\r\n", ex.StackTrace));
            }
        }
        */

        private void BtnAcc_Click(object sender, EventArgs e)
        {
            //GetCarData(myCar);

            myCar.AccSpeed(5);
            
            lblSpeed.Text = myCar.Speed.ToString();
            MessageBox.Show(" Your car is a " + myCar.Year + myCar.Make + " and it is     traveling " + myCar.Speed + " mph. ");
        }

        private void BtnBrake_Click(object sender, EventArgs e)
        {
            //GetCarData(myCar);
            if (myCar.Speed != 0)
            {
                myCar.DecSpeed(5);
                lblSpeed.Text = myCar.Speed.ToString();
                MessageBox.Show(" Your car is a " + myCar.Year + myCar.Make + " and it is     traveling " + myCar.Speed + " mph. ");
            }
            else
            {
                MessageBox.Show("Car is already stopped");
            }
            
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            string make;
            
            int year;
            if (txtMake.Text.Trim() == "")
            {
                MessageBox.Show("Make cannot be empty");
                txtMake.Focus();
                return;
            }
            

            if (!Int32.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Year is invalid");
                txtYear.Focus();
                return;
            }
            
            make = txtMake.Text;            
            myCar.Make = make;
            //year = Int32.Parse(txtYear.Text);
            myCar.Year = year;
            myCar.Speed = 0;

            MessageBox.Show("Car object created with, " + "Year: " + year + ", Make: " + make);



        }
    }
}