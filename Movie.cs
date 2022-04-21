namespace VideoStore
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        public string Title { get; init; }
        public int PriceCode { get; init; } = 0;
        public Price Price { protected get; init; } = new Price();

        public int Amount(int numberOfDaysRented)
        {
            return Price.RentalPriceForNumberOfDays(numberOfDaysRented);
        }
    }

    class RegularMovie : Movie
    {
        public RegularMovie()
        {
            Price = new Price();
        }
    }
}