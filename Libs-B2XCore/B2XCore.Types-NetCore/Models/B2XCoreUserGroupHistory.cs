namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserGroupHistory.
    /// </summary>
    public partial class B2XCoreUserGroupHistory : B2XCore.Models.ChangeHistory
    {
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
    }
}