namespace week1;

public class CustomerRepository:Repository
{
    public CustomerRepository()
    {
        items = new List<IRepoItem>();
        Customer customer = new Customer(1,"Reuben","puntkroos 41");
        Customer customer2 = new Customer(2,"Julian","Harderwijkerweg");
        Customer customer3 = new Customer(3,"Wouter","Random straat");
        items.Add(customer);
        items.Add(customer2);
        items.Add(customer3);
    }

    public Customer? GetCustomer(int id)
    {
            return Get().Cast<Customer>().FirstOrDefault(customer => customer.Id == id );
    }
}