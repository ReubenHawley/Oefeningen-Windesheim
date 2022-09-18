namespace week1;

public class CustomerRepository:Repository
{
    public CustomerRepository()
    {
        items = new List<IRepoItem>();
        Customer customer = new Customer();
        Customer customer2 = new Customer();
        Customer customer3 = new Customer();
        items.Add(customer);
        items.Add(customer2);
        items.Add(customer3);
    }

    public Customer GetCustomer(int id)
    {
        return (Customer) items[id];
    }
}