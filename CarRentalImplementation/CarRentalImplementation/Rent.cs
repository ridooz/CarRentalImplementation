using FaradayCarRental.Control;
using FaradayCarRental.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarRentalImplementation
{
    public partial class Rent : Form
    {

        RentalCar car;
        DateTime dateStart;
        DateTime dateSlut;

        public Rent(RentalCar car, DateTime dateStart, DateTime dateSlut)
        {
            this.car = car;
            this.dateSlut = dateSlut;
            this.dateStart = dateStart;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != null && textBox2.Text != null)
            {
                if (Convert.ToInt32(textBox3.Text) >= 18)
                {

                    Driver driver = new Driver();
                    driver.DriverLicenceNumber = textBox1.Text;
                    driver.PassportName = textBox2.Text;
                    driver.age = Convert.ToInt32(textBox3.Text);


                    Booking booking = new Booking();
                    booking.car = car;
                    booking.driver = driver;
                    booking.TimeOfDelivery = dateStart;
                    booking.TimeOfPickUp = dateSlut;


                    if (checkBox1.Checked)
                    {
                        string newDeliverLocation = textBox4.Text;
                        booking.car.CurrentLocation.City = newDeliverLocation;
                        booking.PickUpPlace = car.CurrentLocation;
                        booking.ExtraFee = 100;
                    }
                    else
                    {
                        booking.PickUpPlace = car.CurrentLocation;
                    }

                    Controller c = new Controller();
                    Booking justBooked = c.MakeABooking(booking);

                    ResultForm2 resultForm = new ResultForm2(justBooked);
                    resultForm.Show();
                }
                else
                {
                    // age exception
                }
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}
