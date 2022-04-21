using System.Text;
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
    
    [TestMethod, TestCategory("Unit")]
    public void ShouldWriteValuesToReciept()
    {
        //assign
        Rental rental = new Rental { MovieRented = new RegularMovie { Title = "jaws" }, DaysRented = 2 };
        StringBuilder stringBuilder = new StringBuilder();
        //act
        rental.WriteValuesToReciept(stringBuilder);
        //assert
        Assert.AreEqual("\tjaws\t2.00\r\n", stringBuilder.ToString());
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnCorrectAmountForRegularMovie_OverDue()
    {
        //assign
        Rental rental = new Rental { MovieRented = new RegularMovie { Title = "jaws" }, DaysRented = 3 };

        //assert
        Assert.AreEqual(350, rental.Amount());
        Assert.AreEqual(1, rental.RenterPoints());
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnCorrectAmountForNewReleaseMovie()
    {
        //assign
        Rental rental = new Rental { MovieRented = new NewReleaseMovie{ Title = "jaws" }, DaysRented = 1 };

        //assert
        Assert.AreEqual(300, rental.Amount());
        Assert.AreEqual(1, rental.RenterPoints());
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnCorrectAmountForNewReleaseMovie_OverDue()
    {
        //assign
        Rental rental = new Rental { MovieRented = new NewReleaseMovie { Title = "jaws" }, DaysRented = 3 };

        //assert
        Assert.AreEqual(900, rental.Amount());
        Assert.AreEqual(2, rental.RenterPoints());
    }
    
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnCorrectAmountForChildrensMovie()
    {
        //assign
        Rental rental = new Rental { MovieRented = new ChildrensMovie{ Title = "jaws" }, DaysRented = 3 };

        //assert
        Assert.AreEqual(150, rental.Amount());
        Assert.AreEqual(1, rental.RenterPoints());
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnCorrectAmountForChildrensMovie_OverDue()
    {
        //assign
        Rental rental = new Rental { MovieRented = new ChildrensMovie { Title = "jaws" }, DaysRented = 4 };

        //assert
        Assert.AreEqual(300, rental.Amount());
        Assert.AreEqual(1, rental.RenterPoints());
    }

}