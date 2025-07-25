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
    

    public class HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType
    {
        private HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType Str { get { return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType("str"); } }
        
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType Number { get { return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType("number"); } }
        
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType Boolean { get { return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType("boolean"); } }
        
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry { get { return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType("HrisUpdateEmployeeRequestDto_source_value_work_location_country"); } }
        
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType ArrayOfAny { get { return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType("arrayOfAny"); } }
        
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType Null { get { return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType v) { return v.Value; }
        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "HrisUpdateEmployeeRequestDto_source_value_work_location_country": return HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion.HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionConverter))]
    public class HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion {
        public HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry? HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType Type { get; set; }


        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion CreateStr(string str) {
            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType typ = HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Str;

            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion res = new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion CreateNumber(double number) {
            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType typ = HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Number;

            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion res = new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion CreateBoolean(bool boolean) {
            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType typ = HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Boolean;

            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion res = new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion CreateHrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry(HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry hrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry) {
            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType typ = HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry;

            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion res = new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(typ);
            res.HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry = hrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType typ = HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.ArrayOfAny;

            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion res = new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion CreateNull() {
            HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType typ = HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Null;
            return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(typ);
        }

        public class HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion);

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
                    return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry)
                    {
                        HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry), new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry), "HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry"));
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
                    return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Number)
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
                    return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Boolean)
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
                    return new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion res = (HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnion)value;
                if (HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.FromString(res.Type).Equals(HrisUpdateEmployeeRequestDtoWorkLocationCountrySourceValueUnionType.Null))
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
                if (res.HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HrisUpdateEmployeeRequestDtoSourceValueWorkLocationCountry));
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