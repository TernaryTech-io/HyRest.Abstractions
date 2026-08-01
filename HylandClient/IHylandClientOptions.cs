namespace HyRest;

/// <summary>
/// Configure the API Client's Options
/// </summary>
public interface IHylandClientOptions
{
    string IdsBaseUrl { get; set; }
    string ApiBaseUrl { get; set; }
    bool UseQueryMetering { get; set; }
    string DefaultLanguage { get; set; }
}