using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class RentalTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnCorrectAmountForRegularMovie()
    {
        //assign
        Rental rental = new Rental { MovieRented = new RegularMovie { Title = "jaws" }, DaysRented = 2 };

        //assert
        Assert.AreEqual(200, rental.Amount());
        Assert.AreEqual(1, rental.RenterPoints());
    }

}