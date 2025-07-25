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
    

    public class LanguageEnumSourceValueUnionType
    {
        private LanguageEnumSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static LanguageEnumSourceValueUnionType Str { get { return new LanguageEnumSourceValueUnionType("str"); } }
        
        public static LanguageEnumSourceValueUnionType Number { get { return new LanguageEnumSourceValueUnionType("number"); } }
        
        public static LanguageEnumSourceValueUnionType Boolean { get { return new LanguageEnumSourceValueUnionType("boolean"); } }
        
        public static LanguageEnumSourceValueUnionType LanguageEnumSourceValue { get { return new LanguageEnumSourceValueUnionType("LanguageEnum_source_value"); } }
        
        public static LanguageEnumSourceValueUnionType ArrayOfAny { get { return new LanguageEnumSourceValueUnionType("arrayOfAny"); } }
        
        public static LanguageEnumSourceValueUnionType Null { get { return new LanguageEnumSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(LanguageEnumSourceValueUnionType v) { return v.Value; }
        public static LanguageEnumSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "LanguageEnum_source_value": return LanguageEnumSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for LanguageEnumSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((LanguageEnumSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(LanguageEnumSourceValueUnion.LanguageEnumSourceValueUnionConverter))]
    public class LanguageEnumSourceValueUnion {
        public LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public LanguageEnumSourceValue? LanguageEnumSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public LanguageEnumSourceValueUnionType Type { get; set; }


        public static LanguageEnumSourceValueUnion CreateStr(string str) {
            LanguageEnumSourceValueUnionType typ = LanguageEnumSourceValueUnionType.Str;

            LanguageEnumSourceValueUnion res = new LanguageEnumSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static LanguageEnumSourceValueUnion CreateNumber(double number) {
            LanguageEnumSourceValueUnionType typ = LanguageEnumSourceValueUnionType.Number;

            LanguageEnumSourceValueUnion res = new LanguageEnumSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static LanguageEnumSourceValueUnion CreateBoolean(bool boolean) {
            LanguageEnumSourceValueUnionType typ = LanguageEnumSourceValueUnionType.Boolean;

            LanguageEnumSourceValueUnion res = new LanguageEnumSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static LanguageEnumSourceValueUnion CreateLanguageEnumSourceValue(LanguageEnumSourceValue languageEnumSourceValue) {
            LanguageEnumSourceValueUnionType typ = LanguageEnumSourceValueUnionType.LanguageEnumSourceValue;

            LanguageEnumSourceValueUnion res = new LanguageEnumSourceValueUnion(typ);
            res.LanguageEnumSourceValue = languageEnumSourceValue;
            return res;
        }

        public static LanguageEnumSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            LanguageEnumSourceValueUnionType typ = LanguageEnumSourceValueUnionType.ArrayOfAny;

            LanguageEnumSourceValueUnion res = new LanguageEnumSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static LanguageEnumSourceValueUnion CreateNull() {
            LanguageEnumSourceValueUnionType typ = LanguageEnumSourceValueUnionType.Null;
            return new LanguageEnumSourceValueUnion(typ);
        }

        public class LanguageEnumSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(LanguageEnumSourceValueUnion);

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
                    return new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.LanguageEnumSourceValue)
                    {
                        LanguageEnumSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<LanguageEnumSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(LanguageEnumSourceValue), new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.LanguageEnumSourceValue), "LanguageEnumSourceValue"));
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
                    return new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.Number)
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
                    return new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.Boolean)
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
                    return new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new LanguageEnumSourceValueUnion(LanguageEnumSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                LanguageEnumSourceValueUnion res = (LanguageEnumSourceValueUnion)value;
                if (LanguageEnumSourceValueUnionType.FromString(res.Type).Equals(LanguageEnumSourceValueUnionType.Null))
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
                if (res.LanguageEnumSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.LanguageEnumSourceValue));
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