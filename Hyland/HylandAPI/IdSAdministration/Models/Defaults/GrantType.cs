using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyRest.Hyland.IdentityAdministration;

public struct GrantType : IBaseStruct
{
    public GrantType(string value)
    {
        var gt = GrantType.MapByValue(value);
        Name = gt.Value.Name;
        Value = gt.Value.Value;
    }
    public override string ToString()
    {
        return Value;
    }
    public static GrantType Implicit => new()
    {
        Name = "Implicit",
        Value = "implicit"
    };
    public static GrantType Hybrid => new()
    {
        Name = "Hybrid",
        Value = "hybrid"
    };
    public static GrantType AddendumExchange => new()
    {
        Name = "AddendumExchange",
        Value = "urn:hyland:params:oauth:grant-type:addendum-exchange"
    };
    public static GrantType TokenExchange => new()
    {
        Name = "TokenExchange",
        Value = "urn:ietf:params:oauth:grant-type:token-exchange"
    };
    public static GrantType JwtBearer => new()
    {
        Name = "JwtBearer",
        Value = "urn:hyland:params:oauth:grant-type:fhir-jwt-bearer"
    };
    public static GrantType DeviceCode => new()
    {
        Name = "DeviceCode",
        Value = "urn:ietf:params:oauth:grant-type:device_code"
    };
    public static GrantType Password => new()
    {
        Name = "Password",
        Value = "password"
    };
    public static GrantType ClientCredentials => new()
    {
        Name = "ClientCredentials",
        Value = "client_credentials"
    };
    public static GrantType AuthorizationCode => new()
    {
        Name = "AuthorizationCode",
        Value = "authorization_code"
    };
    public string Name { get; set; }
    public string Value { get; set; }

    public static GrantType? MapByValue(string value) => value switch
    {
        "authorization_code" => GrantType.AuthorizationCode,
        "client_credentials" => GrantType.ClientCredentials,
        "password" => GrantType.Password,
        "urn:ietf:params:oauth:grant-type:device_code" => GrantType.DeviceCode,
        "urn:hyland:params:oauth:grant-type:fhir-jwt-bearer" => GrantType.JwtBearer,
        "urn:ietf:params:oauth:grant-type:token-exchange" => GrantType.TokenExchange,
        "urn:hyland:params:oauth:grant-type:addendum-exchange" => GrantType.AddendumExchange,
        "hybrid" => GrantType.Hybrid,
        "implicit" => GrantType.Implicit,
        _ => null
    };
    static IBaseStruct? IBaseStruct.MapByValue(string value)
        => MapByValue(value);
}
