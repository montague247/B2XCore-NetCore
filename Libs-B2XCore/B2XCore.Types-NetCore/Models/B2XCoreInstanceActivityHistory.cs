using System;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreInstanceActivityHistory.
    /// </summary>
    public partial class B2XCoreInstanceActivityHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the InstanceID.
        /// </summary>
        /// <value>
        /// The InstanceID.
        /// </value>
        public int InstanceID { get; set; }

        /// <summary>
        /// Gets or sets the MachineID.
        /// </summary>
        /// <value>
        /// The MachineID.
        /// </value>
        public int MachineID { get; set; }

        /// <summary>
        /// Gets or sets the ProcessID.
        /// </summary>
        /// <value>
        /// The ProcessID.
        /// </value>
        public int ProcessID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the start date UTC.
        /// </summary>
        /// <value>
        /// The start date UTC.
        /// </value>
        public System.DateTime StartDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the end date UTC.
        /// </summary>
        /// <value>
        /// The end date UTC.
        /// </value>
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the last is alive UTC.
        /// </summary>
        /// <value>
        /// The last is alive UTC.
        /// </value>
        public DateTime? LastIsAliveUtc { get; set; }

        /// <summary>
        /// Gets or sets the ClientIP.
        /// </summary>
        /// <value>
        /// The ClientIP.
        /// </value>
        public string ClientIP { get; set; }
    }
}