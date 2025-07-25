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
    

    public class HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType
    {
        private HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType Str { get { return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType("str"); } }
        
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType Number { get { return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType("number"); } }
        
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType Boolean { get { return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType("boolean"); } }
        
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType HrisCreateEmployeeRequestDtoSourceValuePayPeriod { get { return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType("HrisCreateEmployeeRequestDto_source_value_pay_period"); } }
        
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType ArrayOfAny { get { return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType("arrayOfAny"); } }
        
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType Null { get { return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType v) { return v.Value; }
        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "HrisCreateEmployeeRequestDto_source_value_pay_period": return HrisCreateEmployeeRequestDtoSourceValuePayPeriod;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The source value of the pay period.
    /// </summary>
    [JsonConverter(typeof(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion.HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionConverter))]
    public class HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion {
        public HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HrisCreateEmployeeRequestDtoSourceValuePayPeriod? HrisCreateEmployeeRequestDtoSourceValuePayPeriod { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType Type { get; set; }


        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion CreateStr(string str) {
            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType typ = HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Str;

            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion res = new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion CreateNumber(double number) {
            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType typ = HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Number;

            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion res = new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion CreateBoolean(bool boolean) {
            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType typ = HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Boolean;

            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion res = new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion CreateHrisCreateEmployeeRequestDtoSourceValuePayPeriod(HrisCreateEmployeeRequestDtoSourceValuePayPeriod hrisCreateEmployeeRequestDtoSourceValuePayPeriod) {
            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType typ = HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.HrisCreateEmployeeRequestDtoSourceValuePayPeriod;

            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion res = new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(typ);
            res.HrisCreateEmployeeRequestDtoSourceValuePayPeriod = hrisCreateEmployeeRequestDtoSourceValuePayPeriod;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType typ = HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.ArrayOfAny;

            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion res = new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion CreateNull() {
            HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType typ = HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Null;
            return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(typ);
        }

        public class HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion);

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
                    return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.HrisCreateEmployeeRequestDtoSourceValuePayPeriod)
                    {
                        HrisCreateEmployeeRequestDtoSourceValuePayPeriod = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HrisCreateEmployeeRequestDtoSourceValuePayPeriod>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HrisCreateEmployeeRequestDtoSourceValuePayPeriod), new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.HrisCreateEmployeeRequestDtoSourceValuePayPeriod), "HrisCreateEmployeeRequestDtoSourceValuePayPeriod"));
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
                    return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Number)
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
                    return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Boolean)
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
                    return new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion res = (HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnion)value;
                if (HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.FromString(res.Type).Equals(HrisCreateEmployeeRequestDtoPayPeriodSourceValueUnionType.Null))
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
                if (res.HrisCreateEmployeeRequestDtoSourceValuePayPeriod != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HrisCreateEmployeeRequestDtoSourceValuePayPeriod));
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