namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreMachineHistory.
    /// </summary>
    public partial class B2XCoreMachineHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the MachineID.
        /// </summary>
        /// <value>
        /// The MachineID.
        /// </value>
        public int MachineID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }
    }
}