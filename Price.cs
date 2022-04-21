namespace VideoStore;

public class Price
{
    public int BaseNumberOfRentalDays { private get; init; } = 2;
    public int BaseRentalAmount { private get; init; } = 200;
    public double OverDueMultiplier { private get; init; } = 1.5;
    public int RentalPriceForNumberOfDays(int numberOfDaysRented)
    {
        if (numberOfDaysRented <= BaseNumberOfRentalDays) return BaseRentalAmount;
        return (int)(BaseRentalAmount * OverDueMultiplier);

    }
}