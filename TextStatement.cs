using System.Text;

namespace VideoStore;

public class TextStatement
{
    private readonly Customer _customer;

    public TextStatement(Customer customer)
    {
        _customer = customer;
    }

    public string Output()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Rental Record for "+_customer.Name);
        stringBuilder.AppendLine("You owed 0.00");
        stringBuilder.AppendLine("You earned 0 frequent renter points");
        return stringBuilder.ToString();
    }
}