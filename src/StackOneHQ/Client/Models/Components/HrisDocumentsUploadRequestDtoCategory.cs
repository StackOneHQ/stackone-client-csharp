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
    
    /// <summary>
    /// The category to be associated with the file to be uploaded. Id will take precedence over name.
    /// </summary>
    public class HrisDocumentsUploadRequestDtoCategory
    {

        /// <summary>
        /// The category name to associate with the file
        /// </summary>
        [JsonProperty("value")]
        public HrisDocumentsUploadRequestDtoCategoryValue? Value { get; set; } = null;

        /// <summary>
        /// The provider specific category for associating uploaded files, if provided, the value will be ignored.
        /// </summary>
        [JsonProperty("source_value")]
        public string? SourceValue { get; set; } = null;
    }
}