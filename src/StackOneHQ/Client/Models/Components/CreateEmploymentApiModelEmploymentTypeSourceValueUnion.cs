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
    

    public class CreateEmploymentApiModelEmploymentTypeSourceValueUnionType
    {
        private CreateEmploymentApiModelEmploymentTypeSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType Str { get { return new CreateEmploymentApiModelEmploymentTypeSourceValueUnionType("str"); } }
        
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType Number { get { return new CreateEmploymentApiModelEmploymentTypeSourceValueUnionType("number"); } }
        
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType Boolean { get { return new CreateEmploymentApiModelEmploymentTypeSourceValueUnionType("boolean"); } }
        
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType CreateEmploymentApiModelSourceValueEmploymentType { get { return new CreateEmploymentApiModelEmploymentTypeSourceValueUnionType("CreateEmploymentApiModel_source_value_employment_type"); } }
        
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType ArrayOfAny { get { return new CreateEmploymentApiModelEmploymentTypeSourceValueUnionType("arrayOfAny"); } }
        
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType Null { get { return new CreateEmploymentApiModelEmploymentTypeSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType v) { return v.Value; }
        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "CreateEmploymentApiModel_source_value_employment_type": return CreateEmploymentApiModelSourceValueEmploymentType;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CreateEmploymentApiModelEmploymentTypeSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CreateEmploymentApiModelEmploymentTypeSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The source value of the employment type.
    /// </summary>
    [JsonConverter(typeof(CreateEmploymentApiModelEmploymentTypeSourceValueUnion.CreateEmploymentApiModelEmploymentTypeSourceValueUnionConverter))]
    public class CreateEmploymentApiModelEmploymentTypeSourceValueUnion {
        public CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CreateEmploymentApiModelSourceValueEmploymentType? CreateEmploymentApiModelSourceValueEmploymentType { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public CreateEmploymentApiModelEmploymentTypeSourceValueUnionType Type { get; set; }


        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnion CreateStr(string str) {
            CreateEmploymentApiModelEmploymentTypeSourceValueUnionType typ = CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Str;

            CreateEmploymentApiModelEmploymentTypeSourceValueUnion res = new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnion CreateNumber(double number) {
            CreateEmploymentApiModelEmploymentTypeSourceValueUnionType typ = CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Number;

            CreateEmploymentApiModelEmploymentTypeSourceValueUnion res = new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnion CreateBoolean(bool boolean) {
            CreateEmploymentApiModelEmploymentTypeSourceValueUnionType typ = CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Boolean;

            CreateEmploymentApiModelEmploymentTypeSourceValueUnion res = new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnion CreateCreateEmploymentApiModelSourceValueEmploymentType(CreateEmploymentApiModelSourceValueEmploymentType createEmploymentAPIModelSourceValueEmploymentType) {
            CreateEmploymentApiModelEmploymentTypeSourceValueUnionType typ = CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.CreateEmploymentApiModelSourceValueEmploymentType;

            CreateEmploymentApiModelEmploymentTypeSourceValueUnion res = new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(typ);
            res.CreateEmploymentApiModelSourceValueEmploymentType = createEmploymentAPIModelSourceValueEmploymentType;
            return res;
        }

        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            CreateEmploymentApiModelEmploymentTypeSourceValueUnionType typ = CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.ArrayOfAny;

            CreateEmploymentApiModelEmploymentTypeSourceValueUnion res = new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static CreateEmploymentApiModelEmploymentTypeSourceValueUnion CreateNull() {
            CreateEmploymentApiModelEmploymentTypeSourceValueUnionType typ = CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Null;
            return new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(typ);
        }

        public class CreateEmploymentApiModelEmploymentTypeSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CreateEmploymentApiModelEmploymentTypeSourceValueUnion);

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
                    return new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.CreateEmploymentApiModelSourceValueEmploymentType)
                    {
                        CreateEmploymentApiModelSourceValueEmploymentType = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CreateEmploymentApiModelSourceValueEmploymentType>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CreateEmploymentApiModelSourceValueEmploymentType), new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.CreateEmploymentApiModelSourceValueEmploymentType), "CreateEmploymentApiModelSourceValueEmploymentType"));
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
                    return new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Number)
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
                    return new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Boolean)
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
                    return new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new CreateEmploymentApiModelEmploymentTypeSourceValueUnion(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                CreateEmploymentApiModelEmploymentTypeSourceValueUnion res = (CreateEmploymentApiModelEmploymentTypeSourceValueUnion)value;
                if (CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.FromString(res.Type).Equals(CreateEmploymentApiModelEmploymentTypeSourceValueUnionType.Null))
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
                if (res.CreateEmploymentApiModelSourceValueEmploymentType != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CreateEmploymentApiModelSourceValueEmploymentType));
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