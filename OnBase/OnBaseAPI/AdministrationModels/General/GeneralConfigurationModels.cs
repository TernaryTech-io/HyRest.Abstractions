using System.Text.Json.Serialization;

namespace HyRest.API.Models;

public partial class GeneralConfigurationModel : HylandBase
{

    [JsonPropertyName("configuration")]
    public bool Configuration { get; set; } = true;

    [JsonPropertyName("databaseManagement")]
    public bool DatabaseManagement { get; set; } = true;

    [JsonPropertyName("workViewConfiguration")]
    public bool WorkViewConfiguration { get; set; } = true;

    [JsonPropertyName("testSystemCreation")]
    public bool TestSystemCreation { get; set; } = true;

    [JsonPropertyName("changeTracking")]
    public bool ChangeTracking { get; set; } = true;

    [JsonPropertyName("environmentValueManagement")]
    public bool EnvironmentValueManagement { get; set; } = true;
}
public partial class GeneralSettingsModel : HylandBase
{

    [JsonPropertyName("diskGroupConfiguration")]
    public bool DiskGroupConfiguration { get; set; } = false;

    [JsonPropertyName("keywordConfiguration")]
    public bool KeywordConfiguration { get; set; } = false;

    [JsonPropertyName("documentConfiguration")]
    public bool DocumentConfiguration { get; set; } = false;

    /// <summary>
    /// Custom Query Configuration Types.
    /// </summary>
    [JsonPropertyName("customQueryConfiguration")]
    public GeneralSettingsCustomQueryConfiguration CustomQueryConfiguration { get; set; }

    [JsonPropertyName("processConfiguration")]
    public bool ProcessConfiguration { get; set; } = false;

    [JsonPropertyName("printingConfiguration")]
    public bool PrintingConfiguration { get; set; } = false;

    [JsonPropertyName("outputConfiguration")]
    public bool OutputConfiguration { get; set; } = false;

    [JsonPropertyName("systemConfiguration")]
    public bool SystemConfiguration { get; set; } = false;

    [JsonPropertyName("translationsConfiguration")]
    public bool TranslationsConfiguration { get; set; } = false;

    [JsonPropertyName("cryptoKeyCustodian")]
    public bool CryptoKeyCustodian { get; set; } = false;

    [JsonPropertyName("cryptoKeyOperator")]
    public bool CryptoKeyOperator { get; set; } = false;  
}

public partial class ConfigurationRightsModel : HylandBase
{
    /// <summary>
    /// Access to Disk Mgmt configuration.
    /// </summary>
    [JsonPropertyName("diskGroupConfiguration")]
    public bool DiskGroupConfiguration { get; set; }

    /// <summary>
    /// Access to Keywords configuration.
    /// </summary>
    [JsonPropertyName("keywordConfiguration")]
    public bool KeywordConfiguration { get; set; }

    /// <summary>
    /// Access to Document configuration.
    /// </summary>
    [JsonPropertyName("documentConfiguration")]
    public bool DocumentConfiguration { get; set; }

    /// <summary>
    /// Access to Custom Queries configuration.
    /// <br/>None: Cannot access Custom Queries.
    /// <br/>Any Custom Query Type: Access to any Custom Query Type.
    /// <br/>Only types that enforce User Group security: Access to the By Keyword and Custom Written SQL Custom Query Types.
    /// </summary>
    [JsonPropertyName("customQueryConfiguration")]
    public ConfigurationRightsCustomQueryConfiguration CustomQueryConfiguration { get; set; }

    /// <summary>
    /// Access to Procssing configuration and Import.
    /// </summary>
    [JsonPropertyName("processConfiguration")]
    public bool ProcessConfiguration { get; set; }

    /// <summary>
    /// Access to Printing configuration.
    /// </summary>
    [JsonPropertyName("printingConfiguration")]
    public bool PrintingConfiguration { get; set; }

    /// <summary>
    /// Access to advanced distribution functionality.
    /// </summary>
    [JsonPropertyName("outputConfiguration")]
    public bool OutputConfiguration { get; set; }

    /// <summary>
    /// Access to some User configuration.
    /// </summary>
    [JsonPropertyName("systemConfiguration")]
    public bool SystemConfiguration { get; set; }

    /// <summary>
    /// Access to Translations configuration.
    /// </summary>
    [JsonPropertyName("translationsConfiguration")]
    public bool TranslationsConfiguration { get; set; }
}