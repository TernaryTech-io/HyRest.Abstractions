using Refit;
using HyRest.Cache;

namespace HyRest;

/// <summary>
/// Represents the base interface for all of Hyland Rest API's, OnBase or otherwise.
/// </summary>
public interface IHylandRestAPI
{    
    static TApi Get<TApi>(HttpClient client, RefitSettings? settings) => RestService.ForGenerated<TApi>(client, settings);
}












