namespace HyRest.Hyland.IdentityAdministration;

public partial class CreateModifyClient
{    
    /// <summary>
    /// Requires RedirectURL to App Server
    /// </summary>
    public static CreateModifyClient BarcodeGenerator => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = ["http://127.0.0.1"],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.OnbaseApi.Value],
        },
        PkceSettings = new PkceSettings()
        {
            RequirePkce = true,
        },
    };
    /// <summary>
    /// Requires RedirectURL to App Server, Client Secret
    /// </summary>
    public static CreateModifyClient DisconnectedScanning => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.OnbaseApi.Value, Scope.OfflineAccess.Value],
            AllowOfflineAccess = true,
        },
        PkceSettings = new PkceSettings()
        {
            RequirePkce = true,
        },
    };
    /// <summary>
    /// Requires no additional configuration
    /// </summary>
    public static CreateModifyClient DesktopHost => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = ["http://127.0.0.1"],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.OfflineAccess.Value],
            AllowOfflineAccess = true,
            AllowAccessTokensViaBrowser = true,
            EnableLocalLogin = true,

        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = ["http://127.0.0.1"],
            FrontChannelLogoutSessionRequired = true,
            BackChannelLogoutSessionRequired = true,            
        },
        TokenSettings = new TokenSettings()
        {
            AlwaysIncludeUserClaimsInIdToken = true,
            RefreshTokenUsage = TokenUsage._1
        }
    };
    /// <summary>
    /// Requires RedirectURL, PostLogoutURL, and a Client Secret
    /// </summary>
    public static CreateModifyClient OpenIdRestAPI => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [ GrantType.AuthorizationCode.Value ],
            AllowedScopes = [ Scope.OpenId.Value, Scope.Profile.Value, Scope.ProfileOnbase.Value, Scope.Evolution.Value, Scope.OnbaseApi.Value, Scope.OfflineAccess.Value ],
            AllowOfflineAccess = true,
            AllowAccessTokensViaBrowser = true,
            EnableLocalLogin = true,
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        },
        TokenSettings = new TokenSettings()
        {
            AlwaysIncludeUserClaimsInIdToken = true,
        }
    };
    /// <summary>
    /// A Basic Authentication REST API Client. Must add a Client Secret
    /// </summary>
    public static CreateModifyClient RestAPI => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.Password.Value],
            AllowedScopes = [Scope.OpenId.Value]
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        }
    };
    /// <summary>
    /// Requires a Client Secret and a Redirect URI
    /// </summary>
    public static CreateModifyClient AdminPortal => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.Evolution.Value ],
            AllowAccessTokensViaBrowser = true
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        }
    };
    /// <summary>
    /// IdS Client for Web Client. Must add Redirect URIs, Post Logout URIs, and a Client Secret
    /// </summary>
    public static CreateModifyClient WebClient => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value]            
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        }
    };
    /// <summary>
    /// Requires RedirectURL
    /// </summary>
    public static CreateModifyClient AdobeSign => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.ClientCredentials.Value, GrantType.Password.Value],
            AllowedScopes = [Scope.Evolution.Value],
        },        
    };
    /// <summary>
    /// Requires RedirectURL, PostLogoutURLs, Clien Secret
    /// </summary>
    public static CreateModifyClient EpicClient => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.TokenExchange.Value, GrantType.AddendumExchange.Value],
            AllowedScopes = [Scope.OpenId.Value],
            EnableLocalLogin = true,           
            
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
            FrontChannelLogoutSessionRequired = true,
            BackChannelLogoutSessionRequired = true,
        },
        SecuritySettings = new SecuritySettings()
        {
            AllowedCorsOrigins = [],            
        },
        PkceSettings = new PkceSettings()
        {
            RequirePkce = true,
        },
        TokenSettings = new TokenSettings()
        {
            AccessTokenType = AccessTokenType._0,
            AlwaysIncludeUserClaimsInIdToken = true,
        }
    };
    /// <summary>
    /// Requires RedirectURL, Client Secret, Cors Origin
    /// </summary>
    public static CreateModifyClient GovernanceRules => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.OnbaseApi.Value, Scope.OfflineAccess.Value],
            AllowOfflineAccess = true
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        },
        SecuritySettings = new SecuritySettings()
        {
            AllowedCorsOrigins = [],
        },
        PkceSettings = new PkceSettings()
        {
            RequirePkce = true,
        },
    };
    /// <summary>
    /// Requires RedirectURL to App Server, Client Secret
    /// </summary>
    public static CreateModifyClient FrontOfficeScanning => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.OnbaseApi.Value, Scope.OfflineAccess.Value],
            AllowOfflineAccess = true
        },
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true
        },
        PkceSettings = new PkceSettings()
        {
            RequirePkce = true,
        },
    };
    /// <summary>
    /// Requires RedirectURL to App Server, Client Secret
    /// </summary>
    public static CreateModifyClient ExpressScanning => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.OnbaseApi.Value, Scope.OfflineAccess.Value],
            AllowOfflineAccess = true
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
        },
    };    
    /// <summary>
    /// Requires RedirectURLS, PostLogOutURLs, Client Secret
    /// </summary>
    public static CreateModifyClient ExternalAccessClient => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value, GrantType.Password.Value],
            AllowedScopes = [Scope.OpenId.Value, Scope.Profile.Value, Scope.Evolution.Value]
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
        },
    };
    /// <summary>
    /// Requires RedirectURLS, PostLogOutURLs
    /// </summary>
    public static CreateModifyClient EVM => _basicClientTemplate;
    /// <summary>
    /// Requires RedirectURL to App Server, PostLogOutURL to AppServer
    /// </summary>
    public static CreateModifyClient Agenda => _basicClientTemplate;
    /// <summary>
    /// Requires RedirectURL to App Server, PostLogOutURL to AppServer
    /// </summary>
    public static CreateModifyClient UnityClient => _basicClientTemplate;
    /// <summary>
    /// Requires RedirectURL to App Server, PostLogOutURL to AppServer
    /// </summary>
    public static CreateModifyClient OfficeIntegration => _basicClientTemplate;
    /// <summary>
    /// Requires RedirectURL to App Server, PostLogOutURL to AppServer
    /// </summary>
    public static CreateModifyClient OnBaseStudio => _basicClientTemplate;
    /// <summary>
    /// Requires RedirectURL to App Server, PostLogOutURL to AppServer
    /// </summary>
    public static CreateModifyClient ManagementConsole => _basicClientTemplate;
    private static CreateModifyClient _basicClientTemplate => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = [],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value],
            AllowedScopes = [Scope.OpenId.Value]
        },
        PkceSettings = new PkceSettings()
        {
            RequirePkce = true,
        },
        LogoutSettings = new LogoutSettings()
        {
            PostLogoutRedirectUris = [],
        }
    };

    /// <summary>
    /// Requires a ClientSecret
    /// </summary>
    public static CreateModifyClient OnBaseClient => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = ["http://localhost"],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value, GrantType.Password.Value ],
            AllowedScopes = [Scope.OpenId.Value],
            EnableLocalLogin = true,
        },
        
        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true,            
        }
    };
    /// <summary>
    /// Requires a ClientSecret
    /// </summary>
    public static CreateModifyClient OnBaseConfiguration => new CreateModifyClient()
    {
        ProtocolType = "oidc",
        RedirectUris = ["http://localhost"],
        AuthenticationRestrictionSettings = new AuthenticationRestrictionSettings()
        {
            AllowedGrantTypes = [GrantType.AuthorizationCode.Value, GrantType.Password.Value],
            AllowedScopes = [Scope.OpenId.Value],
            EnableLocalLogin = true,
        },

        SecretSettings = new SecretSettingsModel()
        {
            RequireClientSecret = true,
        }
    };

}
