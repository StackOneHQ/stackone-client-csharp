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

    [JsonConverter(typeof(OpenEnumConverter))]
    public class LmsCreateAssignmentRequestDtoValue : IEquatable<LmsCreateAssignmentRequestDtoValue>
    {
        public static readonly LmsCreateAssignmentRequestDtoValue Pending = new LmsCreateAssignmentRequestDtoValue("pending");
        public static readonly LmsCreateAssignmentRequestDtoValue InProgress = new LmsCreateAssignmentRequestDtoValue("in_progress");
        public static readonly LmsCreateAssignmentRequestDtoValue Completed = new LmsCreateAssignmentRequestDtoValue("completed");
        public static readonly LmsCreateAssignmentRequestDtoValue UnmappedValue = new LmsCreateAssignmentRequestDtoValue("unmapped_value");

        private static readonly Dictionary <string, LmsCreateAssignmentRequestDtoValue> _knownValues =
            new Dictionary <string, LmsCreateAssignmentRequestDtoValue> ()
            {
                ["pending"] = Pending,
                ["in_progress"] = InProgress,
                ["completed"] = Completed,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, LmsCreateAssignmentRequestDtoValue> _values =
            new ConcurrentDictionary<string, LmsCreateAssignmentRequestDtoValue>(_knownValues);

        private LmsCreateAssignmentRequestDtoValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static LmsCreateAssignmentRequestDtoValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new LmsCreateAssignmentRequestDtoValue(value));
        }

        public static implicit operator LmsCreateAssignmentRequestDtoValue(string value) => Of(value);
        public static implicit operator string(LmsCreateAssignmentRequestDtoValue lmscreateassignmentrequestdtovalue) => lmscreateassignmentrequestdtovalue.Value;

        public static LmsCreateAssignmentRequestDtoValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as LmsCreateAssignmentRequestDtoValue);

        public bool Equals(LmsCreateAssignmentRequestDtoValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}