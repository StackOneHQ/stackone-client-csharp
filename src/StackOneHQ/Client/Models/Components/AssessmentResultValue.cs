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
    /// The result of the test.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class AssessmentResultValue : IEquatable<AssessmentResultValue>
    {
        public static readonly AssessmentResultValue Cancelled = new AssessmentResultValue("cancelled");
        public static readonly AssessmentResultValue Completed = new AssessmentResultValue("completed");
        public static readonly AssessmentResultValue Expired = new AssessmentResultValue("expired");
        public static readonly AssessmentResultValue Failed = new AssessmentResultValue("failed");
        public static readonly AssessmentResultValue Passed = new AssessmentResultValue("passed");
        public static readonly AssessmentResultValue UnmappedValue = new AssessmentResultValue("unmapped_value");

        private static readonly Dictionary <string, AssessmentResultValue> _knownValues =
            new Dictionary <string, AssessmentResultValue> ()
            {
                ["cancelled"] = Cancelled,
                ["completed"] = Completed,
                ["expired"] = Expired,
                ["failed"] = Failed,
                ["passed"] = Passed,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, AssessmentResultValue> _values =
            new ConcurrentDictionary<string, AssessmentResultValue>(_knownValues);

        private AssessmentResultValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static AssessmentResultValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new AssessmentResultValue(value));
        }

        public static implicit operator AssessmentResultValue(string value) => Of(value);
        public static implicit operator string(AssessmentResultValue assessmentresultvalue) => assessmentresultvalue.Value;

        public static AssessmentResultValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as AssessmentResultValue);

        public bool Equals(AssessmentResultValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}