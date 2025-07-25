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
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The status of the job postings.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class JobPostingStatusValue : IEquatable<JobPostingStatusValue>
    {
        public static readonly JobPostingStatusValue Live = new JobPostingStatusValue("live");
        public static readonly JobPostingStatusValue Draft = new JobPostingStatusValue("draft");
        public static readonly JobPostingStatusValue Pending = new JobPostingStatusValue("pending");
        public static readonly JobPostingStatusValue Internal = new JobPostingStatusValue("internal");
        public static readonly JobPostingStatusValue Rejected = new JobPostingStatusValue("rejected");
        public static readonly JobPostingStatusValue Closed = new JobPostingStatusValue("closed");
        public static readonly JobPostingStatusValue Archived = new JobPostingStatusValue("archived");
        public static readonly JobPostingStatusValue UnmappedValue = new JobPostingStatusValue("unmapped_value");

        private static readonly Dictionary <string, JobPostingStatusValue> _knownValues =
            new Dictionary <string, JobPostingStatusValue> ()
            {
                ["live"] = Live,
                ["draft"] = Draft,
                ["pending"] = Pending,
                ["internal"] = Internal,
                ["rejected"] = Rejected,
                ["closed"] = Closed,
                ["archived"] = Archived,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, JobPostingStatusValue> _values =
            new ConcurrentDictionary<string, JobPostingStatusValue>(_knownValues);

        private JobPostingStatusValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static JobPostingStatusValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new JobPostingStatusValue(value));
        }

        public static implicit operator JobPostingStatusValue(string value) => Of(value);
        public static implicit operator string(JobPostingStatusValue jobpostingstatusvalue) => jobpostingstatusvalue.Value;

        public static JobPostingStatusValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as JobPostingStatusValue);

        public bool Equals(JobPostingStatusValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}