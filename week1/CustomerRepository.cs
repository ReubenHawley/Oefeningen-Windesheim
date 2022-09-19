namespace week1;

public class CustomerRepository:Repository
{
    public CustomerRepository()
    {
        items = new List<IRepoItem?>();
        Update(new Customer(1,"Reuben","puntkroos 41"));
        Update(new Customer(2,"Julian","Harderwijkerweg"));
        Update(new Customer(3,"Wouter","Random straat"));

    }

    public Customer? GetCustomer(int id)
    {
            return Get().Cast<Customer>().FirstOrDefault(customer => customer.Id == id );
    }
}