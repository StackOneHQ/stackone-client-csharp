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
    using StackOneHQ.Client.Models.Requests;
    using StackOneHQ.Client.Utils;
    
    /// <summary>
    /// Filter parameters for application changes (supports created_after and change_type)
    /// </summary>
    public class AtsListApplicationChangesFilter
    {

        /// <summary>
        /// Use a string with a date to only select results created after that given date
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=created_after")]
        public string? CreatedAfter { get; set; } = null;

        /// <summary>
        /// Filter by the type of change that occurred to the application
        /// </summary>
        [SpeakeasyMetadata("queryParam:name=change_type")]
        public Models.Requests.ChangeType? ChangeType { get; set; } = null;
    }
}