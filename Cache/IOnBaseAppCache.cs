namespace HyRest.Cache;

public interface IOnBaseAppCache<T> where T : class, IOnBaseIdentifiable
{
    Task<T?> GetOrCreateAsync(string id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default);
    public T? GetOrCreate(string id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
    {
        var task = GetOrCreateAsync(id, factory, ct);
        task.Wait();
        return task.Result;
    }
    public Task<T?> GetOrCreateAsync(long id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        => GetOrCreateAsync(id.ToString(), factory, ct);
    public T? GetOrCreate(long id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
     => GetOrCreate(id.ToString(), factory, ct);
    Task SetAsync(T item, CancellationToken ct = default);
    public void Set(T item,  CancellationToken ct = default)
        => SetAsync(item, ct).Wait();
    Task RemoveAsync(T item, CancellationToken ct = default);
    public void Remove(T item, CancellationToken ct = default)
        => RemoveAsync(item, ct).Wait();
}