using Refit;
using System.Text.Json.Serialization;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{               
    /// <summary>Performs a healthcheck for the REST APIs</summary>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
    /// <exception cref="ApiException">Thrown when the request returns a non-success status code.</exception>
    [Get("/healthcheck")]
    Task Healthcheck();    
}

