using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18.Entities;

namespace ConsoleApp18.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(Rental rental)
        {
            TimeSpan duration = rental.Finish.Subtract(rental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay *  Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            rental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
