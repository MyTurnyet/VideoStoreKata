using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class MovieTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountRegularMovieRentedFor2Days_As200()
    {
        //assign
        Movie movie = new RegularMovie { Title = "jaws" };
        int numberOfDaysRented = 2;

        //assert
        Assert.AreEqual(200, movie.Amount(numberOfDaysRented));
        Assert.AreEqual(1, movie.FrequentRenterPoints(numberOfDaysRented));
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountRegularMovieRentedFor3Days_As350()
    {
        //assign
        Movie movie = new RegularMovie { Title = "jaws" };
        int numberOfDaysRented = 3;

        //act
        int amount = movie.Amount(numberOfDaysRented);
        //assert
        Assert.AreEqual(350, amount);
        Assert.AreEqual(1, movie.FrequentRenterPoints(numberOfDaysRented));

    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountNewReleaseMovieRentedFor1Day_As300()
    {
        //assign
        Movie movie = new NewReleaseMovie { Title = "jaws" };
        int numberOfDaysRented = 1;

        //act
        int amount = movie.Amount(numberOfDaysRented);
        //assert
        Assert.AreEqual(1, movie.FrequentRenterPoints(numberOfDaysRented));
        Assert.AreEqual(300, amount);
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountNewReleaseMovieRentedFor2Days_As600()
    {
        //assign
        Movie movie = new NewReleaseMovie { Title = "jaws" };
        int numberOfDaysRented = 2;

        //act
        int amount = movie.Amount(numberOfDaysRented);
        //assert
        Assert.AreEqual(600, amount);
        Assert.AreEqual(2, movie.FrequentRenterPoints(numberOfDaysRented));

    } 
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountChildrensMovieRentedFor3Days_As150()
    {
        //assign
        Movie movie = new ChildrensMovie { Title = "cartoons" };
        int numberOfDaysRented = 3;

        //act
        int amount = movie.Amount(numberOfDaysRented);
        //assert
        Assert.AreEqual(150, amount);
        Assert.AreEqual(1, movie.FrequentRenterPoints(numberOfDaysRented));

    }
    
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountChildrensMovieRentedFor4Days_As300()
    {
        //assign
        Movie movie = new ChildrensMovie { Title = "cartoons" };
        int numberOfDaysRented = 4;

        //act
        int amount = movie.Amount(numberOfDaysRented);
        //assert
        Assert.AreEqual(300, amount);
        Assert.AreEqual(1, movie.FrequentRenterPoints(numberOfDaysRented));
    }

}

