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
    

    public class AvatarFileFormatSourceValueUnionType
    {
        private AvatarFileFormatSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static AvatarFileFormatSourceValueUnionType Str { get { return new AvatarFileFormatSourceValueUnionType("str"); } }
        
        public static AvatarFileFormatSourceValueUnionType Number { get { return new AvatarFileFormatSourceValueUnionType("number"); } }
        
        public static AvatarFileFormatSourceValueUnionType Boolean { get { return new AvatarFileFormatSourceValueUnionType("boolean"); } }
        
        public static AvatarFileFormatSourceValueUnionType SourceValueAvatarFileFormat { get { return new AvatarFileFormatSourceValueUnionType("source_value_avatar_file_format"); } }
        
        public static AvatarFileFormatSourceValueUnionType ArrayOfAny { get { return new AvatarFileFormatSourceValueUnionType("arrayOfAny"); } }
        
        public static AvatarFileFormatSourceValueUnionType Null { get { return new AvatarFileFormatSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(AvatarFileFormatSourceValueUnionType v) { return v.Value; }
        public static AvatarFileFormatSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "source_value_avatar_file_format": return SourceValueAvatarFileFormat;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for AvatarFileFormatSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((AvatarFileFormatSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(AvatarFileFormatSourceValueUnion.AvatarFileFormatSourceValueUnionConverter))]
    public class AvatarFileFormatSourceValueUnion {
        public AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceValueAvatarFileFormat? SourceValueAvatarFileFormat { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public AvatarFileFormatSourceValueUnionType Type { get; set; }


        public static AvatarFileFormatSourceValueUnion CreateStr(string str) {
            AvatarFileFormatSourceValueUnionType typ = AvatarFileFormatSourceValueUnionType.Str;

            AvatarFileFormatSourceValueUnion res = new AvatarFileFormatSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static AvatarFileFormatSourceValueUnion CreateNumber(double number) {
            AvatarFileFormatSourceValueUnionType typ = AvatarFileFormatSourceValueUnionType.Number;

            AvatarFileFormatSourceValueUnion res = new AvatarFileFormatSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static AvatarFileFormatSourceValueUnion CreateBoolean(bool boolean) {
            AvatarFileFormatSourceValueUnionType typ = AvatarFileFormatSourceValueUnionType.Boolean;

            AvatarFileFormatSourceValueUnion res = new AvatarFileFormatSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static AvatarFileFormatSourceValueUnion CreateSourceValueAvatarFileFormat(SourceValueAvatarFileFormat sourceValueAvatarFileFormat) {
            AvatarFileFormatSourceValueUnionType typ = AvatarFileFormatSourceValueUnionType.SourceValueAvatarFileFormat;

            AvatarFileFormatSourceValueUnion res = new AvatarFileFormatSourceValueUnion(typ);
            res.SourceValueAvatarFileFormat = sourceValueAvatarFileFormat;
            return res;
        }

        public static AvatarFileFormatSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            AvatarFileFormatSourceValueUnionType typ = AvatarFileFormatSourceValueUnionType.ArrayOfAny;

            AvatarFileFormatSourceValueUnion res = new AvatarFileFormatSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static AvatarFileFormatSourceValueUnion CreateNull() {
            AvatarFileFormatSourceValueUnionType typ = AvatarFileFormatSourceValueUnionType.Null;
            return new AvatarFileFormatSourceValueUnion(typ);
        }

        public class AvatarFileFormatSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(AvatarFileFormatSourceValueUnion);

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
                    return new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.SourceValueAvatarFileFormat)
                    {
                        SourceValueAvatarFileFormat = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceValueAvatarFileFormat>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceValueAvatarFileFormat), new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.SourceValueAvatarFileFormat), "SourceValueAvatarFileFormat"));
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
                    return new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.Number)
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
                    return new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.Boolean)
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
                    return new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new AvatarFileFormatSourceValueUnion(AvatarFileFormatSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                AvatarFileFormatSourceValueUnion res = (AvatarFileFormatSourceValueUnion)value;
                if (AvatarFileFormatSourceValueUnionType.FromString(res.Type).Equals(AvatarFileFormatSourceValueUnionType.Null))
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
                if (res.SourceValueAvatarFileFormat != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceValueAvatarFileFormat));
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