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
    using System.Collections.Generic;
    
    public class AtsDocumentApiModel
    {

        /// <summary>
        /// Unique identifier
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier
        /// </summary>
        [JsonProperty("remote_id")]
        public string? RemoteId { get; set; } = null;

        /// <summary>
        /// The name of the file
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The path where the file is stored
        /// </summary>
        [JsonProperty("path")]
        public string? Path { get; set; } = null;

        /// <summary>
        /// The category of the the document
        /// </summary>
        [JsonProperty("category")]
        public AtsDocumentApiModelCategory? Category { get; set; } = null;

        /// <summary>
        /// The content of the file. Deprecated, use `url` and `file_format` one level up instead
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("contents")]
        public List<Models.Components.Content>? Contents { get; set; } = null;

        /// <summary>
        /// The categoryId of the documents
        /// </summary>
        [JsonProperty("category_id")]
        public string? CategoryId { get; set; } = null;

        /// <summary>
        /// The creation date of the file
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// The update date of the file
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// URL where the file content is located
        /// </summary>
        [JsonProperty("remote_url")]
        public string? RemoteUrl { get; set; } = null;

        /// <summary>
        /// The file format of the file
        /// </summary>
        [JsonProperty("file_format")]
        public AtsDocumentApiModelFileFormat? FileFormat { get; set; } = null;

        /// <summary>
        /// Custom Unified Fields configured in your StackOne project
        /// </summary>
        [JsonProperty("unified_custom_fields")]
        public Dictionary<string, object>? UnifiedCustomFields { get; set; } = null;

        /// <summary>
        /// The content type of the document
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("type")]
        public AtsDocumentApiModelType? Type { get; set; } = null;
    }
}