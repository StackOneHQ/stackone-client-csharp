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
    
    public class ScheduledInterview
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

        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the application
        /// </summary>
        [JsonProperty("remote_application_id")]
        public string? RemoteApplicationId { get; set; } = null;

        [JsonProperty("interview_stage_id")]
        public string? InterviewStageId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the interview stage
        /// </summary>
        [JsonProperty("remote_interview_stage_id")]
        public string? RemoteInterviewStageId { get; set; } = null;

        [JsonProperty("interview_stage")]
        public ScheduledInterviewInterviewStage? InterviewStage { get; set; } = null;

        [JsonProperty("interview_status")]
        public ScheduledInterviewInterviewStatus? InterviewStatus { get; set; } = null;

        [JsonProperty("interviewer_ids")]
        public List<string>? InterviewerIds { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifiers of the interviewers
        /// </summary>
        [JsonProperty("remote_interviewer_ids")]
        public List<string>? RemoteInterviewerIds { get; set; } = null;

        [JsonProperty("interview_parts")]
        public List<InterviewPart>? InterviewParts { get; set; } = null;

        [JsonProperty("interviewers")]
        public List<Interviewer>? Interviewers { get; set; } = null;

        /// <summary>
        /// Interview start date
        /// </summary>
        [JsonProperty("start_at")]
        public DateTime? StartAt { get; set; } = null;

        /// <summary>
        /// Interview end date
        /// </summary>
        [JsonProperty("end_at")]
        public DateTime? EndAt { get; set; } = null;

        [JsonProperty("meeting_url")]
        public string? MeetingUrl { get; set; } = null;

        /// <summary>
        /// Interview created date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// Interview updated date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;
    }
}