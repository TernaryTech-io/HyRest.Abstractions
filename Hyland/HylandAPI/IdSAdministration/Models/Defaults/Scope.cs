namespace HyRest.Hyland.IdentityAdministration;

public struct Scope : IBaseStruct
{
    public static Scope CvatBffApi => new() { Name = "CvatBffApi", Value = "cvat.bff.api" };
    public static Scope CvatClaimsHcfaApi => new() { Name = "CvatClaimsHcfaApi", Value = "cvat.claims-hcfa.api" };
    public static Scope CvatClaimsUb04Api => new() { Name = "CvatClaimsUb04Api", Value = "cvat.claims-ub04.api" };
    public static Scope CvatClientBff => new() { Name = "CvatClientBff", Value = "cvat.client.bff" };
    public static Scope CvatDemographicsApi => new() { Name = "CvatDemographicsApi", Value = "cvat.demographics.api" };
    public static Scope Efm => new() { Name = "Efm", Value = "efm" };
    public static Scope Fpa => new() { Name = "Fpa", Value = "fpa" };
    public static Scope GisConfig => new() { Name = "GisConfig", Value = "gis.config" };
    public static Scope GisUser => new() { Name = "GisUser", Value = "gis.user" };
    public static Scope Group => new() { Name = "Group", Value = "group" };
    public static Scope Hcmisbe => new() { Name = "Hcmisbe", Value = "hcmisbe" };
    public static Scope HcConfigRead => new() { Name = "HConfigRead", Value = "hc.config.read" };
    public static Scope HcConfigWrite => new() { Name = "HcConfigWrite", Value = "hc.config.write" };
    public static Scope HspAccount => new() { Name = "HspAccount", Value = "hsp.account" };
    public static Scope HspAccountDelete => new() { Name = "HspAccountDelete", Value = "hsp.account.delete" };
    public static Scope HspAccountRead => new() { Name = "HspAccountRead", Value = "hsp.account.read" };
    public static Scope HspAccountWrite => new() { Name = "HspAccountWrite", Value = "hsp.account.write" };
    public static Scope HspDocument => new() { Name = "HspDocument", Value = "hsp.document" };
    public static Scope HspDocumentDelete => new() { Name = "HspDocumentDelete", Value = "hsp.document.delete" };
    public static Scope HspDocumentRead => new() { Name = "HspDocumentRead", Value = "hsp.document.read" };
    public static Scope HspDocumentWrite => new() { Name = "HspDocumentWrite", Value = "hsp.document.write" };
    public static Scope HspIndex => new() { Name = "HspIndex", Value = "hsp.index" };
    public static Scope HspIndexDelete => new() { Name = "HspIndexDelete", Value = "hsp.index.delete" };
    public static Scope HspIndexRead => new() { Name = "HspIndexRead", Value = "hsp.index.read" };
    public static Scope HspIndexWrite => new() { Name = "HspIndexWrite", Value = "hsp.index.write" };
    public static Scope HylandFcs => new() { Name = "HylandFcs", Value = "hyland.fcs" };
    public static Scope HylandKeyvault => new() { Name = "HylandKeyvault", Value = "hyland.keyvault" };
    public static Scope IamUserCatalog => new() { Name = "IamUserCatalog", Value = "iam.user-catalog" };
    public static Scope IamUserCatalogRead => new() { Name = "IamUserCatalogRead", Value = "iam.user-catalog.read" };
    public static Scope IamUserCatalogWrite => new() { Name = "IamUserCatalogWrite", Value = "iam.user-catalog.write" };
    public static Scope IdpAdmin => new() { Name = "IdpAdmin", Value = "idpadmin" };
    public static Scope InternalSystem => new() { Name = "InternalSystem", Value = "internal-system" };
    public static Scope Mca => new() { Name = "Mca", Value = "mca" };
    public static Scope NilRead => new() { Name = "NilRead", Value = "nilread" };
    public static Scope OnbaseApi => new() { Name = "OnbaseApi", Value = "onbaseapi" };
    public static Scope OpenId => new() { Name = "OpenId", Value = "openid" };
    public static Scope OfflineAccess => new() { Name = "OfflineAccess", Value = "offline_access" };
    public static Scope Profile => new() { Name = "Profile", Value = "profile" };
    public static Scope ProfileOnbase => new() { Name = "ProfileOnbase", Value = "profile.onbase" };
    public static Scope PswContent => new() { Name = "PswContent", Value = "psw.content" };
    public static Scope PswPreferencesService => new() { Name = "PswPreferencesService", Value = "psw.preferences-service" };
    public static Scope QuantumReferenceLogout => new() { Name = "QuantumReferenceLogout", Value = "quantum.referencelogout" };
    public static Scope Evolution => new() { Name = "Evolution", Value = "evolution" };
    public string Name { get; set; }
    public string Value { get; set; }
    public override string ToString()
    {
        return Value;
    }
    public static Scope? MapByValue(string value) => value switch
    {
        "evolution" => Scope.Evolution,
        "cvat.bff.api" => Scope.CvatBffApi,
        "cvat.claims-hcfa.api" => Scope.CvatClaimsHcfaApi,
        "cvat.claims-ub04.api" => Scope.CvatClaimsUb04Api,
        "cvat.client.bff" => Scope.CvatClientBff,
        "cvat.demographics.api" => Scope.CvatDemographicsApi,
        "efm" => Scope.Efm,
        "fpa" => Scope.Fpa,
        "gis.config" => Scope.GisConfig,
        "gis.user" => Scope.GisUser,
        "group" => Scope.Group,
        "hcmisbe" => Scope.Hcmisbe,
        "hc.config.read" => Scope.HcConfigRead,
        "hc.config.write" => Scope.HcConfigWrite,
        "hsp.account" => Scope.HspAccount,
        "hsp.account.delete" => Scope.HspAccountDelete,
        "hsp.account.read" => Scope.HspAccountRead,
        "hsp.account.write" => Scope.HspAccountWrite,
        "hsp.document" => Scope.HspDocument,
        "hsp.document.delete" => Scope.HspDocumentDelete,
        "hsp.document.read" => Scope.HspDocumentRead,
        "hsp.document.write" => Scope.HspDocumentWrite,
        "hsp.index" => Scope.HspIndex,
        "hsp.index.delete" => Scope.HspIndexDelete,
        "hsp.index.read" => Scope.HspIndexRead,
        "hsp.index.write" => Scope.HspIndexWrite,
        "hyland.fcs" => Scope.HylandFcs,
        "hyland.keyvault" => Scope.HylandKeyvault,
        "iam.user-catalog" => Scope.IamUserCatalog,
        "iam.user-catalog.read" => Scope.IamUserCatalogRead,
        "iam.user-catalog.write" => Scope.IamUserCatalogWrite,
        "idpadmin" => Scope.IdpAdmin,
        "internal-system" => Scope.InternalSystem,
        "mca" => Scope.Mca,
        "nilread" => Scope.NilRead,
        "onbaseapi" => Scope.OnbaseApi,
        "openid" => Scope.OpenId,
        "offline_access" => Scope.OfflineAccess,
        "profile" => Scope.Profile,
        "profile.onbase" => Scope.ProfileOnbase,
        "psw.content" => Scope.PswContent,
        "psw.preferences-service" => Scope.PswPreferencesService,
        "quantum.referencelogout" => Scope.QuantumReferenceLogout,
        _ => null
    };
    static IBaseStruct? IBaseStruct.MapByValue(string value)
        => MapByValue(value);

}

/*
cvat.bff.api
cvat.claims-hcfa.api
cvat.claims-ub04.api
cvat.client.bff
cvat.demographics.api
efm
fpa
gis.config
gis.user
group
hcmisbe
hc.config.read
hc.config.write
hsp.account
hsp.account.delete
hsp.account.read
hsp.account.write
hsp.document
hsp.document.delete
hsp.document.read
hsp.document.write
hsp.index
hsp.index.delete
hsp.index.read
hsp.index.write
hyland.fcs
hyland.keyvault
iam.user-catalog
iam.user-catalog.read
iam.user-catalog.write
idpadmin
internal-system
mca
nilread
onbaseapi
openid
offline_access
profile
profile.onbase
psw.content
psw.preferences-service
quantum.referencelogout
*/