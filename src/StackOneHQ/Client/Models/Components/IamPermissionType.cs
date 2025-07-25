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
    
    public class IamPermissionType
    {

        /// <summary>
        /// The type of the permission, e.g. read, read_write, delete, etc.
        /// </summary>
        [JsonProperty("value")]
        public IamPermissionValue? Value { get; set; } = null;

        [JsonProperty("source_value")]
        public IamPermissionSourceValueUnion? SourceValue { get; set; } = null;
    }
}