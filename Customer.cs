﻿using System.Collections.Generic;

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

            while (Rentals.GetEnumerator().MoveNext())
            {
                double thisAmount = 0;
                Rental each = Rentals.GetEnumerator().Current;

                // determines the amount for each line
                switch (each.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (each.DaysRented > 2)
                            thisAmount += (each.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += each.DaysRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (each.DaysRented > 3)
                            thisAmount += (each.DaysRented - 3) * 1.5;
                        break;
                }

                // add frequent renter points
                frequentRenterPoints++;

                // add bonus for a two day new release rental
                if (each.Movie.PriceCode == Movie.NEW_RELEASE && each.DaysRented > 1)
                    frequentRenterPoints++;

                // show figures for this rental
                result += "\t" + each.Movie.Title + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            // add footer lines
            result += "You owed " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points";

            return result;
        }
    }
}