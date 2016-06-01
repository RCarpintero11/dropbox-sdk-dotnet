// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Includes different ways to identify a member of a shared folder.</para>
    /// </summary>
    public class MemberSelector
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberSelector> Encoder = new MemberSelectorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberSelector> Decoder = new MemberSelectorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberSelector" /> class.</para>
        /// </summary>
        public MemberSelector()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DropboxId</para>
        /// </summary>
        public bool IsDropboxId
        {
            get
            {
                return this is DropboxId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DropboxId, or <c>null</c>.</para>
        /// </summary>
        public DropboxId AsDropboxId
        {
            get
            {
                return this as DropboxId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Email</para>
        /// </summary>
        public bool IsEmail
        {
            get
            {
                return this is Email;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Email, or <c>null</c>.</para>
        /// </summary>
        public Email AsEmail
        {
            get
            {
                return this as Email;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberSelector" />.</para>
        /// </summary>
        private class MemberSelectorEncoder : enc.StructEncoder<MemberSelector>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberSelector value, enc.IJsonWriter writer)
            {
                if (value is DropboxId)
                {
                    WriteProperty(".tag", "dropbox_id", writer, enc.StringEncoder.Instance);
                    DropboxId.Encoder.EncodeFields((DropboxId)value, writer);
                    return;
                }
                if (value is Email)
                {
                    WriteProperty(".tag", "email", writer, enc.StringEncoder.Instance);
                    Email.Encoder.EncodeFields((Email)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberSelector" />.</para>
        /// </summary>
        private class MemberSelectorDecoder : enc.UnionDecoder<MemberSelector>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberSelector" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberSelector Create()
            {
                return new MemberSelector();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MemberSelector Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "dropbox_id":
                        return DropboxId.Decoder.DecodeFields(reader);
                    case "email":
                        return Email.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Dropbox account, team member, or group ID of member.</para>
        /// </summary>
        public sealed class DropboxId : MemberSelector
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DropboxId> Encoder = new DropboxIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DropboxId> Decoder = new DropboxIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DropboxId" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public DropboxId(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DropboxId" /> class.</para>
            /// </summary>
            private DropboxId()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DropboxId" />.</para>
            /// </summary>
            private class DropboxIdEncoder : enc.StructEncoder<DropboxId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DropboxId value, enc.IJsonWriter writer)
                {
                    WriteProperty("dropbox_id", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DropboxId" />.</para>
            /// </summary>
            private class DropboxIdDecoder : enc.StructDecoder<DropboxId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DropboxId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DropboxId Create()
                {
                    return new DropboxId();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(DropboxId value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "dropbox_id":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>E-mail address of member.</para>
        /// </summary>
        public sealed class Email : MemberSelector
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Email> Encoder = new EmailEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Email> Decoder = new EmailDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Email" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Email(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Email" /> class.</para>
            /// </summary>
            private Email()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Email" />.</para>
            /// </summary>
            private class EmailEncoder : enc.StructEncoder<Email>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Email value, enc.IJsonWriter writer)
                {
                    WriteProperty("email", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Email" />.</para>
            /// </summary>
            private class EmailDecoder : enc.StructDecoder<Email>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Email" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Email Create()
                {
                    return new Email();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Email value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "email":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MemberSelector
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
