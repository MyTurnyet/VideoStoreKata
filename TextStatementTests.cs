using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class TextStatementTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnStatementWithHeaderAndFooter()
    {
        //assign
        Customer customer = new Customer() { Name = "Mike" };
        TextStatement statement = new TextStatement(customer);
        //act
        string output = statement.Output();
        //assert
        Assert.AreEqual("Rental Record for Mike\r\n" +
                        "You owed 0.00\r\n" +
                        "You earned 0 frequent renter points\r\n", output);
    }
}