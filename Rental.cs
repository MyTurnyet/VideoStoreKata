using System.Text;

namespace VideoStore
{
    public class Rental {
        public Movie MovieRented { private get; init; } = new RegularMovie();
        public int DaysRented { private get; init;}

        public int Amount()
        {
            return MovieRented.Amount(DaysRented);
        }

        public int RenterPoints()
        {
            return MovieRented.FrequentRenterPoints(DaysRented);
        }

        public void WriteValuesToReciept(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("\t" + MovieRented.Title + "\t" + AmountAsDouble().ToString("0.00"));
        }

        private double AmountAsDouble()
        {
            return (double)Amount() / 100;
        }
    }
}