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
    public partial class ResultForm2 : Form
    {
        Booking booking;
        public ResultForm2(Booking booking)
        {
            this.booking = booking;
            InitializeComponent();

            label1.Text = "Du har netop booket bilen: " + booking.car.LicensePlate + " med start og slut: " + booking.TimeOfPickUp + "-" + booking.TimeOfDelivery + ". Ekstra omkostninger for eventuel ændring af pickup destination: " + booking.ExtraFee;
        }
    }
}
