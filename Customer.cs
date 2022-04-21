using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore
{
    public class Customer
    {
        public string Name { get; }
        public List<Rental> Rentals { get; } = new List<Rental>();

        public Customer(string name)
        {
            Name = name;
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            StringBuilder outputToReciept = new StringBuilder();
            outputToReciept.AppendLine("Rental Record for " + Name);

            foreach (Rental rental in Rentals)
            {
                totalAmount += rental.Amount();
                frequentRenterPoints += rental.RenterPoints();
                rental.WriteValuesToReciept(outputToReciept);
            }

            // add footer lines
            outputToReciept.AppendLine("You owed " + TotalAmountAsDecimal(totalAmount).ToString("0.00"));
            outputToReciept.AppendLine("You earned " + frequentRenterPoints + " frequent renter points");

            return outputToReciept.ToString();
        }

        private static double TotalAmountAsDecimal(double totalAmount)
        {
            return (totalAmount/100);
        }
    }
}