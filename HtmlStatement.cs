using System.Collections.Generic;
using System.Text;

namespace VideoStore;

public class HtmlStatement : ICustomerStatement
{
    private readonly StringBuilder _stringBuilder = new();

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
            _stringBuilder.AppendFormat("<b>{0}</b>:{1}\r\n", rental.MovieName(), rental.AmountFormattedAsCurrency());
        }
    }

    private void AppendFooter(Customer customer) => _stringBuilder.AppendLine("<br/>You owed " + customer.TotalAmountFormattedAsCurrency());
    private void AppendHeader(Customer customer) => _stringBuilder.AppendLine("<h2>" + customer.Name + "</h2>");
}