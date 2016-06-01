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
    /// <para>The remove folder member error object</para>
    /// </summary>
    public class RemoveFolderMemberError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemoveFolderMemberError> Encoder = new RemoveFolderMemberErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemoveFolderMemberError> Decoder = new RemoveFolderMemberErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemoveFolderMemberError" />
        /// class.</para>
        /// </summary>
        public RemoveFolderMemberError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccessError</para>
        /// </summary>
        public bool IsAccessError
        {
            get
            {
                return this is AccessError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccessError, or <c>null</c>.</para>
        /// </summary>
        public AccessError AsAccessError
        {
            get
            {
                return this as AccessError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MemberError</para>
        /// </summary>
        public bool IsMemberError
        {
            get
            {
                return this is MemberError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MemberError, or <c>null</c>.</para>
        /// </summary>
        public MemberError AsMemberError
        {
            get
            {
                return this as MemberError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FolderOwner</para>
        /// </summary>
        public bool IsFolderOwner
        {
            get
            {
                return this is FolderOwner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FolderOwner, or <c>null</c>.</para>
        /// </summary>
        public FolderOwner AsFolderOwner
        {
            get
            {
                return this as FolderOwner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupAccess</para>
        /// </summary>
        public bool IsGroupAccess
        {
            get
            {
                return this is GroupAccess;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupAccess, or <c>null</c>.</para>
        /// </summary>
        public GroupAccess AsGroupAccess
        {
            get
            {
                return this as GroupAccess;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamFolder</para>
        /// </summary>
        public bool IsTeamFolder
        {
            get
            {
                return this is TeamFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamFolder, or <c>null</c>.</para>
        /// </summary>
        public TeamFolder AsTeamFolder
        {
            get
            {
                return this as TeamFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
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
        /// <para>Encoder for  <see cref="RemoveFolderMemberError" />.</para>
        /// </summary>
        private class RemoveFolderMemberErrorEncoder : enc.StructEncoder<RemoveFolderMemberError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemoveFolderMemberError value, enc.IJsonWriter writer)
            {
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is MemberError)
                {
                    WriteProperty(".tag", "member_error", writer, enc.StringEncoder.Instance);
                    MemberError.Encoder.EncodeFields((MemberError)value, writer);
                    return;
                }
                if (value is FolderOwner)
                {
                    WriteProperty(".tag", "folder_owner", writer, enc.StringEncoder.Instance);
                    FolderOwner.Encoder.EncodeFields((FolderOwner)value, writer);
                    return;
                }
                if (value is GroupAccess)
                {
                    WriteProperty(".tag", "group_access", writer, enc.StringEncoder.Instance);
                    GroupAccess.Encoder.EncodeFields((GroupAccess)value, writer);
                    return;
                }
                if (value is TeamFolder)
                {
                    WriteProperty(".tag", "team_folder", writer, enc.StringEncoder.Instance);
                    TeamFolder.Encoder.EncodeFields((TeamFolder)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
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
        /// <para>Decoder for  <see cref="RemoveFolderMemberError" />.</para>
        /// </summary>
        private class RemoveFolderMemberErrorDecoder : enc.UnionDecoder<RemoveFolderMemberError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemoveFolderMemberError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemoveFolderMemberError Create()
            {
                return new RemoveFolderMemberError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RemoveFolderMemberError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "member_error":
                        return MemberError.Decoder.DecodeFields(reader);
                    case "folder_owner":
                        return FolderOwner.Decoder.DecodeFields(reader);
                    case "group_access":
                        return GroupAccess.Decoder.DecodeFields(reader);
                    case "team_folder":
                        return TeamFolder.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : RemoveFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccessError> Encoder = new AccessErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccessError> Decoder = new AccessErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AccessError(SharedFolderAccessError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            private AccessError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharedFolderAccessError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorEncoder : enc.StructEncoder<AccessError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccessError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Sharing.SharedFolderAccessError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorDecoder : enc.StructDecoder<AccessError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccessError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccessError Create()
                {
                    return new AccessError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AccessError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "access_error":
                            value.Value = Dropbox.Api.Sharing.SharedFolderAccessError.Decoder.Decode(reader);
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
        /// <para>The member error object</para>
        /// </summary>
        public sealed class MemberError : RemoveFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MemberError> Encoder = new MemberErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MemberError> Decoder = new MemberErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MemberError(SharedFolderMemberError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberError" />
            /// class.</para>
            /// </summary>
            private MemberError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharedFolderMemberError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MemberError" />.</para>
            /// </summary>
            private class MemberErrorEncoder : enc.StructEncoder<MemberError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MemberError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Sharing.SharedFolderMemberError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MemberError" />.</para>
            /// </summary>
            private class MemberErrorDecoder : enc.StructDecoder<MemberError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MemberError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MemberError Create()
                {
                    return new MemberError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(MemberError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "member_error":
                            value.Value = Dropbox.Api.Sharing.SharedFolderMemberError.Decoder.Decode(reader);
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
        /// <para>The target user is the owner of the shared folder. You can't remove this user
        /// until ownership has been transferred to another member.</para>
        /// </summary>
        public sealed class FolderOwner : RemoveFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FolderOwner> Encoder = new FolderOwnerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FolderOwner> Decoder = new FolderOwnerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FolderOwner" />
            /// class.</para>
            /// </summary>
            private FolderOwner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FolderOwner</para>
            /// </summary>
            public static readonly FolderOwner Instance = new FolderOwner();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FolderOwner" />.</para>
            /// </summary>
            private class FolderOwnerEncoder : enc.StructEncoder<FolderOwner>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FolderOwner value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FolderOwner" />.</para>
            /// </summary>
            private class FolderOwnerDecoder : enc.StructDecoder<FolderOwner>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FolderOwner" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FolderOwner Create()
                {
                    return new FolderOwner();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override FolderOwner DecodeFields(enc.IJsonReader reader)
                {
                    return FolderOwner.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The target user has access to the shared folder via a group.</para>
        /// </summary>
        public sealed class GroupAccess : RemoveFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupAccess> Encoder = new GroupAccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupAccess> Decoder = new GroupAccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupAccess" />
            /// class.</para>
            /// </summary>
            private GroupAccess()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupAccess</para>
            /// </summary>
            public static readonly GroupAccess Instance = new GroupAccess();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupAccess" />.</para>
            /// </summary>
            private class GroupAccessEncoder : enc.StructEncoder<GroupAccess>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupAccess value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupAccess" />.</para>
            /// </summary>
            private class GroupAccessDecoder : enc.StructDecoder<GroupAccess>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupAccess" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupAccess Create()
                {
                    return new GroupAccess();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupAccess DecodeFields(enc.IJsonReader reader)
                {
                    return GroupAccess.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>This action cannot be performed on a team shared folder.</para>
        /// </summary>
        public sealed class TeamFolder : RemoveFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamFolder> Encoder = new TeamFolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamFolder> Decoder = new TeamFolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamFolder" /> class.</para>
            /// </summary>
            private TeamFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamFolder</para>
            /// </summary>
            public static readonly TeamFolder Instance = new TeamFolder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamFolder" />.</para>
            /// </summary>
            private class TeamFolderEncoder : enc.StructEncoder<TeamFolder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamFolder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamFolder" />.</para>
            /// </summary>
            private class TeamFolderDecoder : enc.StructDecoder<TeamFolder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamFolder" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamFolder Create()
                {
                    return new TeamFolder();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override TeamFolder DecodeFields(enc.IJsonReader reader)
                {
                    return TeamFolder.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The current user does not have permission to perform this action.</para>
        /// </summary>
        public sealed class NoPermission : RemoveFolderMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return new NoPermission();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoPermission DecodeFields(enc.IJsonReader reader)
                {
                    return NoPermission.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : RemoveFolderMemberError
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
