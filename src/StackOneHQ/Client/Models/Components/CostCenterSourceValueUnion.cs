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
    

    public class CostCenterSourceValueUnionType
    {
        private CostCenterSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CostCenterSourceValueUnionType Str { get { return new CostCenterSourceValueUnionType("str"); } }
        
        public static CostCenterSourceValueUnionType Number { get { return new CostCenterSourceValueUnionType("number"); } }
        
        public static CostCenterSourceValueUnionType Boolean { get { return new CostCenterSourceValueUnionType("boolean"); } }
        
        public static CostCenterSourceValueUnionType SourceValueCostCenter { get { return new CostCenterSourceValueUnionType("source_value_cost_center"); } }
        
        public static CostCenterSourceValueUnionType ArrayOfAny { get { return new CostCenterSourceValueUnionType("arrayOfAny"); } }
        
        public static CostCenterSourceValueUnionType Null { get { return new CostCenterSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CostCenterSourceValueUnionType v) { return v.Value; }
        public static CostCenterSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "source_value_cost_center": return SourceValueCostCenter;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CostCenterSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CostCenterSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(CostCenterSourceValueUnion.CostCenterSourceValueUnionConverter))]
    public class CostCenterSourceValueUnion {
        public CostCenterSourceValueUnion(CostCenterSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceValueCostCenter? SourceValueCostCenter { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public CostCenterSourceValueUnionType Type { get; set; }


        public static CostCenterSourceValueUnion CreateStr(string str) {
            CostCenterSourceValueUnionType typ = CostCenterSourceValueUnionType.Str;

            CostCenterSourceValueUnion res = new CostCenterSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static CostCenterSourceValueUnion CreateNumber(double number) {
            CostCenterSourceValueUnionType typ = CostCenterSourceValueUnionType.Number;

            CostCenterSourceValueUnion res = new CostCenterSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static CostCenterSourceValueUnion CreateBoolean(bool boolean) {
            CostCenterSourceValueUnionType typ = CostCenterSourceValueUnionType.Boolean;

            CostCenterSourceValueUnion res = new CostCenterSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static CostCenterSourceValueUnion CreateSourceValueCostCenter(SourceValueCostCenter sourceValueCostCenter) {
            CostCenterSourceValueUnionType typ = CostCenterSourceValueUnionType.SourceValueCostCenter;

            CostCenterSourceValueUnion res = new CostCenterSourceValueUnion(typ);
            res.SourceValueCostCenter = sourceValueCostCenter;
            return res;
        }

        public static CostCenterSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            CostCenterSourceValueUnionType typ = CostCenterSourceValueUnionType.ArrayOfAny;

            CostCenterSourceValueUnion res = new CostCenterSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static CostCenterSourceValueUnion CreateNull() {
            CostCenterSourceValueUnionType typ = CostCenterSourceValueUnionType.Null;
            return new CostCenterSourceValueUnion(typ);
        }

        public class CostCenterSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CostCenterSourceValueUnion);

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
                    return new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.SourceValueCostCenter)
                    {
                        SourceValueCostCenter = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceValueCostCenter>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceValueCostCenter), new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.SourceValueCostCenter), "SourceValueCostCenter"));
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
                    return new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.Number)
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
                    return new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.Boolean)
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
                    return new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new CostCenterSourceValueUnion(CostCenterSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                CostCenterSourceValueUnion res = (CostCenterSourceValueUnion)value;
                if (CostCenterSourceValueUnionType.FromString(res.Type).Equals(CostCenterSourceValueUnionType.Null))
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
                if (res.SourceValueCostCenter != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceValueCostCenter));
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