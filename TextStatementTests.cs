using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore;

[TestClass]
public class TextStatementTests
{
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnTextStatementWithHeaderAndFooter()
    {
        //assign
        Customer customer = new Customer { Name = "Mike" };
        ICustomerStatement statement = new TextStatement();
        //act
        string output = statement.CreateCustomerReceipt(customer);
        //assert
        Assert.AreEqual("Rental Record for Mike\r\n" +
                        "You owed 0.00\r\n" +
                        "You earned 0 frequent renter points\r\n", output);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnStatementWithHeaderAndFooterAndRentalInformation()
    {
        //assign
        Customer customer = new Customer { Name = "Mike" };
        customer.Rentals.Add(new Rental { MovieRented = new RegularMovie { Title = "Jaws" }, DaysRented = 2 });

        ICustomerStatement statement = new TextStatement();
        //act
        string output = statement.CreateCustomerReceipt(customer);
        //assert
        Assert.AreEqual("Rental Record for Mike\r\n" +
                        "\tJaws\t2.00\r\n" +
                        "You owed 2.00\r\n" +
                        "You earned 1 frequent renter points\r\n", output);
    }

    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnHTMLStatementWithHeaderAndFooter()
    {
        //assign
        Customer customer = new Customer { Name = "Mike" };
        HtmlStatement statement = new HtmlStatement();
        //act
        string output = statement.CreateCustomerReceipt(customer);
        //assert
        Assert.AreEqual("<h2>Mike</h2>\r\n" +
                        "<br/>You owed 0.00\r\n", output);
    }
    [TestMethod, TestCategory("Unit")]
    public void ShouldReturnHtmlStatementWithHeaderAndFooterAndRentalInformation()
    {
        //assign
        Customer customer = new Customer { Name = "Mike" };
        customer.Rentals.Add(new Rental { MovieRented = new RegularMovie { Title = "Jaws" }, DaysRented = 2 });

        HtmlStatement statement = new HtmlStatement();
        //act
        string output = statement.CreateCustomerReceipt(customer);
        //assert
        Assert.AreEqual("<h2>Mike</h2>\r\n" +
                        "<b>Jaws</b>:2.00\r\n" +
                        "<br/>You owed 2.00\r\n", output);
    }

  
}
