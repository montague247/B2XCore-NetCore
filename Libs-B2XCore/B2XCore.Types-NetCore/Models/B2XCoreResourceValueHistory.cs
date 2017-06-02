namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreResourceValueHistory.
    /// </summary>
    public partial class B2XCoreResourceValueHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the ResourceValueID.
        /// </summary>
        /// <value>
        /// The ResourceValueID.
        /// </value>
        public long ResourceValueID { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        public string Value { get; set; }
    }
}