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
    /// The type of change that occurred to the application
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class ApplicationChangesValue : IEquatable<ApplicationChangesValue>
    {
        public static readonly ApplicationChangesValue ApplicationStatus = new ApplicationChangesValue("application_status");
        public static readonly ApplicationChangesValue InterviewStage = new ApplicationChangesValue("interview_stage");
        public static readonly ApplicationChangesValue RejectedReasons = new ApplicationChangesValue("rejected_reasons");
        public static readonly ApplicationChangesValue UnmappedValue = new ApplicationChangesValue("unmapped_value");

        private static readonly Dictionary <string, ApplicationChangesValue> _knownValues =
            new Dictionary <string, ApplicationChangesValue> ()
            {
                ["application_status"] = ApplicationStatus,
                ["interview_stage"] = InterviewStage,
                ["rejected_reasons"] = RejectedReasons,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, ApplicationChangesValue> _values =
            new ConcurrentDictionary<string, ApplicationChangesValue>(_knownValues);

        private ApplicationChangesValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static ApplicationChangesValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new ApplicationChangesValue(value));
        }

        public static implicit operator ApplicationChangesValue(string value) => Of(value);
        public static implicit operator string(ApplicationChangesValue applicationchangesvalue) => applicationchangesvalue.Value;

        public static ApplicationChangesValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as ApplicationChangesValue);

        public bool Equals(ApplicationChangesValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}