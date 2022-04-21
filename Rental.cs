using System.Text;

namespace VideoStore
{
    public class Rental {
        public Movie MovieRented { private get; init; } = new RegularMovie();
        public int DaysRented { private get; init;}

        public int Amount() => MovieRented.Amount(DaysRented);
        public int RenterPoints() => MovieRented.FrequentRenterPoints(DaysRented);
        public void WriteValuesToReciept(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("\t" + MovieRented.Title + "\t" + AmountFormattedAsCurrency());
        }
        public string AmountFormattedAsCurrency() => ((double)Amount() / 100).ToString("0.00");
        public string MovieName() => MovieRented.Title;
    }
}