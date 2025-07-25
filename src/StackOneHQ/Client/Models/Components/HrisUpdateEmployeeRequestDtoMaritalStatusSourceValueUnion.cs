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
    

    public class HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType
    {
        private HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType Str { get { return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType("str"); } }
        
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType Number { get { return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType("number"); } }
        
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType Boolean { get { return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType("boolean"); } }
        
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus { get { return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType("HrisUpdateEmployeeRequestDto_source_value_marital_status"); } }
        
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType ArrayOfAny { get { return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType("arrayOfAny"); } }
        
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType Null { get { return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType v) { return v.Value; }
        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "HrisUpdateEmployeeRequestDto_source_value_marital_status": return HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion.HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionConverter))]
    public class HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion {
        public HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus? HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType Type { get; set; }


        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion CreateStr(string str) {
            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType typ = HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Str;

            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion res = new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion CreateNumber(double number) {
            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType typ = HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Number;

            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion res = new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion CreateBoolean(bool boolean) {
            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType typ = HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Boolean;

            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion res = new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion CreateHrisUpdateEmployeeRequestDtoSourceValueMaritalStatus(HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus hrisUpdateEmployeeRequestDtoSourceValueMaritalStatus) {
            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType typ = HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus;

            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion res = new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(typ);
            res.HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus = hrisUpdateEmployeeRequestDtoSourceValueMaritalStatus;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType typ = HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.ArrayOfAny;

            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion res = new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion CreateNull() {
            HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType typ = HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Null;
            return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(typ);
        }

        public class HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion);

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
                    return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus)
                    {
                        HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus), new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus), "HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus"));
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
                    return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Number)
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
                    return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Boolean)
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
                    return new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion res = (HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnion)value;
                if (HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.FromString(res.Type).Equals(HrisUpdateEmployeeRequestDtoMaritalStatusSourceValueUnionType.Null))
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
                if (res.HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HrisUpdateEmployeeRequestDtoSourceValueMaritalStatus));
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