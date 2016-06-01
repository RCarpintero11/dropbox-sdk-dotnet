// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Representations for a person's name to assist with internationalization.</para>
    /// </summary>
    /// <seealso cref="Account" />
    /// <seealso cref="BasicAccount" />
    /// <seealso cref="FullAccount" />
    public class Name
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<Name> Encoder = new NameEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<Name> Decoder = new NameDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Name" /> class.</para>
        /// </summary>
        /// <param name="givenName">Also known as a first name.</param>
        /// <param name="surname">Also known as a last name or family name.</param>
        /// <param name="familiarName">Locale-dependent name. In the US, a person's familiar
        /// name is their <paramref name="givenName" />, but elsewhere, it could be any
        /// combination of a person's <paramref name="givenName" /> and <paramref
        /// name="surname" />.</param>
        /// <param name="displayName">A name that can be used directly to represent the name of
        /// a user's Dropbox account.</param>
        public Name(string givenName,
                    string surname,
                    string familiarName,
                    string displayName)
        {
            if (givenName == null)
            {
                throw new sys.ArgumentNullException("givenName");
            }

            if (surname == null)
            {
                throw new sys.ArgumentNullException("surname");
            }

            if (familiarName == null)
            {
                throw new sys.ArgumentNullException("familiarName");
            }

            if (displayName == null)
            {
                throw new sys.ArgumentNullException("displayName");
            }

            this.GivenName = givenName;
            this.Surname = surname;
            this.FamiliarName = familiarName;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Name" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public Name()
        {
        }

        /// <summary>
        /// <para>Also known as a first name.</para>
        /// </summary>
        public string GivenName { get; protected set; }

        /// <summary>
        /// <para>Also known as a last name or family name.</para>
        /// </summary>
        public string Surname { get; protected set; }

        /// <summary>
        /// <para>Locale-dependent name. In the US, a person's familiar name is their <see
        /// cref="GivenName" />, but elsewhere, it could be any combination of a person's <see
        /// cref="GivenName" /> and <see cref="Surname" />.</para>
        /// </summary>
        public string FamiliarName { get; protected set; }

        /// <summary>
        /// <para>A name that can be used directly to represent the name of a user's Dropbox
        /// account.</para>
        /// </summary>
        public string DisplayName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="Name" />.</para>
        /// </summary>
        private class NameEncoder : enc.StructEncoder<Name>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(Name value, enc.IJsonWriter writer)
            {
                WriteProperty("given_name", value.GivenName, writer, enc.StringEncoder.Instance);
                WriteProperty("surname", value.Surname, writer, enc.StringEncoder.Instance);
                WriteProperty("familiar_name", value.FamiliarName, writer, enc.StringEncoder.Instance);
                WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="Name" />.</para>
        /// </summary>
        private class NameDecoder : enc.StructDecoder<Name>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="Name" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override Name Create()
            {
                return new Name();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(Name value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "given_name":
                        value.GivenName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "surname":
                        value.Surname = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "familiar_name":
                        value.FamiliarName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
