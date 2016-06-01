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
    /// <para>Actions that may be taken on members of a shared folder.</para>
    /// </summary>
    public class MemberAction
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberAction> Encoder = new MemberActionEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberAction> Decoder = new MemberActionDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAction" /> class.</para>
        /// </summary>
        public MemberAction()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MakeEditor</para>
        /// </summary>
        public bool IsMakeEditor
        {
            get
            {
                return this is MakeEditor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MakeEditor, or <c>null</c>.</para>
        /// </summary>
        public MakeEditor AsMakeEditor
        {
            get
            {
                return this as MakeEditor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MakeOwner</para>
        /// </summary>
        public bool IsMakeOwner
        {
            get
            {
                return this is MakeOwner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MakeOwner, or <c>null</c>.</para>
        /// </summary>
        public MakeOwner AsMakeOwner
        {
            get
            {
                return this as MakeOwner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MakeViewer</para>
        /// </summary>
        public bool IsMakeViewer
        {
            get
            {
                return this is MakeViewer;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MakeViewer, or <c>null</c>.</para>
        /// </summary>
        public MakeViewer AsMakeViewer
        {
            get
            {
                return this as MakeViewer;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Remove</para>
        /// </summary>
        public bool IsRemove
        {
            get
            {
                return this is Remove;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Remove, or <c>null</c>.</para>
        /// </summary>
        public Remove AsRemove
        {
            get
            {
                return this as Remove;
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
        /// <para>Encoder for  <see cref="MemberAction" />.</para>
        /// </summary>
        private class MemberActionEncoder : enc.StructEncoder<MemberAction>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberAction value, enc.IJsonWriter writer)
            {
                if (value is MakeEditor)
                {
                    WriteProperty(".tag", "make_editor", writer, enc.StringEncoder.Instance);
                    MakeEditor.Encoder.EncodeFields((MakeEditor)value, writer);
                    return;
                }
                if (value is MakeOwner)
                {
                    WriteProperty(".tag", "make_owner", writer, enc.StringEncoder.Instance);
                    MakeOwner.Encoder.EncodeFields((MakeOwner)value, writer);
                    return;
                }
                if (value is MakeViewer)
                {
                    WriteProperty(".tag", "make_viewer", writer, enc.StringEncoder.Instance);
                    MakeViewer.Encoder.EncodeFields((MakeViewer)value, writer);
                    return;
                }
                if (value is Remove)
                {
                    WriteProperty(".tag", "remove", writer, enc.StringEncoder.Instance);
                    Remove.Encoder.EncodeFields((Remove)value, writer);
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
        /// <para>Decoder for  <see cref="MemberAction" />.</para>
        /// </summary>
        private class MemberActionDecoder : enc.UnionDecoder<MemberAction>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberAction" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberAction Create()
            {
                return new MemberAction();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MemberAction Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "make_editor":
                        return MakeEditor.Decoder.DecodeFields(reader);
                    case "make_owner":
                        return MakeOwner.Decoder.DecodeFields(reader);
                    case "make_viewer":
                        return MakeViewer.Decoder.DecodeFields(reader);
                    case "remove":
                        return Remove.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Make the member an editor of the folder.</para>
        /// </summary>
        public sealed class MakeEditor : MemberAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MakeEditor> Encoder = new MakeEditorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MakeEditor> Decoder = new MakeEditorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MakeEditor" /> class.</para>
            /// </summary>
            private MakeEditor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MakeEditor</para>
            /// </summary>
            public static readonly MakeEditor Instance = new MakeEditor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MakeEditor" />.</para>
            /// </summary>
            private class MakeEditorEncoder : enc.StructEncoder<MakeEditor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MakeEditor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MakeEditor" />.</para>
            /// </summary>
            private class MakeEditorDecoder : enc.StructDecoder<MakeEditor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MakeEditor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MakeEditor Create()
                {
                    return new MakeEditor();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MakeEditor DecodeFields(enc.IJsonReader reader)
                {
                    return MakeEditor.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Make the member an owner of the folder.</para>
        /// </summary>
        public sealed class MakeOwner : MemberAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MakeOwner> Encoder = new MakeOwnerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MakeOwner> Decoder = new MakeOwnerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MakeOwner" /> class.</para>
            /// </summary>
            private MakeOwner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MakeOwner</para>
            /// </summary>
            public static readonly MakeOwner Instance = new MakeOwner();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MakeOwner" />.</para>
            /// </summary>
            private class MakeOwnerEncoder : enc.StructEncoder<MakeOwner>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MakeOwner value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MakeOwner" />.</para>
            /// </summary>
            private class MakeOwnerDecoder : enc.StructDecoder<MakeOwner>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MakeOwner" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MakeOwner Create()
                {
                    return new MakeOwner();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MakeOwner DecodeFields(enc.IJsonReader reader)
                {
                    return MakeOwner.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Make the member a viewer of the folder.</para>
        /// </summary>
        public sealed class MakeViewer : MemberAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MakeViewer> Encoder = new MakeViewerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MakeViewer> Decoder = new MakeViewerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MakeViewer" /> class.</para>
            /// </summary>
            private MakeViewer()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MakeViewer</para>
            /// </summary>
            public static readonly MakeViewer Instance = new MakeViewer();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MakeViewer" />.</para>
            /// </summary>
            private class MakeViewerEncoder : enc.StructEncoder<MakeViewer>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MakeViewer value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MakeViewer" />.</para>
            /// </summary>
            private class MakeViewerDecoder : enc.StructDecoder<MakeViewer>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MakeViewer" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MakeViewer Create()
                {
                    return new MakeViewer();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MakeViewer DecodeFields(enc.IJsonReader reader)
                {
                    return MakeViewer.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Remove the member from the folder.</para>
        /// </summary>
        public sealed class Remove : MemberAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Remove> Encoder = new RemoveEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Remove> Decoder = new RemoveDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Remove" /> class.</para>
            /// </summary>
            private Remove()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Remove</para>
            /// </summary>
            public static readonly Remove Instance = new Remove();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Remove" />.</para>
            /// </summary>
            private class RemoveEncoder : enc.StructEncoder<Remove>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Remove value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Remove" />.</para>
            /// </summary>
            private class RemoveDecoder : enc.StructDecoder<Remove>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Remove" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Remove Create()
                {
                    return new Remove();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Remove DecodeFields(enc.IJsonReader reader)
                {
                    return Remove.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MemberAction
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
