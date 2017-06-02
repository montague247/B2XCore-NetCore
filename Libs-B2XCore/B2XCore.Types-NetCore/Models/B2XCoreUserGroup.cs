namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserGroup.
    /// </summary>
    public partial class B2XCoreUserGroup : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUserGroup"/> class.
        /// </summary>
        public B2XCoreUserGroup()
            : base(typeof(B2XCoreUserGroupHistory))
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
        /// Gets or sets the GroupID.
        /// </summary>
        /// <value>
        /// The GroupID.
        /// </value>
        public int GroupID { get; set; }

        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreGroup.
        /// </summary>
        /// <value>
        /// The B2XCoreGroup.
        /// </value>
        public virtual B2XCoreGroup B2XCoreGroup { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUser.
        /// </summary>
        /// <value>
        /// The B2XCoreUser.
        /// </value>
        public virtual B2XCoreUser B2XCoreUser { get; set; }
    }
}