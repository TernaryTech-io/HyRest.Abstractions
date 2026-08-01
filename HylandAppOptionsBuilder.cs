namespace HyRest;

public class HylandOpenIdOptionsBuilder
{
    public required Action<IHylandClientOptions> OptionsAction { get; set; }
}
public class HylandAppOptionsBuilder
{
    public required IAuthenticationCredentials Credentials { get; set; }
    public required Action<IAuthenticationCredentials, IHylandClientOptions> OptionsAction { get; set; }
}

public class HylandScopedAppOptionsBuilder
{
    public required IAuthenticationCredentials Credentials { get; set; }
    public required Action<IAuthenticationCredentials, IHylandClientOptions> OptionsAction { get; set; }
}