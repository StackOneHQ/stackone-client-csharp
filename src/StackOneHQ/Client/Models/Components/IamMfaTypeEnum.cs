//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace StackOneHQ.Client.Models.Components
{
    using Newtonsoft.Json;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    
    public class IamMfaTypeEnum
    {

        /// <summary>
        /// The unified value for the type of multi-factor authentication. If the provider does not send back a type but does specify that MFA is set-up for this user, the value will be set to &apos;unknown&apos;.&apos;
        /// </summary>
        [JsonProperty("value")]
        public IamMfaTypeEnumValue? Value { get; set; } = null;

        [JsonProperty("source_value")]
        public IamMfaTypeEnumSourceValueUnion? SourceValue { get; set; } = null;
    }
}