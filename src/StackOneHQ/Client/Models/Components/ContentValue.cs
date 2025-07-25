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
    public class ContentValue : IEquatable<ContentValue>
    {
        public static readonly ContentValue Video = new ContentValue("video");
        public static readonly ContentValue Quiz = new ContentValue("quiz");
        public static readonly ContentValue Document = new ContentValue("document");
        public static readonly ContentValue Audio = new ContentValue("audio");
        public static readonly ContentValue Article = new ContentValue("article");
        public static readonly ContentValue UnmappedValue = new ContentValue("unmapped_value");

        private static readonly Dictionary <string, ContentValue> _knownValues =
            new Dictionary <string, ContentValue> ()
            {
                ["video"] = Video,
                ["quiz"] = Quiz,
                ["document"] = Document,
                ["audio"] = Audio,
                ["article"] = Article,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, ContentValue> _values =
            new ConcurrentDictionary<string, ContentValue>(_knownValues);

        private ContentValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static ContentValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new ContentValue(value));
        }

        public static implicit operator ContentValue(string value) => Of(value);
        public static implicit operator string(ContentValue contentvalue) => contentvalue.Value;

        public static ContentValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as ContentValue);

        public bool Equals(ContentValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}