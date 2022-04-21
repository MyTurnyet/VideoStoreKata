namespace VideoStore
{
    public class Rental {
        public Movie MovieRented { private get; init; }
        public int DaysRented { private get; init;}

        public int Amount()
        {
            return MovieRented.Amount(DaysRented);
        }

        public int RenterPoints()
        {
            return 1;
        }
    }
}