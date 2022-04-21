namespace VideoStore;

public abstract class Price
{
    protected int BaseNumberOfRentalDays { private get; init; }
    protected int BaseRentalAmount { private get; init; }
    protected double OverDueAmountPerDay { private get; init; }

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
public class ChildrensPrice : Price
{
    public ChildrensPrice()
    {
        BaseRentalAmount = 150;
        BaseNumberOfRentalDays = 3;
        OverDueAmountPerDay = 150;
    }
}