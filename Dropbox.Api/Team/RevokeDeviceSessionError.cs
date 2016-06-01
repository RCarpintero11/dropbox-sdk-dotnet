// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The revoke device session error object</para>
    /// </summary>
    public class RevokeDeviceSessionError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeDeviceSessionError> Encoder = new RevokeDeviceSessionErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeDeviceSessionError> Decoder = new RevokeDeviceSessionErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionError" />
        /// class.</para>
        /// </summary>
        public RevokeDeviceSessionError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DeviceSessionNotFound</para>
        /// </summary>
        public bool IsDeviceSessionNotFound
        {
            get
            {
                return this is DeviceSessionNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DeviceSessionNotFound, or <c>null</c>.</para>
        /// </summary>
        public DeviceSessionNotFound AsDeviceSessionNotFound
        {
            get
            {
                return this as DeviceSessionNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MemberNotFound</para>
        /// </summary>
        public bool IsMemberNotFound
        {
            get
            {
                return this is MemberNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MemberNotFound, or <c>null</c>.</para>
        /// </summary>
        public MemberNotFound AsMemberNotFound
        {
            get
            {
                return this as MemberNotFound;
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
        /// <para>Encoder for  <see cref="RevokeDeviceSessionError" />.</para>
        /// </summary>
        private class RevokeDeviceSessionErrorEncoder : enc.StructEncoder<RevokeDeviceSessionError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeDeviceSessionError value, enc.IJsonWriter writer)
            {
                if (value is DeviceSessionNotFound)
                {
                    WriteProperty(".tag", "device_session_not_found", writer, enc.StringEncoder.Instance);
                    DeviceSessionNotFound.Encoder.EncodeFields((DeviceSessionNotFound)value, writer);
                    return;
                }
                if (value is MemberNotFound)
                {
                    WriteProperty(".tag", "member_not_found", writer, enc.StringEncoder.Instance);
                    MemberNotFound.Encoder.EncodeFields((MemberNotFound)value, writer);
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
        /// <para>Decoder for  <see cref="RevokeDeviceSessionError" />.</para>
        /// </summary>
        private class RevokeDeviceSessionErrorDecoder : enc.UnionDecoder<RevokeDeviceSessionError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeDeviceSessionError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeDeviceSessionError Create()
            {
                return new RevokeDeviceSessionError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RevokeDeviceSessionError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "device_session_not_found":
                        return DeviceSessionNotFound.Decoder.DecodeFields(reader);
                    case "member_not_found":
                        return MemberNotFound.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Device session not found.</para>
        /// </summary>
        public sealed class DeviceSessionNotFound : RevokeDeviceSessionError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DeviceSessionNotFound> Encoder = new DeviceSessionNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DeviceSessionNotFound> Decoder = new DeviceSessionNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DeviceSessionNotFound" />
            /// class.</para>
            /// </summary>
            private DeviceSessionNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DeviceSessionNotFound</para>
            /// </summary>
            public static readonly DeviceSessionNotFound Instance = new DeviceSessionNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DeviceSessionNotFound" />.</para>
            /// </summary>
            private class DeviceSessionNotFoundEncoder : enc.StructEncoder<DeviceSessionNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DeviceSessionNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DeviceSessionNotFound" />.</para>
            /// </summary>
            private class DeviceSessionNotFoundDecoder : enc.StructDecoder<DeviceSessionNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DeviceSessionNotFound"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DeviceSessionNotFound Create()
                {
                    return new DeviceSessionNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override DeviceSessionNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return DeviceSessionNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Member not found.</para>
        /// </summary>
        public sealed class MemberNotFound : RevokeDeviceSessionError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MemberNotFound> Encoder = new MemberNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MemberNotFound> Decoder = new MemberNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberNotFound" />
            /// class.</para>
            /// </summary>
            private MemberNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MemberNotFound</para>
            /// </summary>
            public static readonly MemberNotFound Instance = new MemberNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MemberNotFound" />.</para>
            /// </summary>
            private class MemberNotFoundEncoder : enc.StructEncoder<MemberNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MemberNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MemberNotFound" />.</para>
            /// </summary>
            private class MemberNotFoundDecoder : enc.StructDecoder<MemberNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MemberNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MemberNotFound Create()
                {
                    return new MemberNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MemberNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return MemberNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : RevokeDeviceSessionError
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
