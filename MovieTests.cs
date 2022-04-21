using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class MovieTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountFor2DaysRented_As200()
    {
        //assign
        RegularMovie movie = new RegularMovie { Title = "jaws" };
        int numberOfDaysRented = 2;

        //act
        int amount = movie.Amount(numberOfDaysRented);
        //assert
        Assert.AreEqual(200, amount);
    }
}