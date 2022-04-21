using System;

namespace VideoStore
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        public string Title { get; init; } = String.Empty;
        public int PriceCode { get; init; }
        protected Price Price { get; init; }= new RegularPrice();

        public int Amount(int numberOfDaysRented)
        {
            return Price.RentalPriceForNumberOfDays(numberOfDaysRented);
        }
    }

    class RegularMovie : Movie
    {
        public RegularMovie()
        {
            Price = new RegularPrice();
        }
    }
}