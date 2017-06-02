namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserProperty.
    /// </summary>
    public partial class B2XCoreUserProperty : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUserProperty"/> class.
        /// </summary>
        public B2XCoreUserProperty()
            : base(typeof(B2XCoreUserPropertyHistory))
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
        /// Gets or sets the UserPropertyDefinitionID.
        /// </summary>
        /// <value>
        /// The UserPropertyDefinitionID.
        /// </value>
        public int UserPropertyDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the IsPublic.
        /// </summary>
        /// <value>
        /// The IsPublic.
        /// </value>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUser.
        /// </summary>
        /// <value>
        /// The B2XCoreUser.
        /// </value>
        public virtual B2XCoreUser B2XCoreUser { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUserPropertyDefinition.
        /// </summary>
        /// <value>
        /// The B2XCoreUserPropertyDefinition.
        /// </value>
        public virtual B2XCoreUserPropertyDefinition B2XCoreUserPropertyDefinition { get; set; }
    }
}