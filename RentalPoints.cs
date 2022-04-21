namespace VideoStore;

public class RentalPoints
{
    public virtual int AmountEarned(int numberOfDaysRented)
    {
        return 1;
    }
}

public class NewReleaseRentalPoints : RentalPoints
{
    public override int AmountEarned(int numberOfDaysRented)
    {
        return numberOfDaysRented > 1 ? 2 : 1;
    }
}