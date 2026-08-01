using System;
namespace HyRest;


/// <summary>
/// Base abstract class for Item Models in the Rest API
/// </summary>
public abstract class OnBaseItem : HylandBase, IOnBaseItem
{
    public virtual string Id { get; set; }
}

/// <summary>
/// Base interface for all model Items, like Document, Keywords, etc.
/// </summary>
public interface IOnBaseItem : IHylandBase
{
    string Id { get; set; }
}