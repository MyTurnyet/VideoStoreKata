using System.Collections.Generic;

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
            string result = "Rental Record for " + Name + "\n";

            foreach (Rental rental in Rentals)
            // var enumerator = Rentals.GetEnumerator();
            // while (enumerator.MoveNext())
            {
                double thisAmount = 0;
                Rental each = rental;

                // determines the amount for each line

                // add frequent renter points
                frequentRenterPoints++;

                // add bonus for a two day new release rental
                // if (each.Movie.PriceCode == Movie.NEW_RELEASE && each.DaysRented > 1)
                //     frequentRenterPoints++;

                // show figures for this rental
                // result += "\t" + each.Movie.Title + "\t" + thisAmount.ToString("0.0") + "\n";
                totalAmount += thisAmount;
            }

            // add footer lines
            result += "You owed " + totalAmount.ToString("0.00") + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points";

            return result;
        }
    }
}