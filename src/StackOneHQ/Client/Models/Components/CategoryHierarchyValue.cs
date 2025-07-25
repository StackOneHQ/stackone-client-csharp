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
    public class CategoryHierarchyValue : IEquatable<CategoryHierarchyValue>
    {
        public static readonly CategoryHierarchyValue Primary = new CategoryHierarchyValue("primary");
        public static readonly CategoryHierarchyValue Secondary = new CategoryHierarchyValue("secondary");
        public static readonly CategoryHierarchyValue Tertiary = new CategoryHierarchyValue("tertiary");
        public static readonly CategoryHierarchyValue UnmappedValue = new CategoryHierarchyValue("unmapped_value");

        private static readonly Dictionary <string, CategoryHierarchyValue> _knownValues =
            new Dictionary <string, CategoryHierarchyValue> ()
            {
                ["primary"] = Primary,
                ["secondary"] = Secondary,
                ["tertiary"] = Tertiary,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, CategoryHierarchyValue> _values =
            new ConcurrentDictionary<string, CategoryHierarchyValue>(_knownValues);

        private CategoryHierarchyValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static CategoryHierarchyValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new CategoryHierarchyValue(value));
        }

        public static implicit operator CategoryHierarchyValue(string value) => Of(value);
        public static implicit operator string(CategoryHierarchyValue categoryhierarchyvalue) => categoryhierarchyvalue.Value;

        public static CategoryHierarchyValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as CategoryHierarchyValue);

        public bool Equals(CategoryHierarchyValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}