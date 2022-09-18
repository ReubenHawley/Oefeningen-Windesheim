using System.Data;
using System.Dynamic;

namespace week1;

public abstract class Repository
{
    protected List<IRepoItem> items { get; set; }

    public IEnumerable<IRepoItem> Get()
    {
        return items;
    }

    public IRepoItem Get(int id)
    {
        return items[id];
    }

    public void Update(IRepoItem i)
    {
    }
    public void Delete(IRepoItem i)
    {
    }

    public override string ToString()
    {
        return $"{typeof(object).Name}";
    }
}