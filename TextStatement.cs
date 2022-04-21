using System.Collections.Generic;
using System.Text;

namespace VideoStore;

public class TextStatement : ICustomerStatement
{
    private readonly StringBuilder _stringBuilder= new();

    public string CreateCustomerReceipt(Customer customer)
    {
        AppendHeader(customer);
        WriteLineItems(customer.Rentals);
        AppendFooter(customer);
        return _stringBuilder.ToString();
    }

    private void WriteLineItems(List<Rental> rentals)
    {
        foreach (Rental rental in rentals)
        {
            _stringBuilder.Append($"\t{rental.MovieName()}\t{rental.AmountFormattedAsCurrency()}\r\n");
        }
    }


    private void AppendFooter(Customer customer)
    {
        _stringBuilder.AppendLine($"You owed {customer.TotalAmountFormattedAsCurrency()}");
        _stringBuilder.AppendLine($"You earned {customer.FrequentRenterPoints()} frequent renter points");
    }

    private void AppendHeader(Customer customer) => _stringBuilder.AppendLine("Rental Record for " + customer.Name);
}