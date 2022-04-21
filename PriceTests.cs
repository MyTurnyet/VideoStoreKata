using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class PriceTests
{
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
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForChildrensRentalOfThreeDaysAs150()
    {
        //assign
        Price price = new ChildrensPrice();
        //act
        int numberOfDaysRented = 3;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(150, amount);
    } 
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForChildrensRentalOfFourDaysAs300()
    {
        //assign
        Price price = new ChildrensPrice();
        //act
        int numberOfDaysRented = 4;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(300, amount);
    }
}