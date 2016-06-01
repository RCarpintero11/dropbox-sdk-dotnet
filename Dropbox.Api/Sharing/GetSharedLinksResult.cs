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
    /// <para>The get shared links result object</para>
    /// </summary>
    public class GetSharedLinksResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetSharedLinksResult> Encoder = new GetSharedLinksResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetSharedLinksResult> Decoder = new GetSharedLinksResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetSharedLinksResult" />
        /// class.</para>
        /// </summary>
        /// <param name="links">Shared links applicable to the path argument.</param>
        public GetSharedLinksResult(col.IEnumerable<LinkMetadata> links)
        {
            var linksList = enc.Util.ToList(links);

            if (links == null)
            {
                throw new sys.ArgumentNullException("links");
            }

            this.Links = linksList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetSharedLinksResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetSharedLinksResult()
        {
        }

        /// <summary>
        /// <para>Shared links applicable to the path argument.</para>
        /// </summary>
        public col.IList<LinkMetadata> Links { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetSharedLinksResult" />.</para>
        /// </summary>
        private class GetSharedLinksResultEncoder : enc.StructEncoder<GetSharedLinksResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetSharedLinksResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("links", value.Links, writer, Dropbox.Api.Sharing.LinkMetadata.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetSharedLinksResult" />.</para>
        /// </summary>
        private class GetSharedLinksResultDecoder : enc.StructDecoder<GetSharedLinksResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetSharedLinksResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetSharedLinksResult Create()
            {
                return new GetSharedLinksResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetSharedLinksResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "links":
                        value.Links = ReadList<LinkMetadata>(reader, Dropbox.Api.Sharing.LinkMetadata.Decoder);
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
