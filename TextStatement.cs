using System.Collections.Generic;
using System.Text;

namespace VideoStore;

public interface ICustomerStatement
{
    string CreateCustomerReceipt(Customer customer);
}

public class TextStatement : ICustomerStatement
{
    private readonly StringBuilder _stringBuilder= new StringBuilder();


    public string CreateCustomerReceipt(Customer customer)
    {
        AppendHeader(customer);
        WriteLineItems(customer.Rentals);
        AppendFooter(customer);
        return _stringBuilder.ToString();
    }

    private void WriteLineItems(List<Rental> rentals)
    {
        string outputFormat = "\t{0}\t{1}\r\n";
        foreach (Rental rental in rentals)
        {
            _stringBuilder.AppendFormat(outputFormat, rental.MovieName(), rental.AmountFormattedAsCurrency());
        }
    }


    private void AppendFooter(Customer customer)
    {
        _stringBuilder.AppendLine($"You owed {customer.TotalAmountFormattedAsCurrency()}");
        _stringBuilder.AppendLine($"You earned {customer.FrequentRenterPoints()} frequent renter points");
    }

    private void AppendHeader(Customer customer)
    {
        _stringBuilder.AppendLine("Rental Record for " + customer.Name);
    }
}

public class HtmlStatement : ICustomerStatement
{
    private readonly StringBuilder _stringBuilder = new StringBuilder();

    public string CreateCustomerReceipt(Customer customer)
    {
        AppendHeader(customer);
        WriteLineItems(customer.Rentals);
        AppendFooter(customer);
        return _stringBuilder.ToString();
    }

    private void WriteLineItems(List<Rental> rentals)
    {
        string outputFormat = "<b>{0}</b>: {1}\r\n";
        foreach (Rental rental in rentals)
        {
            _stringBuilder.AppendFormat(outputFormat, rental.MovieName(), rental.AmountFormattedAsCurrency());
        }
    }

    private void AppendFooter(Customer customer)
    {
        _stringBuilder.AppendLine("<br/>You owe " + customer.TotalAmountFormattedAsCurrency());
    }

    private void AppendHeader(Customer customer)
    {
        _stringBuilder.AppendLine("<h2>" + customer.Name + "</h2>");
    }
}