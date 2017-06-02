using System;
using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreSettingDefinition.
    /// </summary>
    public partial class B2XCoreSettingDefinition : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreSettingDefinition"/> class.
        /// </summary>
        public B2XCoreSettingDefinition()
            : base(typeof(B2XCoreSettingDefinitionHistory))
        {
            this.B2XCoreSetting = new List<B2XCoreSetting>();
        }

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

        /// <summary>
        /// Gets or sets the B2XCoreSetting.
        /// </summary>
        /// <value>
        /// The B2XCoreSetting.
        /// </value>
        public virtual ICollection<B2XCoreSetting> B2XCoreSetting { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSettingDefinition1.
        /// </summary>
        /// <value>
        /// The B2XCoreSettingDefinition1.
        /// </value>
        public virtual B2XCoreSettingDefinition B2XCoreSettingDefinition1 { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSettingDefinition2.
        /// </summary>
        /// <value>
        /// The B2XCoreSettingDefinition2.
        /// </value>
        public virtual B2XCoreSettingDefinition B2XCoreSettingDefinition2 { get; set; }
    }
}