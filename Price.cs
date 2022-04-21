namespace VideoStore;

public abstract class Price
{
    protected int BaseNumberOfRentalDays { private get; init; } = 2;
    protected int BaseRentalAmount { private get; init; } = 200;
    protected  double OverDueMultiplier { private get; init; } = 1.5;
    public int RentalPriceForNumberOfDays(int numberOfDaysRented)
    {
        if (numberOfDaysRented <= BaseNumberOfRentalDays) return BaseRentalAmount;
        return (int)(BaseRentalAmount * OverDueMultiplier);

    }
}

public class RegularPrice : Price
{
    public RegularPrice()
    {
        BaseRentalAmount = 200;
        BaseNumberOfRentalDays = 2;
        OverDueMultiplier = 1.5;
    }
}