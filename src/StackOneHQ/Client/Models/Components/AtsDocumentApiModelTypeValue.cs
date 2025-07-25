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
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The category of the file
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class AtsDocumentApiModelTypeValue : IEquatable<AtsDocumentApiModelTypeValue>
    {
        public static readonly AtsDocumentApiModelTypeValue Resume = new AtsDocumentApiModelTypeValue("resume");
        public static readonly AtsDocumentApiModelTypeValue Avatar = new AtsDocumentApiModelTypeValue("avatar");
        public static readonly AtsDocumentApiModelTypeValue CoverLetter = new AtsDocumentApiModelTypeValue("cover_letter");
        public static readonly AtsDocumentApiModelTypeValue ProfilePicture = new AtsDocumentApiModelTypeValue("profile_picture");
        public static readonly AtsDocumentApiModelTypeValue Policy = new AtsDocumentApiModelTypeValue("policy");
        public static readonly AtsDocumentApiModelTypeValue Passport = new AtsDocumentApiModelTypeValue("passport");
        public static readonly AtsDocumentApiModelTypeValue Assessment = new AtsDocumentApiModelTypeValue("assessment");
        public static readonly AtsDocumentApiModelTypeValue InterviewAttachment = new AtsDocumentApiModelTypeValue("interview_attachment");
        public static readonly AtsDocumentApiModelTypeValue TakeHomeTest = new AtsDocumentApiModelTypeValue("take_home_test");
        public static readonly AtsDocumentApiModelTypeValue OfferLetter = new AtsDocumentApiModelTypeValue("offer_letter");
        public static readonly AtsDocumentApiModelTypeValue SignedOfferLetter = new AtsDocumentApiModelTypeValue("signed_offer_letter");
        public static readonly AtsDocumentApiModelTypeValue NationalId = new AtsDocumentApiModelTypeValue("national_id");
        public static readonly AtsDocumentApiModelTypeValue OfferPacket = new AtsDocumentApiModelTypeValue("offer_packet");
        public static readonly AtsDocumentApiModelTypeValue Other = new AtsDocumentApiModelTypeValue("other");
        public static readonly AtsDocumentApiModelTypeValue UnmappedValue = new AtsDocumentApiModelTypeValue("unmapped_value");

        private static readonly Dictionary <string, AtsDocumentApiModelTypeValue> _knownValues =
            new Dictionary <string, AtsDocumentApiModelTypeValue> ()
            {
                ["resume"] = Resume,
                ["avatar"] = Avatar,
                ["cover_letter"] = CoverLetter,
                ["profile_picture"] = ProfilePicture,
                ["policy"] = Policy,
                ["passport"] = Passport,
                ["assessment"] = Assessment,
                ["interview_attachment"] = InterviewAttachment,
                ["take_home_test"] = TakeHomeTest,
                ["offer_letter"] = OfferLetter,
                ["signed_offer_letter"] = SignedOfferLetter,
                ["national_id"] = NationalId,
                ["offer_packet"] = OfferPacket,
                ["other"] = Other,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, AtsDocumentApiModelTypeValue> _values =
            new ConcurrentDictionary<string, AtsDocumentApiModelTypeValue>(_knownValues);

        private AtsDocumentApiModelTypeValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static AtsDocumentApiModelTypeValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new AtsDocumentApiModelTypeValue(value));
        }

        public static implicit operator AtsDocumentApiModelTypeValue(string value) => Of(value);
        public static implicit operator string(AtsDocumentApiModelTypeValue atsdocumentapimodeltypevalue) => atsdocumentapimodeltypevalue.Value;

        public static AtsDocumentApiModelTypeValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as AtsDocumentApiModelTypeValue);

        public bool Equals(AtsDocumentApiModelTypeValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}