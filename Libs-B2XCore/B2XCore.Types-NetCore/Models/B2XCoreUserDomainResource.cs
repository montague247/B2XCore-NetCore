namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserDomainResource.
    /// </summary>
    public partial class B2XCoreUserDomainResource : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUserDomainResource"/> class.
        /// </summary>
        public B2XCoreUserDomainResource()
            : base(typeof(B2XCoreUserDomainResourceHistory))
        {
        }

        /// <summary>
        /// Gets or sets the UserID.
        /// </summary>
        /// <value>
        /// The UserID.
        /// </value>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the DomainResourceID.
        /// </summary>
        /// <value>
        /// The DomainResourceID.
        /// </value>
        public int DomainResourceID { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreDomainResource.
        /// </summary>
        /// <value>
        /// The B2XCoreDomainResource.
        /// </value>
        public virtual B2XCoreDomainResource B2XCoreDomainResource { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUser.
        /// </summary>
        /// <value>
        /// The B2XCoreUser.
        /// </value>
        public virtual B2XCoreUser B2XCoreUser { get; set; }
    }
}