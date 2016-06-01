// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The thumbnail error object</para>
    /// </summary>
    public class ThumbnailError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ThumbnailError> Encoder = new ThumbnailErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ThumbnailError> Decoder = new ThumbnailErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailError" /> class.</para>
        /// </summary>
        public ThumbnailError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnsupportedExtension</para>
        /// </summary>
        public bool IsUnsupportedExtension
        {
            get
            {
                return this is UnsupportedExtension;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsupportedExtension, or <c>null</c>.</para>
        /// </summary>
        public UnsupportedExtension AsUnsupportedExtension
        {
            get
            {
                return this as UnsupportedExtension;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnsupportedImage</para>
        /// </summary>
        public bool IsUnsupportedImage
        {
            get
            {
                return this is UnsupportedImage;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsupportedImage, or <c>null</c>.</para>
        /// </summary>
        public UnsupportedImage AsUnsupportedImage
        {
            get
            {
                return this as UnsupportedImage;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ConversionError</para>
        /// </summary>
        public bool IsConversionError
        {
            get
            {
                return this is ConversionError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ConversionError, or <c>null</c>.</para>
        /// </summary>
        public ConversionError AsConversionError
        {
            get
            {
                return this as ConversionError;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ThumbnailError" />.</para>
        /// </summary>
        private class ThumbnailErrorEncoder : enc.StructEncoder<ThumbnailError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ThumbnailError value, enc.IJsonWriter writer)
            {
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is UnsupportedExtension)
                {
                    WriteProperty(".tag", "unsupported_extension", writer, enc.StringEncoder.Instance);
                    UnsupportedExtension.Encoder.EncodeFields((UnsupportedExtension)value, writer);
                    return;
                }
                if (value is UnsupportedImage)
                {
                    WriteProperty(".tag", "unsupported_image", writer, enc.StringEncoder.Instance);
                    UnsupportedImage.Encoder.EncodeFields((UnsupportedImage)value, writer);
                    return;
                }
                if (value is ConversionError)
                {
                    WriteProperty(".tag", "conversion_error", writer, enc.StringEncoder.Instance);
                    ConversionError.Encoder.EncodeFields((ConversionError)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ThumbnailError" />.</para>
        /// </summary>
        private class ThumbnailErrorDecoder : enc.UnionDecoder<ThumbnailError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ThumbnailError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ThumbnailError Create()
            {
                return new ThumbnailError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ThumbnailError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "unsupported_extension":
                        return UnsupportedExtension.Decoder.DecodeFields(reader);
                    case "unsupported_image":
                        return UnsupportedImage.Decoder.DecodeFields(reader);
                    case "conversion_error":
                        return ConversionError.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>An error occurs when downloading metadata for the image.</para>
        /// </summary>
        public sealed class Path : ThumbnailError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(LookupError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Files.LookupError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return new Path();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Path value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "path":
                            value.Value = Dropbox.Api.Files.LookupError.Decoder.Decode(reader);
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
        /// <para>The file extension doesn't allow conversion to a thumbnail.</para>
        /// </summary>
        public sealed class UnsupportedExtension : ThumbnailError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnsupportedExtension> Encoder = new UnsupportedExtensionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnsupportedExtension> Decoder = new UnsupportedExtensionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsupportedExtension" />
            /// class.</para>
            /// </summary>
            private UnsupportedExtension()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsupportedExtension</para>
            /// </summary>
            public static readonly UnsupportedExtension Instance = new UnsupportedExtension();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnsupportedExtension" />.</para>
            /// </summary>
            private class UnsupportedExtensionEncoder : enc.StructEncoder<UnsupportedExtension>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnsupportedExtension value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnsupportedExtension" />.</para>
            /// </summary>
            private class UnsupportedExtensionDecoder : enc.StructDecoder<UnsupportedExtension>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnsupportedExtension"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnsupportedExtension Create()
                {
                    return new UnsupportedExtension();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UnsupportedExtension DecodeFields(enc.IJsonReader reader)
                {
                    return UnsupportedExtension.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The image cannot be converted to a thumbnail.</para>
        /// </summary>
        public sealed class UnsupportedImage : ThumbnailError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnsupportedImage> Encoder = new UnsupportedImageEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnsupportedImage> Decoder = new UnsupportedImageDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsupportedImage" />
            /// class.</para>
            /// </summary>
            private UnsupportedImage()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsupportedImage</para>
            /// </summary>
            public static readonly UnsupportedImage Instance = new UnsupportedImage();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnsupportedImage" />.</para>
            /// </summary>
            private class UnsupportedImageEncoder : enc.StructEncoder<UnsupportedImage>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnsupportedImage value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnsupportedImage" />.</para>
            /// </summary>
            private class UnsupportedImageDecoder : enc.StructDecoder<UnsupportedImage>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnsupportedImage" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnsupportedImage Create()
                {
                    return new UnsupportedImage();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UnsupportedImage DecodeFields(enc.IJsonReader reader)
                {
                    return UnsupportedImage.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An error occurs during thumbnail conversion.</para>
        /// </summary>
        public sealed class ConversionError : ThumbnailError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ConversionError> Encoder = new ConversionErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ConversionError> Decoder = new ConversionErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ConversionError" />
            /// class.</para>
            /// </summary>
            private ConversionError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ConversionError</para>
            /// </summary>
            public static readonly ConversionError Instance = new ConversionError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ConversionError" />.</para>
            /// </summary>
            private class ConversionErrorEncoder : enc.StructEncoder<ConversionError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ConversionError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ConversionError" />.</para>
            /// </summary>
            private class ConversionErrorDecoder : enc.StructDecoder<ConversionError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ConversionError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ConversionError Create()
                {
                    return new ConversionError();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ConversionError DecodeFields(enc.IJsonReader reader)
                {
                    return ConversionError.Instance;
                }
            }

            #endregion
        }
    }
}
