namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreImplementationHistory.
    /// </summary>
    public partial class B2XCoreImplementationHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the ImplementationID.
        /// </summary>
        /// <value>
        /// The ImplementationID.
        /// </value>
        public int ImplementationID { get; set; }

        /// <summary>
        /// Gets or sets the TypeName.
        /// </summary>
        /// <value>
        /// The TypeName.
        /// </value>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the InterfaceName.
        /// </summary>
        /// <value>
        /// The InterfaceName.
        /// </value>
        public string InterfaceName { get; set; }
    }
}