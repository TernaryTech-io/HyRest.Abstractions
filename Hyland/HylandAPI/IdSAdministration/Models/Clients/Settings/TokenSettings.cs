using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;
public partial class TokenSettings
{
    [JsonPropertyName("IdentityTokenLifetime")]
    public int IdentityTokenLifetime { get; set; } = 300;

    [JsonPropertyName("AccessTokenLifetime")]
    public int AccessTokenLifetime { get; set; } = 3600;

    [JsonPropertyName("UseAccessTokenLifetimeForUserSystemId")]
    public bool UseAccessTokenLifetimeForUserSystemId { get; set; } = false;

    [JsonPropertyName("AuthorizationCodeLifetime")]
    public int AuthorizationCodeLifetime { get; set; } = 300;

    [JsonPropertyName("AbsoluteRefreshTokenLifetime")]
    public int AbsoluteRefreshTokenLifetime { get; set; } = 2592000;

    [JsonPropertyName("SlidingRefreshTokenLifetime")]
    public int SlidingRefreshTokenLifetime { get; set; } = 1296000;

    [JsonPropertyName("RefreshTokenUsage")]
    [HyRestConverter<JsonNumberEnumConverter<TokenUsage>>]
    public TokenUsage RefreshTokenUsage { get; set; } = TokenUsage._0;

    [JsonPropertyName("UpdateAccessTokenClaimsOnRefresh")]
    public bool UpdateAccessTokenClaimsOnRefresh { get; set; } = false;

    [HyRestConverter<JsonNumberEnumConverter<TokenExpiration>>]
    [JsonPropertyName("RefreshTokenExpiration")]
    public TokenExpiration RefreshTokenExpiration { get; set; } = TokenExpiration._0;

    [HyRestConverter<JsonNumberEnumConverter<AccessTokenType>>]
    [JsonPropertyName("AccessTokenType")]
    public AccessTokenType AccessTokenType { get; set; } = AccessTokenType._0;

    [JsonPropertyName("IncludeJwtId")]
    public bool IncludeJwtId { get; set; } = false;

    [JsonPropertyName("PairWiseSubjectSalt")]
    public string PairWiseSubjectSalt { get; set; }

    [JsonPropertyName("AlwaysIncludeUserClaimsInIdToken")]
    public bool AlwaysIncludeUserClaimsInIdToken { get; set; } = false;
}