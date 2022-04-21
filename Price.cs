namespace VideoStore;

public abstract class Price
{
    protected int BaseNumberOfRentalDays { private get; init; } = 2;
    protected int BaseRentalAmount { private get; init; } = 200;
    protected double OverDueAmountPerDay { private get; init; } =150;

    public int RentalPriceForNumberOfDays(int numberOfDaysRented)
    {
        if (numberOfDaysRented <= BaseNumberOfRentalDays) return BaseRentalAmount;
        int extraRentalDays = numberOfDaysRented - BaseNumberOfRentalDays;
        return BaseRentalAmount + (int)(extraRentalDays * OverDueAmountPerDay);
    }
}

public class RegularPrice : Price
{
    public RegularPrice()
    {
        BaseRentalAmount = 200;
        BaseNumberOfRentalDays = 2;
        OverDueAmountPerDay = 150;
    }
}

public class NewReleasePrice : Price
{
    public NewReleasePrice()
    {
        BaseRentalAmount = 300;
        BaseNumberOfRentalDays = 1;
        OverDueAmountPerDay = 300;
    }
}