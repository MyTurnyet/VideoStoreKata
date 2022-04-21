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
            stringBuilder.AppendLine("\t" + MovieRented.Title + "\t" + AmountFormattedAsCurrency());
        }

        public string AmountFormattedAsCurrency()
        {
            return ((double)Amount() / 100).ToString("0.00");
        }

        public string MovieName()
        {
            return MovieRented.Title;
        }
    }
}