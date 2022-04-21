﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class PriceTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForBaseRentalOfOneDay_As200()
    {
        //assign
        Price price = new Price { BaseNumberOfRentalDays = 2 };
        //act
        int numberOfDaysRented = 1;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(200, amount);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForBaseRentalOfTwoDays_As200()
    {
        //assign
        Price price = new Price { BaseNumberOfRentalDays = 2 };
        //act
        int numberOfDaysRented = 2;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(200, amount);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnAmountForBaseRentalOfThreeDays_As300()
    {
        //assign
        Price price = new Price { BaseNumberOfRentalDays = 2 };
        //act
        int numberOfDaysRented = 3;
        int amount = price.RentalPriceForNumberOfDays(numberOfDaysRented);

        //assert
        Assert.AreEqual(300, amount);
    }
}

public class Price
{
    public int BaseNumberOfRentalDays { private get; init; } = 2;


    public int RentalPriceForNumberOfDays(int numberOfDaysRented)
    {
        if (numberOfDaysRented > BaseNumberOfRentalDays)
        {
            return (int)(200 * 1.5);
        }

        return 200;
    }
}