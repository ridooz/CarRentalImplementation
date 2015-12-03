using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Entities
{
    public class Booking
    {
        public Driver driver { get; set; }
        public RentalCar car { get; set; }
        public PickUpStation PickUpPlace { get; set; }
        public DateTime TimeOfPickUp { get; set; }
        public PickUpStation DeliveryPlace { get; set; }
        public DateTime TimeOfDelivery { get; set; }
        public decimal ExtraFee { get; set; }
    }
}
