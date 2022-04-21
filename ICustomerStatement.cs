namespace VideoStore;

public interface ICustomerStatement
{
    string CreateCustomerReceipt(Customer customer);
}