using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Entities
{
    internal class Rental
    {
        public string CarModel { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double PerHour { get; set; }
        public double PerDay { get; set; }

        public double Tax { get; set; }

        public Rental() { }

        public Rental(string carModel, DateTime pickupDate, DateTime returnDate, double perHour, double perDay)
        {
            CarModel = carModel;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
            PerHour = perHour;
            PerDay = perDay;
        }

        public double RentalPrice(double perHour, int hours)
        {
            double total = default;
            total = perHour * hours;
            Tax = total < 100 ? total * 0.2 : total * 0.15;
            return total;
        }

        public double RentalPrice(double perDay, int days, int hours)
        {
            if (hours != null)
            {
                days++;
            }
            double total = default;
            total = perDay * days;
            Tax = total * 0.15;
            return total;
        }
    }
}
