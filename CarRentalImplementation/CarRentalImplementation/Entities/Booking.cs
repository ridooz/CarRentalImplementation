using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Entities
{
    class Booking
    {
        public PickUpStation PickUpPlace { get; set; }
        public DateTime TimeOfPickUp { get; set; }
        public PickUpStation DeliveryPlace { get; set; }
        public DateTime TimeOfDelivery { get; set; }
        public decimal ExtraFee { get; set; }
    }
}
