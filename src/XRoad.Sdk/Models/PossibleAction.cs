using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// an action to change state or edit token, key, cert or csr
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum PossibleAction
{
    [EnumMember(Value = @"DELETE")] DELETE = 0,

    [EnumMember(Value = @"ACTIVATE")] ACTIVATE = 1,

    [EnumMember(Value = @"DISABLE")] DISABLE = 2,

    [EnumMember(Value = @"LOGIN")] LOGIN = 3,

    [EnumMember(Value = @"LOGOUT")] LOGOUT = 4,

    [EnumMember(Value = @"REGISTER")] REGISTER = 5,

    [EnumMember(Value = @"UNREGISTER")] UNREGISTER = 6,

    [EnumMember(Value = @"IMPORT_FROM_TOKEN")]
    IMPORT_FROM_TOKEN = 7,

    [EnumMember(Value = @"GENERATE_KEY")] GENERATE_KEY = 8,

    [EnumMember(Value = @"EDIT_FRIENDLY_NAME")]
    EDIT_FRIENDLY_NAME = 9,

    [EnumMember(Value = @"GENERATE_AUTH_CSR")]
    GENERATE_AUTH_CSR = 10,

    [EnumMember(Value = @"GENERATE_SIGN_CSR")]
    GENERATE_SIGN_CSR = 11,

    [EnumMember(Value = @"TOKEN_CHANGE_PIN")]
    TOKEN_CHANGE_PIN = 12,
}