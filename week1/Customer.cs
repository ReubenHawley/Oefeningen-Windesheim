namespace week1;

public class Customer: IRepoItem
{


    public int Id { get; set; }
    public string? Name { get; set; }
    public String Adres { get; set; }

    public Customer() {}

    public Customer(int id, string? name, string adres)
    {
        Id = id;
        Name = name;
        Adres = adres;
    }

    public override string ToString()
    {
        return $"{Id}:{Name}";
    }
}