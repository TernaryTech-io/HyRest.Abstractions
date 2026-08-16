using Microsoft.Extensions.Logging;

namespace HyRest;

/// <summary>
/// Configure the API Client's Options
/// </summary>
public interface IHylandClientOptions
{
    /// <summary>
    /// The base url of your Hyland Identity server, ex: https://onbase.server.com/IdentityServer
    /// </summary>
    string IdsBaseUrl { get; set; }
    /// <summary>
    /// The base url of your Hyland RestApi server, ex: https://onbase.server.com/ApiServer
    /// </summary>
    string ApiBaseUrl { get; set; }
    /// <summary>
    /// Set to True if using QueryMetering API license, false to use standard concurrent / named licenses
    /// </summary>
    bool UseQueryMetering { get; set; }
    /// <summary>
    /// Set the deafualt language to be used, en-US is default
    /// </summary>
    string DefaultLanguage { get; set; }
    /// <summary>
    /// Sets the API server timeout in seconds.
    /// </summary>
    int RequestTimeOut { get; set; }
}