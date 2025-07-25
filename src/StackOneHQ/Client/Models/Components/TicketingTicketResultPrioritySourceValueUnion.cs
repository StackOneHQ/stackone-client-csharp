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
    using Newtonsoft.Json.Linq;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class TicketingTicketResultPrioritySourceValueUnionType
    {
        private TicketingTicketResultPrioritySourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static TicketingTicketResultPrioritySourceValueUnionType Str { get { return new TicketingTicketResultPrioritySourceValueUnionType("str"); } }
        
        public static TicketingTicketResultPrioritySourceValueUnionType Number { get { return new TicketingTicketResultPrioritySourceValueUnionType("number"); } }
        
        public static TicketingTicketResultPrioritySourceValueUnionType Boolean { get { return new TicketingTicketResultPrioritySourceValueUnionType("boolean"); } }
        
        public static TicketingTicketResultPrioritySourceValueUnionType TicketingTicketResultSourceValuePriority { get { return new TicketingTicketResultPrioritySourceValueUnionType("TicketingTicketResult_source_value_priority"); } }
        
        public static TicketingTicketResultPrioritySourceValueUnionType ArrayOfAny { get { return new TicketingTicketResultPrioritySourceValueUnionType("arrayOfAny"); } }
        
        public static TicketingTicketResultPrioritySourceValueUnionType Null { get { return new TicketingTicketResultPrioritySourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(TicketingTicketResultPrioritySourceValueUnionType v) { return v.Value; }
        public static TicketingTicketResultPrioritySourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "TicketingTicketResult_source_value_priority": return TicketingTicketResultSourceValuePriority;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for TicketingTicketResultPrioritySourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((TicketingTicketResultPrioritySourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The source value of the ticket priority.
    /// </summary>
    [JsonConverter(typeof(TicketingTicketResultPrioritySourceValueUnion.TicketingTicketResultPrioritySourceValueUnionConverter))]
    public class TicketingTicketResultPrioritySourceValueUnion {
        public TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TicketingTicketResultSourceValuePriority? TicketingTicketResultSourceValuePriority { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public TicketingTicketResultPrioritySourceValueUnionType Type { get; set; }


        public static TicketingTicketResultPrioritySourceValueUnion CreateStr(string str) {
            TicketingTicketResultPrioritySourceValueUnionType typ = TicketingTicketResultPrioritySourceValueUnionType.Str;

            TicketingTicketResultPrioritySourceValueUnion res = new TicketingTicketResultPrioritySourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static TicketingTicketResultPrioritySourceValueUnion CreateNumber(double number) {
            TicketingTicketResultPrioritySourceValueUnionType typ = TicketingTicketResultPrioritySourceValueUnionType.Number;

            TicketingTicketResultPrioritySourceValueUnion res = new TicketingTicketResultPrioritySourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static TicketingTicketResultPrioritySourceValueUnion CreateBoolean(bool boolean) {
            TicketingTicketResultPrioritySourceValueUnionType typ = TicketingTicketResultPrioritySourceValueUnionType.Boolean;

            TicketingTicketResultPrioritySourceValueUnion res = new TicketingTicketResultPrioritySourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static TicketingTicketResultPrioritySourceValueUnion CreateTicketingTicketResultSourceValuePriority(TicketingTicketResultSourceValuePriority ticketingTicketResultSourceValuePriority) {
            TicketingTicketResultPrioritySourceValueUnionType typ = TicketingTicketResultPrioritySourceValueUnionType.TicketingTicketResultSourceValuePriority;

            TicketingTicketResultPrioritySourceValueUnion res = new TicketingTicketResultPrioritySourceValueUnion(typ);
            res.TicketingTicketResultSourceValuePriority = ticketingTicketResultSourceValuePriority;
            return res;
        }

        public static TicketingTicketResultPrioritySourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            TicketingTicketResultPrioritySourceValueUnionType typ = TicketingTicketResultPrioritySourceValueUnionType.ArrayOfAny;

            TicketingTicketResultPrioritySourceValueUnion res = new TicketingTicketResultPrioritySourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static TicketingTicketResultPrioritySourceValueUnion CreateNull() {
            TicketingTicketResultPrioritySourceValueUnionType typ = TicketingTicketResultPrioritySourceValueUnionType.Null;
            return new TicketingTicketResultPrioritySourceValueUnion(typ);
        }

        public class TicketingTicketResultPrioritySourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(TicketingTicketResultPrioritySourceValueUnion);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.TicketingTicketResultSourceValuePriority)
                    {
                        TicketingTicketResultSourceValuePriority = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TicketingTicketResultSourceValuePriority>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TicketingTicketResultSourceValuePriority), new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.TicketingTicketResultSourceValuePriority), "TicketingTicketResultSourceValuePriority"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.Number)
                    {
                        Number = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    var converted = Convert.ToBoolean(json);
                    return new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.Boolean)
                    {
                        Boolean = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    return new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new TicketingTicketResultPrioritySourceValueUnion(TicketingTicketResultPrioritySourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                TicketingTicketResultPrioritySourceValueUnion res = (TicketingTicketResultPrioritySourceValueUnion)value;
                if (TicketingTicketResultPrioritySourceValueUnionType.FromString(res.Type).Equals(TicketingTicketResultPrioritySourceValueUnionType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }
                if (res.TicketingTicketResultSourceValuePriority != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TicketingTicketResultSourceValuePriority));
                    return;
                }
                if (res.ArrayOfAny != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfAny));
                    return;
                }

            }

        }

    }
}