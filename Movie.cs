using System;

namespace VideoStore
{
    public class Movie
    {
        public string Title { get; init; } = String.Empty;
        protected Price Price { get; init; } = new RegularPrice();
        protected RentalPoints RentalPoints { get; init; } = new();
        public int Amount(int numberOfDaysRented) => Price.RentalPriceForNumberOfDays(numberOfDaysRented);
        public int FrequentRenterPoints(int numberOfDaysRented) => RentalPoints.AmountEarned(numberOfDaysRented);
    }

    public class RegularMovie : Movie
    {
        public RegularMovie()
        {
            Price = new RegularPrice();
            RentalPoints = new RentalPoints();
        }
    }

    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie()
        {
            Price = new NewReleasePrice();
            RentalPoints = new NewReleaseRentalPoints();
        }
    }

    public class ChildrensMovie : Movie
    {
        public ChildrensMovie()
        {
            Price = new ChildrensPrice();
            RentalPoints = new RentalPoints();
        }
    }
}