namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserPropertyHistory.
    /// </summary>
    public partial class B2XCoreUserPropertyHistory : B2XCore.Models.ChangeHistory
    {
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
    }
}