using System.Text.Json.Serialization;

namespace HyRest;

/// <summary>
/// The type of lock which is currently locking the document.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentLockStatus
{

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentLock")]
    DocumentLock = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentCheckout")]
    DocumentCheckout = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentCheckoutInSameSession")]
    DocumentCheckoutInSameSession = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"Persistent")]
    Persistent = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"Process")]
    Process = 4,
}

/// <summary>
/// The type of lock to retrieve.
/// <br/>Currently, only keyword locks are supported.
/// </summary>

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LockType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Keywords")]
    Keywords = 0,

}