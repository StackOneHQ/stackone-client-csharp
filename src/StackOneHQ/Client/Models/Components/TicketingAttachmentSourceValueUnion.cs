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
    

    public class TicketingAttachmentSourceValueUnionType
    {
        private TicketingAttachmentSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static TicketingAttachmentSourceValueUnionType Str { get { return new TicketingAttachmentSourceValueUnionType("str"); } }
        
        public static TicketingAttachmentSourceValueUnionType Number { get { return new TicketingAttachmentSourceValueUnionType("number"); } }
        
        public static TicketingAttachmentSourceValueUnionType Boolean { get { return new TicketingAttachmentSourceValueUnionType("boolean"); } }
        
        public static TicketingAttachmentSourceValueUnionType TicketingAttachmentSourceValue { get { return new TicketingAttachmentSourceValueUnionType("TicketingAttachment_source_value"); } }
        
        public static TicketingAttachmentSourceValueUnionType ArrayOfAny { get { return new TicketingAttachmentSourceValueUnionType("arrayOfAny"); } }
        
        public static TicketingAttachmentSourceValueUnionType Null { get { return new TicketingAttachmentSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(TicketingAttachmentSourceValueUnionType v) { return v.Value; }
        public static TicketingAttachmentSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "TicketingAttachment_source_value": return TicketingAttachmentSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for TicketingAttachmentSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((TicketingAttachmentSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(TicketingAttachmentSourceValueUnion.TicketingAttachmentSourceValueUnionConverter))]
    public class TicketingAttachmentSourceValueUnion {
        public TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TicketingAttachmentSourceValue? TicketingAttachmentSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public TicketingAttachmentSourceValueUnionType Type { get; set; }


        public static TicketingAttachmentSourceValueUnion CreateStr(string str) {
            TicketingAttachmentSourceValueUnionType typ = TicketingAttachmentSourceValueUnionType.Str;

            TicketingAttachmentSourceValueUnion res = new TicketingAttachmentSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static TicketingAttachmentSourceValueUnion CreateNumber(double number) {
            TicketingAttachmentSourceValueUnionType typ = TicketingAttachmentSourceValueUnionType.Number;

            TicketingAttachmentSourceValueUnion res = new TicketingAttachmentSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static TicketingAttachmentSourceValueUnion CreateBoolean(bool boolean) {
            TicketingAttachmentSourceValueUnionType typ = TicketingAttachmentSourceValueUnionType.Boolean;

            TicketingAttachmentSourceValueUnion res = new TicketingAttachmentSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static TicketingAttachmentSourceValueUnion CreateTicketingAttachmentSourceValue(TicketingAttachmentSourceValue ticketingAttachmentSourceValue) {
            TicketingAttachmentSourceValueUnionType typ = TicketingAttachmentSourceValueUnionType.TicketingAttachmentSourceValue;

            TicketingAttachmentSourceValueUnion res = new TicketingAttachmentSourceValueUnion(typ);
            res.TicketingAttachmentSourceValue = ticketingAttachmentSourceValue;
            return res;
        }

        public static TicketingAttachmentSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            TicketingAttachmentSourceValueUnionType typ = TicketingAttachmentSourceValueUnionType.ArrayOfAny;

            TicketingAttachmentSourceValueUnion res = new TicketingAttachmentSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static TicketingAttachmentSourceValueUnion CreateNull() {
            TicketingAttachmentSourceValueUnionType typ = TicketingAttachmentSourceValueUnionType.Null;
            return new TicketingAttachmentSourceValueUnion(typ);
        }

        public class TicketingAttachmentSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(TicketingAttachmentSourceValueUnion);

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
                    return new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.TicketingAttachmentSourceValue)
                    {
                        TicketingAttachmentSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TicketingAttachmentSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TicketingAttachmentSourceValue), new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.TicketingAttachmentSourceValue), "TicketingAttachmentSourceValue"));
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
                    return new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.Number)
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
                    return new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.Boolean)
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
                    return new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new TicketingAttachmentSourceValueUnion(TicketingAttachmentSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                TicketingAttachmentSourceValueUnion res = (TicketingAttachmentSourceValueUnion)value;
                if (TicketingAttachmentSourceValueUnionType.FromString(res.Type).Equals(TicketingAttachmentSourceValueUnionType.Null))
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
                if (res.TicketingAttachmentSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TicketingAttachmentSourceValue));
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