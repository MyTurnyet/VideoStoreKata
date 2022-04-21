using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Test()
        {
            Customer customer = new Customer{Name = "Bob"};

            customer.Rentals.Add(new Rental { MovieRented = new RegularMovie { Title = "Jaws" }, DaysRented = 2 });
            customer.Rentals.Add(new Rental { MovieRented = new RegularMovie { Title = "GoldenEye" }, DaysRented = 3 });
            customer.Rentals.Add(
                new Rental { MovieRented = new NewReleaseMovie { Title = "ShortNew" }, DaysRented = 1 });
            customer.Rentals.Add(new Rental
                { MovieRented = new NewReleaseMovie { Title = "LongNew" }, DaysRented = 2 });
            customer.Rentals.Add(new Rental { MovieRented = new ChildrensMovie { Title = "Bambi" }, DaysRented = 3 });
            customer.Rentals.Add(
                new Rental { MovieRented = new ChildrensMovie { Title = "Toy Story" }, DaysRented = 4 });
            TextStatement statement = new TextStatement();

            Assert.AreEqual("Rental Record for Bob\r\n" +
                            "\tJaws\t2.00\r\n" +
                            "\tGoldenEye\t3.50\r\n" +
                            "\tShortNew\t3.00\r\n" +
                            "\tLongNew\t6.00\r\n" +
                            "\tBambi\t1.50\r\n" +
                            "\tToy Story\t3.00\r\n" +
                            "You owed 19.00\r\n" +
                            "You earned 7 frequent renter points\r\n", statement.CreateCustomerReceipt(customer));
        }
    }
}