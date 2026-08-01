using System.Text.Json.Serialization;

namespace HyRest.API.Models;

public partial class ProductsModel : HylandBase
{
    /// <summary>
    /// Access to Scanning functionality.
    /// </summary>
    [JsonPropertyName("scanningConfiguration")]
    public bool ScanningConfiguration { get; set; }

    /// <summary>
    /// Access to Exception Report functionality.
    /// </summary>
    [JsonPropertyName("exceptionReportConfiguration")]
    public bool ExceptionReportConfiguration { get; set; }
    /// <summary>
    /// Access to Terminal functionality.
    /// </summary>
    [JsonPropertyName("terminalConfiguration")]
    public bool TerminalConfiguration { get; set; }

    /// <summary>
    /// Access to Physical Records Management.
    /// </summary>
    [JsonPropertyName("physicalRecordsManagement")]
    public bool PhysicalRecordsManagement { get; set; }

    /// <summary>
    /// Access to Document Knowledge Transfer functionality.
    /// </summary>
    [JsonPropertyName("documentKnowledgeTransfer")]
    public bool DocumentKnowledgeTransfer { get; set; }

    /// <summary>
    /// Access to Records Management and Retention functionality.
    /// </summary>
    [JsonPropertyName("recordsManagement")]
    public bool RecordsManagement { get; set; }

    /// <summary>
    /// Access to Medical functionality.
    /// </summary>
    [JsonPropertyName("medicalRecords")]
    public bool MedicalRecords { get; set; }

    /// <summary>
    /// Access to Collaboration Templates functionality.
    /// </summary>
    [JsonPropertyName("collaborationTemplates")]
    public bool CollaborationTemplates { get; set; }

    /// <summary>
    /// Access to Physician Portal configuration.
    /// </summary>
    [JsonPropertyName("med2WebPhysicianPortal")]
    public bool Med2WebPhysicianPortal { get; set; }

    /// <summary>
    /// Access to Patient Portal configuration.
    /// </summary>
    [JsonPropertyName("patientPortal")]
    public bool PatientPortal { get; set; }

    /// <summary>
    /// Access to Field Application functionality.
    /// </summary>
    [JsonPropertyName("fieldApplication")]
    public bool FieldApplication { get; set; }

    /// <summary>
    /// Access to System Folio functionality.
    /// </summary>
    [JsonPropertyName("systemFolio")]
    public bool SystemFolio { get; set; }

    /// <summary>
    /// Access to Report Services functionality.
    /// </summary>
    [JsonPropertyName("reportServices")]
    public bool ReportServices { get; set; }
}

public partial class ProductRightsModel : HylandBase
{

    /// <summary>
    /// Access to the Configuration module.
    /// </summary>
    [JsonPropertyName("configuration")]
    public bool Configuration { get; set; }

    /// <summary>
    /// Access to the System Statistics module.
    /// </summary>
    [JsonPropertyName("databaseManagement")]
    public bool DatabaseManagement { get; set; }

    /// <summary>
    /// Access to the WorkView module.
    /// </summary>
    [JsonPropertyName("workviewConfiguration")]
    public bool WorkviewConfiguration { get; set; }

    /// <summary>
    /// Access to the Test System Creation module.
    /// </summary>
    [JsonPropertyName("testSystemCreation")]
    public bool TestSystemCreation { get; set; }

    /// <summary>
    /// Access to the Change Tracking module.
    /// </summary>
    [JsonPropertyName("changeTracking")]
    public bool ChangeTracking { get; set; }

    /// <summary>
    /// Access to the Environment Value Management module.
    /// </summary>
    [JsonPropertyName("environmentValueManagement")]
    public bool EnvironmentValueManagement { get; set; }
}
public partial class UserUserGroupsConfigRightsModel : HylandBase
{

    /// <summary>
    /// Access to Usergroup configuration.
    /// </summary>
    [JsonPropertyName("usergroupSecurity")]
    public bool UsergroupSecurity { get; set; }

    /// <summary>
    /// Access to Usergroup Configuration Rights configuration.
    /// </summary>
    [JsonPropertyName("configRightSecurity")]
    public bool ConfigRightSecurity { get; set; }

    /// <summary>
    /// Access to Administrative User configuration.
    /// <br/>- "None"
    /// <br/>- "UserAccountAdmin"
    /// <br/>- "UserUpdateAdmin"
    /// <br/>- "PasswordAdmin"
    /// </summary>
    [JsonPropertyName("userConfiguration")]
    public object? UserConfiguration { get; set; }  
}

public partial class ClientBasedProducts : HylandBase
{

    [JsonPropertyName("createListReport")]
    public bool CreateListReport { get; set; } = false;

    [JsonPropertyName("fullTextSearch")]
    public bool FullTextSearch { get; set; } = false;

    [JsonPropertyName("statementRendering")]
    public bool StatementRendering { get; set; } = false;

    [JsonPropertyName("documentDistribution")]
    public bool DocumentDistribution { get; set; } = false;

    [JsonPropertyName("hostApplicationEnabler")]
    public bool HostApplicationEnabler { get; set; } = false;

    [JsonPropertyName("workflow")]
    public bool Workflow { get; set; } = false;

    [JsonPropertyName("workflowRestricted")]
    public bool WorkflowRestricted { get; set; } = false;

    [JsonPropertyName("customerInformation")]
    public bool CustomerInformation { get; set; } = false;

    [JsonPropertyName("workview")]
    public bool Workview { get; set; } = false;

    [JsonPropertyName("timestampDocuments")]
    public bool TimestampDocuments { get; set; } = false;

    [JsonPropertyName("advancedDocumentSplitter")]
    public bool AdvancedDocumentSplitter { get; set; } = false;

    [JsonPropertyName("wordDocumentComposition")]
    public bool WordDocumentComposition { get; set; } = false;

    [JsonPropertyName("sendAdHocCavionNotifications")]
    public bool SendAdHocCavionNotifications { get; set; } = false;

    [JsonPropertyName("documentCompositionAdministration")]
    public bool DocumentCompositionAdministration { get; set; } = false;

    [JsonPropertyName("signaturePadAdministration")]
    public bool SignaturePadAdministration { get; set; } = false;

    [JsonPropertyName("fieldApplication")]
    public bool FieldApplication { get; set; } = false;

    [JsonPropertyName("folio")]
    public bool Folio { get; set; } = false;

    [JsonPropertyName("addModifyCADServicesHotspots")]
    public bool AddModifyCADServicesHotspots { get; set; } = false;

    [JsonPropertyName("hostedSignatureUploading")]
    public bool HostedSignatureUploading { get; set; } = false;

    [JsonPropertyName("hostedSignatureMonitoring")]
    public bool HostedSignatureMonitoring { get; set; } = false;

    [JsonPropertyName("hostedSignatureConfig")]
    public bool HostedSignatureConfig { get; set; } = false;

    [JsonPropertyName("intelligentCaptureAPVerification")]
    public bool IntelligentCaptureAPVerification { get; set; } = false;

    [JsonPropertyName("dynamicAdvancedCapture")]
    public bool DynamicAdvancedCapture { get; set; } = false;

    [JsonPropertyName("interactiveDataCapture")]
    public bool InteractiveDataCapture { get; set; } = false;

    [JsonPropertyName("doDCertifiedRecordsManagement")]
    public bool DoDCertifiedRecordsManagement { get; set; } = false;

    [JsonPropertyName("combinedViewer")]
    public bool CombinedViewer { get; set; } = false;

    [JsonPropertyName("generateCSVFiles")]
    public bool GenerateCSVFiles { get; set; } = false;
}

/* Physical Records Management is slightly different...
public partial class Products
{
    [JsonPropertyName("scanningConfiguration")]
    public bool ScanningConfiguration { get; set; } = false;

    [JsonPropertyName("exceptionReportConfiguration")]
    public bool ExceptionReportConfiguration { get; set; } = false;

    [JsonPropertyName("terminalConfiguration")]
    public bool TerminalConfiguration { get; set; } = false;


    [JsonPropertyName("physicalRecordManagement")]
    public bool PhysicalRecordManagement { get; set; } = false;

    [JsonPropertyName("documentKnowledgeTransfer")]
    public bool DocumentKnowledgeTransfer { get; set; } = false;

    [JsonPropertyName("recordsManagement")]
    public bool RecordsManagement { get; set; } = false;

    [JsonPropertyName("medicalRecords")]
    public bool MedicalRecords { get; set; } = false;

    [JsonPropertyName("collaborationTemplates")]
    public bool CollaborationTemplates { get; set; } = false;

    [JsonPropertyName("fieldApplication")]
    public bool FieldApplication { get; set; } = false;

    [JsonPropertyName("systemFolio")]
    public bool SystemFolio { get; set; } = false;

    [JsonPropertyName("reportServices")]
    public bool ReportServices { get; set; } = false;

    [JsonPropertyName("formsDesigner")]
    public bool FormsDesigner { get; set; } = false;

    [JsonPropertyName("fulltextSearchConfiguration")]
    public bool FulltextSearchConfiguration { get; set; } = false;

    [JsonPropertyName("combinedViewerConfiguration")]
    public bool CombinedViewerConfiguration { get; set; } = false;

    [JsonPropertyName("combinedViewerCombinedViews")]
    public bool CombinedViewerCombinedViews { get; set; } = false;

    [JsonPropertyName("combinedViewerViewTabs")]
    public bool CombinedViewerViewTabs { get; set; } = false;

    [JsonPropertyName("combinedViewerAutoFillKeywordSet")]
    public bool CombinedViewerAutoFillKeywordSet { get; set; } = false;

    [JsonPropertyName("combinedViewerCustomQueryType")]
    public bool CombinedViewerCustomQueryType { get; set; } = false;

    [JsonPropertyName("combinedViewerDocumentType")]
    public bool CombinedViewerDocumentType { get; set; } = false;

    [JsonPropertyName("combinedViewerWorkflowLifecycleQueue")]
    public bool CombinedViewerWorkflowLifecycleQueue { get; set; } = false;

    [JsonPropertyName("combinedViewerWorkViewClassFilter")]
    public bool CombinedViewerWorkViewClassFilter { get; set; } = false;

    [JsonPropertyName("f3Configuration")]
    public bool F3Configuration { get; set; } = false;

    /// <summary>
    /// Workflow Configuration Cycles.
    /// </summary>
    [JsonPropertyName("workflowConfiguration")]
    public ProductsWorkflowConfiguration WorkflowConfiguration { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}
*/