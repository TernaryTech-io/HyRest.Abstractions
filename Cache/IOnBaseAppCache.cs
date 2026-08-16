namespace HyRest.Cache;

public interface IOnBaseAppCache
{
    Task<T?> GetOrCreateAsync<T>(string id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseCacheable;
    public T? GetOrCreate<T>(string id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseCacheable
    {
        var task = GetOrCreateAsync(id, factory, ct);
        task.Wait();
        return task.Result;
    }
    public Task<T?> GetOrCreateAsync<T>(long id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseCacheable
        => GetOrCreateAsync(id.ToString(), factory, ct);
    public T? GetOrCreate<T>(long id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseCacheable
        => GetOrCreate(id.ToString(), factory, ct);
    Task SetAsync<T>(T item, CancellationToken ct = default)
        where T : class, IOnBaseCacheable;
    public void Set<T>(T item,  CancellationToken ct = default) 
        where T : class, IOnBaseCacheable
        => SetAsync(item, ct).Wait();
    Task RemoveAsync<T>(T item, CancellationToken ct = default)
        where T : class, IOnBaseCacheable;
    public void Remove<T>(T item, CancellationToken ct = default) 
        where T : class, IOnBaseCacheable
        => RemoveAsync(item, ct).Wait();
    public bool TryGetValue<T>(string id, out T? result)
        where T : class, IOnBaseCacheable

    {
        bool exists = false;
        result = default;
        var task = TryGetValueAsync<T>(id);
        task.Wait();
        if (task.IsCompletedSuccessfully)
            (exists, result) = task.Result;
        return exists;
    }
    Task<(bool, T?)> TryGetValueAsync<T>(string id, CancellationToken ct = default)
        where T : class, IOnBaseCacheable;
    public bool Exists<T>(string id) where T : class, IOnBaseCacheable
    {
        var task = ExistsAsync<T>(id);
        task.Wait();
        return task.Result;
    }
    Task<bool> ExistsAsync<T>(string id, CancellationToken ct = default)
        where T : class, IOnBaseCacheable;
}