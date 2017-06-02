namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreResourceHistory.
    /// </summary>
    public partial class B2XCoreResourceHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the ResourceID.
        /// </summary>
        /// <value>
        /// The ResourceID.
        /// </value>
        public long ResourceID { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationID.
        /// </summary>
        /// <value>
        /// The ApplicationID.
        /// </value>
        public int ApplicationID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }
    }
}