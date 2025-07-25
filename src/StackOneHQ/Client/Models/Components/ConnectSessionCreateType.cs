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
    /// The connect session account type
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class ConnectSessionCreateType : IEquatable<ConnectSessionCreateType>
    {
        public static readonly ConnectSessionCreateType Production = new ConnectSessionCreateType("production");
        public static readonly ConnectSessionCreateType Test = new ConnectSessionCreateType("test");

        private static readonly Dictionary <string, ConnectSessionCreateType> _knownValues =
            new Dictionary <string, ConnectSessionCreateType> ()
            {
                ["production"] = Production,
                ["test"] = Test
            };

        private static readonly ConcurrentDictionary<string, ConnectSessionCreateType> _values =
            new ConcurrentDictionary<string, ConnectSessionCreateType>(_knownValues);

        private ConnectSessionCreateType(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static ConnectSessionCreateType Of(string value)
        {
            return _values.GetOrAdd(value, _ => new ConnectSessionCreateType(value));
        }

        public static implicit operator ConnectSessionCreateType(string value) => Of(value);
        public static implicit operator string(ConnectSessionCreateType connectsessioncreatetype) => connectsessioncreatetype.Value;

        public static ConnectSessionCreateType[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as ConnectSessionCreateType);

        public bool Equals(ConnectSessionCreateType? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}