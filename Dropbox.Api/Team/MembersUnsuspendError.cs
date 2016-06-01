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
    /// <para>The members unsuspend error object</para>
    /// </summary>
    public class MembersUnsuspendError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersUnsuspendError> Encoder = new MembersUnsuspendErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersUnsuspendError> Decoder = new MembersUnsuspendErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersUnsuspendError" />
        /// class.</para>
        /// </summary>
        public MembersUnsuspendError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// UnsuspendNonSuspendedMember</para>
        /// </summary>
        public bool IsUnsuspendNonSuspendedMember
        {
            get
            {
                return this is UnsuspendNonSuspendedMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsuspendNonSuspendedMember, or <c>null</c>.</para>
        /// </summary>
        public UnsuspendNonSuspendedMember AsUnsuspendNonSuspendedMember
        {
            get
            {
                return this as UnsuspendNonSuspendedMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamLicenseLimit</para>
        /// </summary>
        public bool IsTeamLicenseLimit
        {
            get
            {
                return this is TeamLicenseLimit;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamLicenseLimit, or <c>null</c>.</para>
        /// </summary>
        public TeamLicenseLimit AsTeamLicenseLimit
        {
            get
            {
                return this as TeamLicenseLimit;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserNotInTeam</para>
        /// </summary>
        public bool IsUserNotInTeam
        {
            get
            {
                return this is UserNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserNotInTeam, or <c>null</c>.</para>
        /// </summary>
        public UserNotInTeam AsUserNotInTeam
        {
            get
            {
                return this as UserNotInTeam;
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
        /// <para>Encoder for  <see cref="MembersUnsuspendError" />.</para>
        /// </summary>
        private class MembersUnsuspendErrorEncoder : enc.StructEncoder<MembersUnsuspendError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersUnsuspendError value, enc.IJsonWriter writer)
            {
                if (value is UnsuspendNonSuspendedMember)
                {
                    WriteProperty(".tag", "unsuspend_non_suspended_member", writer, enc.StringEncoder.Instance);
                    UnsuspendNonSuspendedMember.Encoder.EncodeFields((UnsuspendNonSuspendedMember)value, writer);
                    return;
                }
                if (value is TeamLicenseLimit)
                {
                    WriteProperty(".tag", "team_license_limit", writer, enc.StringEncoder.Instance);
                    TeamLicenseLimit.Encoder.EncodeFields((TeamLicenseLimit)value, writer);
                    return;
                }
                if (value is UserNotInTeam)
                {
                    WriteProperty(".tag", "user_not_in_team", writer, enc.StringEncoder.Instance);
                    UserNotInTeam.Encoder.EncodeFields((UserNotInTeam)value, writer);
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
        /// <para>Decoder for  <see cref="MembersUnsuspendError" />.</para>
        /// </summary>
        private class MembersUnsuspendErrorDecoder : enc.UnionDecoder<MembersUnsuspendError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersUnsuspendError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersUnsuspendError Create()
            {
                return new MembersUnsuspendError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MembersUnsuspendError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "unsuspend_non_suspended_member":
                        return UnsuspendNonSuspendedMember.Decoder.DecodeFields(reader);
                    case "team_license_limit":
                        return TeamLicenseLimit.Decoder.DecodeFields(reader);
                    case "user_not_in_team":
                        return UserNotInTeam.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The user is unsuspended, so it cannot be unsuspended again.</para>
        /// </summary>
        public sealed class UnsuspendNonSuspendedMember : MembersUnsuspendError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnsuspendNonSuspendedMember> Encoder = new UnsuspendNonSuspendedMemberEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnsuspendNonSuspendedMember> Decoder = new UnsuspendNonSuspendedMemberDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsuspendNonSuspendedMember"
            /// /> class.</para>
            /// </summary>
            private UnsuspendNonSuspendedMember()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsuspendNonSuspendedMember</para>
            /// </summary>
            public static readonly UnsuspendNonSuspendedMember Instance = new UnsuspendNonSuspendedMember();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnsuspendNonSuspendedMember" />.</para>
            /// </summary>
            private class UnsuspendNonSuspendedMemberEncoder : enc.StructEncoder<UnsuspendNonSuspendedMember>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnsuspendNonSuspendedMember value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnsuspendNonSuspendedMember" />.</para>
            /// </summary>
            private class UnsuspendNonSuspendedMemberDecoder : enc.StructDecoder<UnsuspendNonSuspendedMember>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnsuspendNonSuspendedMember"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnsuspendNonSuspendedMember Create()
                {
                    return new UnsuspendNonSuspendedMember();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UnsuspendNonSuspendedMember DecodeFields(enc.IJsonReader reader)
                {
                    return UnsuspendNonSuspendedMember.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Team is full. The organization has no available licenses.</para>
        /// </summary>
        public sealed class TeamLicenseLimit : MembersUnsuspendError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamLicenseLimit> Encoder = new TeamLicenseLimitEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamLicenseLimit> Decoder = new TeamLicenseLimitDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamLicenseLimit" />
            /// class.</para>
            /// </summary>
            private TeamLicenseLimit()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamLicenseLimit</para>
            /// </summary>
            public static readonly TeamLicenseLimit Instance = new TeamLicenseLimit();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamLicenseLimit" />.</para>
            /// </summary>
            private class TeamLicenseLimitEncoder : enc.StructEncoder<TeamLicenseLimit>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamLicenseLimit value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamLicenseLimit" />.</para>
            /// </summary>
            private class TeamLicenseLimitDecoder : enc.StructDecoder<TeamLicenseLimit>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamLicenseLimit" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamLicenseLimit Create()
                {
                    return new TeamLicenseLimit();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override TeamLicenseLimit DecodeFields(enc.IJsonReader reader)
                {
                    return TeamLicenseLimit.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The user is not a member of the team.</para>
        /// </summary>
        public sealed class UserNotInTeam : MembersUnsuspendError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserNotInTeam> Encoder = new UserNotInTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserNotInTeam> Decoder = new UserNotInTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserNotInTeam" />
            /// class.</para>
            /// </summary>
            private UserNotInTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UserNotInTeam</para>
            /// </summary>
            public static readonly UserNotInTeam Instance = new UserNotInTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserNotInTeam" />.</para>
            /// </summary>
            private class UserNotInTeamEncoder : enc.StructEncoder<UserNotInTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserNotInTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserNotInTeam" />.</para>
            /// </summary>
            private class UserNotInTeamDecoder : enc.StructDecoder<UserNotInTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserNotInTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserNotInTeam Create()
                {
                    return new UserNotInTeam();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UserNotInTeam DecodeFields(enc.IJsonReader reader)
                {
                    return UserNotInTeam.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : MembersUnsuspendError
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
