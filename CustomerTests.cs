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

            customer.Rentals.Add(new Rental { MovieRented = new RegularMovie { Title = "Jaws" }, DaysRented = 2 });
            customer.Rentals.Add(new Rental { MovieRented = new RegularMovie { Title = "GoldenEye" }, DaysRented = 3 });
            customer.Rentals.Add(
                new Rental { MovieRented = new NewReleaseMovie { Title = "ShortNew" }, DaysRented = 1 });
            customer.Rentals.Add(new Rental
                { MovieRented = new NewReleaseMovie { Title = "LongNew" }, DaysRented = 2 });
            customer.Rentals.Add(new Rental { MovieRented = new ChildrensMovie { Title = "Bambi" }, DaysRented = 3 });
            customer.Rentals.Add(
                new Rental { MovieRented = new ChildrensMovie { Title = "Toy Story" }, DaysRented = 4 });

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