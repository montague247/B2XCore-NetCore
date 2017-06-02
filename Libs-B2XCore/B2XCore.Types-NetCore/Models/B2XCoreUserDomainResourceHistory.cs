namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserDomainResourceHistory.
    /// </summary>
    public partial class B2XCoreUserDomainResourceHistory : B2XCore.Models.ChangeHistory
    {
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
    }
}