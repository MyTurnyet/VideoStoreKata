using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoStore
{
    public class Customer
    {
        public string Name { get; init; }= String.Empty;
        public List<Rental> Rentals { get; } = new List<Rental>();

        public string Statement()
        {
            StringBuilder outputToReciept = new StringBuilder();
            outputToReciept.AppendLine("Rental Record for " + Name);

            int totalAmount = Rentals.Sum(rental => rental.Amount());
            int frequentRenterPoints = Rentals.Sum(rental => rental.RenterPoints());
            Rentals.ForEach(rental => rental.WriteValuesToReciept(outputToReciept));

            outputToReciept.AppendLine("You owed " + TotalAmountAsDecimal(totalAmount).ToString("0.00"));
            outputToReciept.AppendLine("You earned " + frequentRenterPoints + " frequent renter points");

            return outputToReciept.ToString();
        }

        private static double TotalAmountAsDecimal(double totalAmount)
        {
            return (totalAmount / 100);
        }
    }
}