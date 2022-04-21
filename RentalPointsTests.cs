using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class RentalPointsTests
{

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturn1PointForRegularRenterPoint()
    {
        //assign
        RentalPoints points = new RentalPoints();
        //act
        int amountEarned = points.AmountEarned(1);
        //assert
        Assert.AreEqual(1,amountEarned );
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnBonusPointsForNewRelease2DayRental_As2()
    {
        //assign
        RentalPoints points = new NewReleaseRentalPoints();
        //act
        int amountEarned = points.AmountEarned(2);
        //assert
        Assert.AreEqual(2,amountEarned );
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnBonusPointsForNewRelease5DayRental_As2()
    {
        //assign
        RentalPoints points = new NewReleaseRentalPoints();
        //act
        int amountEarned = points.AmountEarned(5);
        //assert
        Assert.AreEqual(2,amountEarned );
    }
}

