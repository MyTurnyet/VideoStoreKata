using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class PriceTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForRegularRentalOfOneDay_As200()
    {
        //assign
        Price price = new RegularPrice();
        //act
        int numberOfDaysRented = 1;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(200, amount);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForRegularRentalOfTwoDays_As200()
    {
        //assign
        Price price = new RegularPrice();
        //act
        int numberOfDaysRented = 2;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(200, amount);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForRegularRentalOfThreeDays_As300()
    {
        //assign
        Price price = new RegularPrice();
        //act
        int numberOfDaysRented = 3;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(350, amount);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForNewReleaseRentalOfOneDayAs300()
    {
        //assign
        Price price = new NewReleasePrice();
        //act
        int numberOfDaysRented = 1;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(300, amount);
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForNewReleaseRentalOfTwoDaysAs600()
    {
        //assign
        Price price = new NewReleasePrice();
        //act
        int numberOfDaysRented = 2;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(600, amount);
    }
}