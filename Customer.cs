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

            int totalAmount = TotalAmount();
            int frequentRenterPoints = FrequentRenterPoints();
            Rentals.ForEach(rental => rental.WriteValuesToReciept(outputToReciept));

            outputToReciept.AppendLine("You owed " + TotalAmountFormattedAsCurrency());
            outputToReciept.AppendLine("You earned " + frequentRenterPoints + " frequent renter points");

            return outputToReciept.ToString();
        }

        public int FrequentRenterPoints()
        {
            return Rentals.Sum(rental => rental.RenterPoints());
        }

        private int TotalAmount()
        {
            return Rentals.Sum(rental => rental.Amount());
        }

        public string TotalAmountFormattedAsCurrency()
        {
            return (TotalAmount() / 100).ToString("0.00");
        }
    }
}