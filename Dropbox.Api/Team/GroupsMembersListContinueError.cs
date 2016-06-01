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
    /// <para>The groups members list continue error object</para>
    /// </summary>
    public class GroupsMembersListContinueError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupsMembersListContinueError> Encoder = new GroupsMembersListContinueErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupsMembersListContinueError> Decoder = new GroupsMembersListContinueErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsMembersListContinueError"
        /// /> class.</para>
        /// </summary>
        public GroupsMembersListContinueError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidCursor</para>
        /// </summary>
        public bool IsInvalidCursor
        {
            get
            {
                return this is InvalidCursor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidCursor, or <c>null</c>.</para>
        /// </summary>
        public InvalidCursor AsInvalidCursor
        {
            get
            {
                return this as InvalidCursor;
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
        /// <para>Encoder for  <see cref="GroupsMembersListContinueError" />.</para>
        /// </summary>
        private class GroupsMembersListContinueErrorEncoder : enc.StructEncoder<GroupsMembersListContinueError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupsMembersListContinueError value, enc.IJsonWriter writer)
            {
                if (value is InvalidCursor)
                {
                    WriteProperty(".tag", "invalid_cursor", writer, enc.StringEncoder.Instance);
                    InvalidCursor.Encoder.EncodeFields((InvalidCursor)value, writer);
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
        /// <para>Decoder for  <see cref="GroupsMembersListContinueError" />.</para>
        /// </summary>
        private class GroupsMembersListContinueErrorDecoder : enc.UnionDecoder<GroupsMembersListContinueError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupsMembersListContinueError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupsMembersListContinueError Create()
            {
                return new GroupsMembersListContinueError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupsMembersListContinueError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_cursor":
                        return InvalidCursor.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The cursor is invalid.</para>
        /// </summary>
        public sealed class InvalidCursor : GroupsMembersListContinueError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidCursor> Encoder = new InvalidCursorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidCursor> Decoder = new InvalidCursorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidCursor" />
            /// class.</para>
            /// </summary>
            private InvalidCursor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidCursor</para>
            /// </summary>
            public static readonly InvalidCursor Instance = new InvalidCursor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidCursor" />.</para>
            /// </summary>
            private class InvalidCursorEncoder : enc.StructEncoder<InvalidCursor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidCursor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidCursor" />.</para>
            /// </summary>
            private class InvalidCursorDecoder : enc.StructDecoder<InvalidCursor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidCursor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidCursor Create()
                {
                    return new InvalidCursor();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InvalidCursor DecodeFields(enc.IJsonReader reader)
                {
                    return InvalidCursor.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : GroupsMembersListContinueError
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
