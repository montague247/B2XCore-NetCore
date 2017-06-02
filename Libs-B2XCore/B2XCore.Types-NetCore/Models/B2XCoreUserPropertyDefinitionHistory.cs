namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserPropertyDefinitionHistory.
    /// </summary>
    public partial class B2XCoreUserPropertyDefinitionHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the UserPropertyDefinitionID.
        /// </summary>
        /// <value>
        /// The UserPropertyDefinitionID.
        /// </value>
        public int UserPropertyDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        /// <value>
        /// The Key.
        /// </value>
        public string Key { get; set; }

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
        /// Gets or sets the AddOnUserCreation.
        /// </summary>
        /// <value>
        /// The AddOnUserCreation.
        /// </value>
        public bool AddOnUserCreation { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }
    }
}