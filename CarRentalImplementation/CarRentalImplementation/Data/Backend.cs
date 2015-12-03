using FaradayCarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Data
{
    abstract class Backend
    {
        public abstract List<RentalCar> ShowAvailableCars(string city);

        public abstract Driver CreateDriver(Driver driver);

        public abstract Booking MakeABooking(Booking booking);

        public abstract Booking SeeABooking(Driver driver);

        public abstract Booking CancelABooking(Booking booking);

        public abstract RentalCar UpdateCarLocation(RentalCar rentalCar);
    }
}
