namespace HyRest.Cache;

public interface IOnBaseAppCache
{
    Task<T?> GetOrCreateAsync<T>(string id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseIdentifiable;
    public T? GetOrCreate<T>(string id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseIdentifiable
    {
        var task = GetOrCreateAsync(id, factory, ct);
        task.Wait();
        return task.Result;
    }
    public Task<T?> GetOrCreateAsync<T>(long id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseIdentifiable
        => GetOrCreateAsync(id.ToString(), factory, ct);
    public T? GetOrCreate<T>(long id, Func<CancellationToken, ValueTask<T>> factory, CancellationToken ct = default)
        where T : class, IOnBaseIdentifiable
        => GetOrCreate(id.ToString(), factory, ct);
    Task SetAsync<T>(T item, CancellationToken ct = default)
        where T : class, IOnBaseIdentifiable;
    public void Set<T>(T item,  CancellationToken ct = default) where T : class, IOnBaseIdentifiable
        => SetAsync(item, ct).Wait();
    Task RemoveAsync<T>(T item, CancellationToken ct = default)
        where T : class, IOnBaseIdentifiable;
    public void Remove<T>(T item, CancellationToken ct = default) where T : class, IOnBaseIdentifiable
        => RemoveAsync(item, ct).Wait();
}