using FaradayCarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaradayCarRental.Data
{
    class DummyBackend : Backend
    {
        public List<RentalCar> rentalCars;

        public DummyBackend()
        {
            Entities.Type typeA, typeB, typeC;
            PickUpStation placeHotel, placeAirport;
            RentalCar carA, carB, carC, carD;

            typeA = new Entities.Type()
            {
                Price = 100,
                SeatAmount = 5,
                TypeName = 'a'
            };

            typeB = new Entities.Type()
            {
                Price = 1000,
                SeatAmount = 7,
                TypeName = 'b'
            };

            typeC = new Entities.Type()
            {
                Price = 10000,
                SeatAmount = 14,
                TypeName = 'c'
            };

            placeHotel = new Hotel()
            {
                Address = "lolstreet",
                City = "Lyngby",
                Id = 012345,
                Name = "Lol Hotel",
                StarRating = 5
            };

            placeAirport = new Airport()
            {
                City = "Kastrup",
                IATA = "CPH"
            };

            carA = new RentalCar()
            {
                Type = typeA,
                Available = true,
                CurrentLocation = placeHotel,
                LicensePlate = "er34231"
            };

            carB = new RentalCar()
            {
                Type = typeB,
                Available = false,
                CurrentLocation = placeHotel,
                LicensePlate = "er34671"
            };

            carC = new RentalCar()
            {
                Type = typeC,
                Available = true,
                CurrentLocation = placeAirport,
                LicensePlate = "er34981"
            };

            carD = new RentalCar()
            {
                Type = typeB,
                Available = true,
                CurrentLocation = placeAirport,
                LicensePlate = "er34983"
            };

            rentalCars = new List<RentalCar> { carA, carB, carC, carD };
        }

        public override Booking CancelABooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public override Driver CreateDriver(Driver driver)
        {
            throw new NotImplementedException();
        }

        public override Booking MakeABooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public override Booking SeeABooking(Driver driver)
        {
            throw new NotImplementedException();
        }

        public override List<RentalCar> ShowAvailableCars(string city)
        {
            return (from car in rentalCars where car.Available && car.CurrentLocation.City.Equals(city) select car).ToList<RentalCar>();
        }

        public override RentalCar UpdateCarLocation(RentalCar rentalCar)
        {
            throw new NotImplementedException();
        }
    }
}
