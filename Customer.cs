using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Customer
    {
        public string Name { get; init; }= String.Empty;
        public List<Rental> Rentals { get; } = new();

       public int FrequentRenterPoints() => Rentals.Sum(rental => rental.RenterPoints());
       private int TotalAmount() => Rentals.Sum(rental => rental.Amount());
       public string TotalAmountFormattedAsCurrency() => (TotalAmount() / 100).ToString("0.00");
    }
}