using System.Data;
using System.Dynamic;

namespace week1;

public abstract class Repository
{
    protected List<IRepoItem?> items { get; set; }

    public IEnumerable<IRepoItem?> Get()
    {
        return items;
    }

    public IRepoItem? Get(int id)
    {
        return items.FirstOrDefault(item => item != null && item.Id == id);
    }

    public void Update(IRepoItem? i)
    {
        items.Add(i);
    }
    public void Delete(IRepoItem? i)
    {
        items.Remove(i);
    }

    public override string ToString()
    {
        return $"{typeof(object).Name}";
    }
}