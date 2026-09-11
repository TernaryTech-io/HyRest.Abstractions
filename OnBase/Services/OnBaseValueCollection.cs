using System.Collections;

namespace HyRest.OnBase;

public abstract class ValueCollection<TItem,TModel> : IReadOnlyCollection<TItem>
{
    protected object _lock = new object();
    protected readonly List<TModel> _modelItems;
    protected List<TItem> _items => GetItems();
    protected abstract List<TItem> GetItems();
    protected abstract TModel ToModel(TItem item);
    protected abstract TItem FromModel(TModel model);
    protected ValueCollection(IEnumerable<TModel> values)
    {
        _modelItems = values.ToList();
    }
    public int Count => _items.Count;
    public TItem? ElementAtOrDefault(int index)
    {
        lock(_lock)
        {
            return _items.ElementAtOrDefault(index);
        }        
    }
    public TItem ElementAt(int index)
    {
        lock (_lock)
        {
            return _items.ElementAt(index);
        }
    }
    public TItem? FirstOrDefault(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.FirstOrDefault(predicate);
        }
    }
    public TItem First(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.First(predicate);
        }
    }
    public TItem Last(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.Last(predicate);
        }
    }
    public TItem? LastOrDefault(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.LastOrDefault(predicate);
        }
    }
    public bool All(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.All(predicate);
        }
    }
    public bool Any(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.Any(predicate);
        }
    }
    public IEnumerable<TItem> Where(Func<TItem, bool> predicate)
    {
        lock (_lock)
        {
            return _items.Where(predicate);
        }
    }
    public List<TItem> ToList()
    {
        lock (_lock)
        {
            return _items.ToList();
        }
    }
    public void Sort(Comparison<TItem> comparison)
    {
        lock (_lock)
        {
            _items.Sort(comparison);
        }
    }
    public IEnumerable<IGrouping<TKey, TItem>> GroupBy<TKey>(Func<TItem, TKey> selector)
    {
        lock (_lock)
        {
            return _items.GroupBy(selector);
        }
    }
    public IEnumerable<TItem> DistinctBy<TKey>(Func<TItem, TKey> selector)
    {
        lock (_lock)
        {
            return _items.DistinctBy(selector);
        }

    }
    public TItem[] ToArray()
    {
        lock (_lock)
        {
            return _items.ToArray();
        }
    }
    public IEnumerator<TItem> GetEnumerator()
        => _items.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()
    => GetEnumerator();
}

