namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreSettingHistory.
    /// </summary>
    public partial class B2XCoreSettingHistory : B2XCore.Models.ChangeHistory
    {
        /// <summary>
        /// Gets or sets the MachineID.
        /// </summary>
        /// <value>
        /// The MachineID.
        /// </value>
        public int MachineID { get; set; }

        /// <summary>
        /// Gets or sets the InstanceID.
        /// </summary>
        /// <value>
        /// The InstanceID.
        /// </value>
        public int InstanceID { get; set; }

        /// <summary>
        /// Gets or sets the ClientID.
        /// </summary>
        /// <value>
        /// The ClientID.
        /// </value>
        public int ClientID { get; set; }

        /// <summary>
        /// Gets or sets the SettingDefinitionID.
        /// </summary>
        /// <value>
        /// The SettingDefinitionID.
        /// </value>
        public int SettingDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the Arguments.
        /// </summary>
        /// <value>
        /// The Arguments.
        /// </value>
        public string Arguments { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        public string Value { get; set; }
    }
}