namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreResourceResourceValueHistory.
    /// </summary>
    public partial class B2XCoreResourceResourceValueHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the ResourceID.
        /// </summary>
        /// <value>
        /// The ResourceID.
        /// </value>
        public long ResourceID { get; set; }

        /// <summary>
        /// Gets or sets the LanguageID.
        /// </summary>
        /// <value>
        /// The LanguageID.
        /// </value>
        public int LanguageID { get; set; }

        /// <summary>
        /// Gets or sets the ClientID.
        /// </summary>
        /// <value>
        /// The ClientID.
        /// </value>
        public int ClientID { get; set; }

        /// <summary>
        /// Gets or sets the ResourceValueID.
        /// </summary>
        /// <value>
        /// The ResourceValueID.
        /// </value>
        public long ResourceValueID { get; set; }
    }
}