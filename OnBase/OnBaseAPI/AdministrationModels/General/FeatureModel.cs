using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest.API.Models;

public partial class ClientFeaturesModel : HylandBase
{
    [JsonPropertyName("retrieveDialog")]
    public bool RetrieveDialog { get; set; } = false;

    [JsonPropertyName("import")]
    public bool Import { get; set; } = false;

    [JsonPropertyName("documentProperties")]
    public bool DocumentProperties { get; set; } = false;

    [JsonPropertyName("userWorkstationOptions")]
    public bool UserWorkstationOptions { get; set; } = false;

    [JsonPropertyName("enableMarkupToolbar")]
    public bool EnableMarkupToolbar { get; set; } = false;

    [JsonPropertyName("thumbnailHitlistResultsViewer")]
    public bool ThumbnailHitlistResultsViewer { get; set; } = false;

    [JsonPropertyName("toolbarConfiguration")]
    public bool ToolbarConfiguration { get; set; } = false;

    [JsonPropertyName("externalTextSearch")]
    public bool ExternalTextSearch { get; set; } = false;

    [JsonPropertyName("folderProperties")]
    public bool FolderProperties { get; set; } = false;

    [JsonPropertyName("personalPageConfiguration")]
    public bool PersonalPageConfiguration { get; set; } = true;

    [JsonPropertyName("templateForPersonalPages")]
    public bool TemplateForPersonalPages { get; set; } = false;

    [JsonPropertyName("envelopes")]
    public bool Envelopes { get; set; } = false;

    [JsonPropertyName("envelopeSharing")]
    public bool EnvelopeSharing { get; set; } = false;

    [JsonPropertyName("onDemandDiagnostics")]
    public bool OnDemandDiagnostics { get; set; } = false;

    [JsonPropertyName("userDefinedCustomQueries")]
    public bool UserDefinedCustomQueries { get; set; } = false;

    [JsonPropertyName("documentRetentionExclusion")]
    public bool DocumentRetentionExclusion { get; set; } = false;

    [JsonPropertyName("documentRetentionRemoveExclusion")]
    public bool DocumentRetentionRemoveExclusion { get; set; } = false;

    [JsonPropertyName("accessSecurityMaskedKeywords")]
    public bool AccessSecurityMaskedKeywords { get; set; } = false;

    [JsonPropertyName("documentPackaging")]
    public bool DocumentPackaging { get; set; } = false;

    [JsonPropertyName("mediaStreaming")]
    public bool MediaStreaming { get; set; } = false;

    [JsonPropertyName("signWithSignaturePad")]
    public bool SignWithSignaturePad { get; set; } = false;

}