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
    

    public class CustomFieldsValueUnionType
    {
        private CustomFieldsValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CustomFieldsValueUnionType Str { get { return new CustomFieldsValueUnionType("str"); } }
        
        public static CustomFieldsValueUnionType Number { get { return new CustomFieldsValueUnionType("number"); } }
        
        public static CustomFieldsValueUnionType Boolean { get { return new CustomFieldsValueUnionType("boolean"); } }
        
        public static CustomFieldsValueUnionType CustomFieldsValue { get { return new CustomFieldsValueUnionType("CustomFields_value"); } }
        
        public static CustomFieldsValueUnionType ArrayOfAny { get { return new CustomFieldsValueUnionType("arrayOfAny"); } }
        
        public static CustomFieldsValueUnionType Null { get { return new CustomFieldsValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CustomFieldsValueUnionType v) { return v.Value; }
        public static CustomFieldsValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "CustomFields_value": return CustomFieldsValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CustomFieldsValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CustomFieldsValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The value associated with the custom field.
    /// </summary>
    [JsonConverter(typeof(CustomFieldsValueUnion.CustomFieldsValueUnionConverter))]
    public class CustomFieldsValueUnion {
        public CustomFieldsValueUnion(CustomFieldsValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CustomFieldsValue? CustomFieldsValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public CustomFieldsValueUnionType Type { get; set; }


        public static CustomFieldsValueUnion CreateStr(string str) {
            CustomFieldsValueUnionType typ = CustomFieldsValueUnionType.Str;

            CustomFieldsValueUnion res = new CustomFieldsValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static CustomFieldsValueUnion CreateNumber(double number) {
            CustomFieldsValueUnionType typ = CustomFieldsValueUnionType.Number;

            CustomFieldsValueUnion res = new CustomFieldsValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static CustomFieldsValueUnion CreateBoolean(bool boolean) {
            CustomFieldsValueUnionType typ = CustomFieldsValueUnionType.Boolean;

            CustomFieldsValueUnion res = new CustomFieldsValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static CustomFieldsValueUnion CreateCustomFieldsValue(CustomFieldsValue customFieldsValue) {
            CustomFieldsValueUnionType typ = CustomFieldsValueUnionType.CustomFieldsValue;

            CustomFieldsValueUnion res = new CustomFieldsValueUnion(typ);
            res.CustomFieldsValue = customFieldsValue;
            return res;
        }

        public static CustomFieldsValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            CustomFieldsValueUnionType typ = CustomFieldsValueUnionType.ArrayOfAny;

            CustomFieldsValueUnion res = new CustomFieldsValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static CustomFieldsValueUnion CreateNull() {
            CustomFieldsValueUnionType typ = CustomFieldsValueUnionType.Null;
            return new CustomFieldsValueUnion(typ);
        }

        public class CustomFieldsValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CustomFieldsValueUnion);

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
                    return new CustomFieldsValueUnion(CustomFieldsValueUnionType.CustomFieldsValue)
                    {
                        CustomFieldsValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CustomFieldsValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CustomFieldsValue), new CustomFieldsValueUnion(CustomFieldsValueUnionType.CustomFieldsValue), "CustomFieldsValue"));
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
                    return new CustomFieldsValueUnion(CustomFieldsValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new CustomFieldsValueUnion(CustomFieldsValueUnionType.Number)
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
                    return new CustomFieldsValueUnion(CustomFieldsValueUnionType.Boolean)
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
                    return new CustomFieldsValueUnion(CustomFieldsValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new CustomFieldsValueUnion(CustomFieldsValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                CustomFieldsValueUnion res = (CustomFieldsValueUnion)value;
                if (CustomFieldsValueUnionType.FromString(res.Type).Equals(CustomFieldsValueUnionType.Null))
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
                if (res.CustomFieldsValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CustomFieldsValue));
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