using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStore
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Test()
        {
            Customer customer = new Customer("Bob");

            customer.Rentals.Add(new Rental(new RegularMovie { Title = "Jaws" }, 2));
            customer.Rentals.Add(new Rental(new RegularMovie { Title = "GoldenEye" }, 3));
            customer.Rentals.Add(new Rental(new Movie { Title = "ShortNew", PriceCode = Movie.NEW_RELEASE }, 1));
            customer.Rentals.Add(new Rental(new Movie { Title = "LongNew", PriceCode = Movie.NEW_RELEASE }, 2));
            customer.Rentals.Add(new Rental(new Movie { Title = "Bambi", PriceCode = Movie.CHILDRENS }, 3));
            customer.Rentals.Add(new Rental(new Movie { Title = "Toy Story", PriceCode = Movie.CHILDRENS }, 4));

            Assert.AreEqual("Rental Record for Bob\n" +
                            "\tJaws\t2.0\n" +
                            "\tGoldenEye\t3.5\n" +
                            "\tShortNew\t3.0\n" +
                            "\tLongNew\t6.0\n" +
                            "\tBambi\t1.5\n" +
                            "\tToy Story\t3.0\n" +
                            "You owed 19.00\n" +
                            "You earned 7 frequent renter points", customer.Statement());
        }
    }
}