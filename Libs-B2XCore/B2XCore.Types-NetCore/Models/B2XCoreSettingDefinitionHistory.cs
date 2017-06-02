using System;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreSettingDefinitionHistory.
    /// </summary>
    public partial class B2XCoreSettingDefinitionHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the SettingDefinitionID.
        /// </summary>
        /// <value>
        /// The SettingDefinitionID.
        /// </value>
        public int SettingDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the ParentSettingDefinitionID.
        /// </summary>
        /// <value>
        /// The ParentSettingDefinitionID.
        /// </value>
        public int? ParentSettingDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the changed UTC.
        /// </summary>
        /// <value>
        /// The changed UTC.
        /// </value>
        public DateTime? ChangedUtc { get; set; }
    }
}