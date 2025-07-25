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
    /// The priority of the ticket.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class TicketingTicketUpdateRequestDtoPriorityValue : IEquatable<TicketingTicketUpdateRequestDtoPriorityValue>
    {
        public static readonly TicketingTicketUpdateRequestDtoPriorityValue Lowest = new TicketingTicketUpdateRequestDtoPriorityValue("lowest");
        public static readonly TicketingTicketUpdateRequestDtoPriorityValue Low = new TicketingTicketUpdateRequestDtoPriorityValue("low");
        public static readonly TicketingTicketUpdateRequestDtoPriorityValue Medium = new TicketingTicketUpdateRequestDtoPriorityValue("medium");
        public static readonly TicketingTicketUpdateRequestDtoPriorityValue High = new TicketingTicketUpdateRequestDtoPriorityValue("high");
        public static readonly TicketingTicketUpdateRequestDtoPriorityValue Highest = new TicketingTicketUpdateRequestDtoPriorityValue("highest");
        public static readonly TicketingTicketUpdateRequestDtoPriorityValue UnmappedValue = new TicketingTicketUpdateRequestDtoPriorityValue("unmapped_value");

        private static readonly Dictionary <string, TicketingTicketUpdateRequestDtoPriorityValue> _knownValues =
            new Dictionary <string, TicketingTicketUpdateRequestDtoPriorityValue> ()
            {
                ["lowest"] = Lowest,
                ["low"] = Low,
                ["medium"] = Medium,
                ["high"] = High,
                ["highest"] = Highest,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, TicketingTicketUpdateRequestDtoPriorityValue> _values =
            new ConcurrentDictionary<string, TicketingTicketUpdateRequestDtoPriorityValue>(_knownValues);

        private TicketingTicketUpdateRequestDtoPriorityValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static TicketingTicketUpdateRequestDtoPriorityValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new TicketingTicketUpdateRequestDtoPriorityValue(value));
        }

        public static implicit operator TicketingTicketUpdateRequestDtoPriorityValue(string value) => Of(value);
        public static implicit operator string(TicketingTicketUpdateRequestDtoPriorityValue ticketingticketupdaterequestdtopriorityvalue) => ticketingticketupdaterequestdtopriorityvalue.Value;

        public static TicketingTicketUpdateRequestDtoPriorityValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as TicketingTicketUpdateRequestDtoPriorityValue);

        public bool Equals(TicketingTicketUpdateRequestDtoPriorityValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}