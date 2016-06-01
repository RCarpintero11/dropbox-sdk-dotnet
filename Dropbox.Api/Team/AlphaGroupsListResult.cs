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
    /// <para>The alpha groups list result object</para>
    /// </summary>
    public class AlphaGroupsListResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AlphaGroupsListResult> Encoder = new AlphaGroupsListResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AlphaGroupsListResult> Decoder = new AlphaGroupsListResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AlphaGroupsListResult" />
        /// class.</para>
        /// </summary>
        /// <param name="groups">The groups</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.AlphaGroupsListContinueAsync" /> to obtain
        /// the additional groups.</param>
        /// <param name="hasMore">Is true if there are additional groups that have not been
        /// returned yet. An additional call to <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.AlphaGroupsListContinueAsync" /> can
        /// retrieve them.</param>
        public AlphaGroupsListResult(col.IEnumerable<Dropbox.Api.TeamCommon.AlphaGroupSummary> groups,
                                     string cursor,
                                     bool hasMore)
        {
            var groupsList = enc.Util.ToList(groups);

            if (groups == null)
            {
                throw new sys.ArgumentNullException("groups");
            }

            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Groups = groupsList;
            this.Cursor = cursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AlphaGroupsListResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public AlphaGroupsListResult()
        {
        }

        /// <summary>
        /// <para>Gets the groups of the alpha groups list result</para>
        /// </summary>
        public col.IList<Dropbox.Api.TeamCommon.AlphaGroupSummary> Groups { get; protected set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.AlphaGroupsListContinueAsync" /> to obtain
        /// the additional groups.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        /// <summary>
        /// <para>Is true if there are additional groups that have not been returned yet. An
        /// additional call to <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.AlphaGroupsListContinueAsync" /> can
        /// retrieve them.</para>
        /// </summary>
        public bool HasMore { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AlphaGroupsListResult" />.</para>
        /// </summary>
        private class AlphaGroupsListResultEncoder : enc.StructEncoder<AlphaGroupsListResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AlphaGroupsListResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("groups", value.Groups, writer, Dropbox.Api.TeamCommon.AlphaGroupSummary.Encoder);
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                WriteProperty("has_more", value.HasMore, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AlphaGroupsListResult" />.</para>
        /// </summary>
        private class AlphaGroupsListResultDecoder : enc.StructDecoder<AlphaGroupsListResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AlphaGroupsListResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AlphaGroupsListResult Create()
            {
                return new AlphaGroupsListResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AlphaGroupsListResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "groups":
                        value.Groups = ReadList<Dropbox.Api.TeamCommon.AlphaGroupSummary>(reader, Dropbox.Api.TeamCommon.AlphaGroupSummary.Decoder);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "has_more":
                        value.HasMore = enc.BooleanDecoder.Instance.Decode(reader);
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
