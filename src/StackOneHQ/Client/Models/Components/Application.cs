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
    
    public class Application
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
        /// Custom Unified Fields configured in your StackOne project
        /// </summary>
        [JsonProperty("unified_custom_fields")]
        public Dictionary<string, object>? UnifiedCustomFields { get; set; } = null;

        /// <summary>
        /// Unique identifier of the candidate
        /// </summary>
        [JsonProperty("candidate_id")]
        public string? CandidateId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the candidate
        /// </summary>
        [JsonProperty("remote_candidate_id")]
        public string? RemoteCandidateId { get; set; } = null;

        /// <summary>
        /// Unique identifier of the job
        /// </summary>
        [JsonProperty("job_id")]
        public string? JobId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the job
        /// </summary>
        [JsonProperty("remote_job_id")]
        public string? RemoteJobId { get; set; } = null;

        [JsonProperty("interview_stage")]
        public ApplicationInterviewStage? InterviewStage { get; set; } = null;

        /// <summary>
        /// Unique identifier of the interview stage
        /// </summary>
        [JsonProperty("interview_stage_id")]
        public string? InterviewStageId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the interview stage
        /// </summary>
        [JsonProperty("remote_interview_stage_id")]
        public string? RemoteInterviewStageId { get; set; } = null;

        [JsonProperty("rejected_reasons")]
        public List<RejectedReason>? RejectedReasons { get; set; } = null;

        /// <summary>
        /// Unique identifiers of the rejection reasons
        /// </summary>
        [JsonProperty("rejected_reason_ids")]
        public List<string>? RejectedReasonIds { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifiers of the rejection reasons
        /// </summary>
        [JsonProperty("remote_rejected_reason_ids")]
        public List<string>? RemoteRejectedReasonIds { get; set; } = null;

        /// <summary>
        /// Date of rejection
        /// </summary>
        [JsonProperty("rejected_at")]
        public DateTime? RejectedAt { get; set; } = null;

        /// <summary>
        /// Unique identifier of the location
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("location_id")]
        public string? LocationId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the location
        /// </summary>
        [JsonProperty("remote_location_id")]
        public string? RemoteLocationId { get; set; } = null;

        /// <summary>
        /// Unique identifiers of the locations
        /// </summary>
        [JsonProperty("location_ids")]
        public List<string>? LocationIds { get; set; } = null;

        /// <summary>
        /// Remote&apos;s unique identifiers of the locations
        /// </summary>
        [JsonProperty("remote_location_ids")]
        public List<string>? RemoteLocationIds { get; set; } = null;

        [JsonProperty("application_status")]
        public ApplicationApplicationStatus? ApplicationStatus { get; set; } = null;

        /// <summary>
        /// Questionnaires associated with the application
        /// </summary>
        [JsonProperty("questionnaires")]
        public List<Questionnaire>? Questionnaires { get; set; } = null;

        [JsonProperty("candidate")]
        public ApplicationCandidate? Candidate { get; set; } = null;

        /// <summary>
        /// Use `documents` expand instead
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("attachments")]
        public List<ApplicationAttachment>? Attachments { get; set; } = null;

        /// <summary>
        /// The documents attached to this application (eg. resume, cover letter etc.)
        /// </summary>
        [JsonProperty("documents")]
        public List<AtsDocumentApiModel>? Documents { get; set; } = null;

        [JsonProperty("result_links")]
        public List<ResultLink>? ResultLinks { get; set; } = null;

        [JsonProperty("source")]
        public ApplicationSource? Source { get; set; } = null;

        /// <summary>
        /// Date of creation
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// Date of last update
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;

        /// <summary>
        /// The application custom fields
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<CustomFields>? CustomFields { get; set; } = null;
    }
}