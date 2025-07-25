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
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class ResponseType
    {
        private ResponseType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ResponseType MapOfAny { get { return new ResponseType("mapOfAny"); } }
        
        public static ResponseType ArrayOfAny { get { return new ResponseType("arrayOfAny"); } }
        
        public static ResponseType Str { get { return new ResponseType("str"); } }
        
        public static ResponseType Null { get { return new ResponseType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ResponseType v) { return v.Value; }
        public static ResponseType FromString(string v) {
            switch(v) {
                case "mapOfAny": return MapOfAny;
                case "arrayOfAny": return ArrayOfAny;
                case "str": return Str;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ResponseType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ResponseType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(Response.ResponseConverter))]
    public class Response {
        public Response(ResponseType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public Dictionary<string, object>? MapOfAny { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        public ResponseType Type { get; set; }


        public static Response CreateMapOfAny(Dictionary<string, object> mapOfAny) {
            ResponseType typ = ResponseType.MapOfAny;

            Response res = new Response(typ);
            res.MapOfAny = mapOfAny;
            return res;
        }

        public static Response CreateArrayOfAny(List<object> arrayOfAny) {
            ResponseType typ = ResponseType.ArrayOfAny;

            Response res = new Response(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static Response CreateStr(string str) {
            ResponseType typ = ResponseType.Str;

            Response res = new Response(typ);
            res.Str = str;
            return res;
        }

        public static Response CreateNull() {
            ResponseType typ = ResponseType.Null;
            return new Response(typ);
        }

        public class ResponseConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Response);

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
                    return new Response(ResponseType.MapOfAny)
                    {
                        MapOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<Dictionary<string, object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(Dictionary<string, object>), new Response(ResponseType.MapOfAny), "MapOfAny"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new Response(ResponseType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new Response(ResponseType.ArrayOfAny), "ArrayOfAny"));
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
                    return new Response(ResponseType.Str)
                    {
                        Str = json[1..^1]
                    };
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
                Response res = (Response)value;
                if (ResponseType.FromString(res.Type).Equals(ResponseType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.MapOfAny != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfAny));
                    return;
                }
                if (res.ArrayOfAny != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfAny));
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }

            }

        }

    }
}