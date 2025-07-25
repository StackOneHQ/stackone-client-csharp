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
    
    public class HrisDocumentsUploadRequestDto
    {

        /// <summary>
        /// The filename of the file to upload
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The file format of the file
        /// </summary>
        [JsonProperty("file_format")]
        public HrisDocumentsUploadRequestDtoFileFormat? FileFormat { get; set; } = null;

        /// <summary>
        /// The base64 encoded content of the file to upload
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; } = null;

        /// <summary>
        /// The categoryId of the documents
        /// </summary>
        [JsonProperty("category_id")]
        public string? CategoryId { get; set; } = null;

        /// <summary>
        /// The path for the file to be uploaded to
        /// </summary>
        [JsonProperty("path")]
        public string? Path { get; set; } = null;

        /// <summary>
        /// The confidentiality level of the file to be uploaded
        /// </summary>
        [JsonProperty("confidential")]
        public HrisDocumentsUploadRequestDtoConfidential? Confidential { get; set; } = null;

        /// <summary>
        /// The category to be associated with the file to be uploaded. Id will take precedence over name.
        /// </summary>
        [JsonProperty("category")]
        public HrisDocumentsUploadRequestDtoCategory? Category { get; set; } = null;
    }
}