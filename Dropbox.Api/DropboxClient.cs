// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api
{
    using sys = System;

    using Dropbox.Api.Stone;
    using Dropbox.Api.Auth.Routes;
    using Dropbox.Api.Files.Routes;
    using Dropbox.Api.Sharing.Routes;
    using Dropbox.Api.Users.Routes;

    public sealed partial class DropboxClient
    {
        /// <summary>
        /// <para>Gets the Auth routes.</para>
        /// </summary>
        public AuthRoutes Auth { get; private set; }

        /// <summary>
        /// <para>Gets the Files routes.</para>
        /// </summary>
        public FilesRoutes Files { get; private set; }

        /// <summary>
        /// <para>Gets the Sharing routes.</para>
        /// </summary>
        public SharingRoutes Sharing { get; private set; }

        /// <summary>
        /// <para>Gets the Users routes.</para>
        /// </summary>
        public UsersRoutes Users { get; private set; }

        /// <summary>
        /// <para>Initializes the routes.</para>
        /// </summary>
        /// <returns>The transport.</returns>
        private void InitializeRoutes(ITransport transport)
        {
            this.Auth = new AuthRoutes(transport);
            this.Files = new FilesRoutes(transport);
            this.Sharing = new SharingRoutes(transport);
            this.Users = new UsersRoutes(transport);
        }
    }
}
