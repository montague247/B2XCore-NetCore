namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreInstanceHistory.
    /// </summary>
    public partial class B2XCoreInstanceHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the InstanceID.
        /// </summary>
        /// <value>
        /// The InstanceID.
        /// </value>
        public int InstanceID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationName.
        /// </summary>
        /// <value>
        /// The ApplicationName.
        /// </value>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the InstanceName.
        /// </summary>
        /// <value>
        /// The InstanceName.
        /// </value>
        public string InstanceName { get; set; }
    }
}