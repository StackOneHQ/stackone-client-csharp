//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace StackOneHQ.Client.Models.Errors
{
    using Newtonsoft.Json;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System;
    
    public class PreconditionFailedResponseException : Exception
    {

        /// <summary>
        /// HTTP status code
        /// </summary>
        [JsonProperty("statusCode")]
        public double StatusCode { get; set; } = default!;

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("message")]
        private string? _message { get; set; }
        public override string Message { get {return _message ?? "";} }

        /// <summary>
        /// Timestamp when the error occurred
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } = default!;

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;
    }
}