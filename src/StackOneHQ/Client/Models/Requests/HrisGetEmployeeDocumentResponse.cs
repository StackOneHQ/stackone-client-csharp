//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace StackOneHQ.Client.Models.Requests
{
    using Newtonsoft.Json;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System.Collections.Generic;
    
    public class HrisGetEmployeeDocumentResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// The document related to the employee with the given identifiers was retrieved.
        /// </summary>
        public HrisDocumentResult? HrisDocumentResult { get; set; }

        public Dictionary<string, List<string>> Headers { get; set; } = default!;
    }
}