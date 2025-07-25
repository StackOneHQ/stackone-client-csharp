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
    public class SkillsHierarchyValue : IEquatable<SkillsHierarchyValue>
    {
        public static readonly SkillsHierarchyValue Primary = new SkillsHierarchyValue("primary");
        public static readonly SkillsHierarchyValue Secondary = new SkillsHierarchyValue("secondary");
        public static readonly SkillsHierarchyValue Tertiary = new SkillsHierarchyValue("tertiary");
        public static readonly SkillsHierarchyValue UnmappedValue = new SkillsHierarchyValue("unmapped_value");

        private static readonly Dictionary <string, SkillsHierarchyValue> _knownValues =
            new Dictionary <string, SkillsHierarchyValue> ()
            {
                ["primary"] = Primary,
                ["secondary"] = Secondary,
                ["tertiary"] = Tertiary,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, SkillsHierarchyValue> _values =
            new ConcurrentDictionary<string, SkillsHierarchyValue>(_knownValues);

        private SkillsHierarchyValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static SkillsHierarchyValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new SkillsHierarchyValue(value));
        }

        public static implicit operator SkillsHierarchyValue(string value) => Of(value);
        public static implicit operator string(SkillsHierarchyValue skillshierarchyvalue) => skillshierarchyvalue.Value;

        public static SkillsHierarchyValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as SkillsHierarchyValue);

        public bool Equals(SkillsHierarchyValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}