namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreSetting.
    /// </summary>
    public partial class B2XCoreSetting : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreSetting"/> class.
        /// </summary>
        public B2XCoreSetting()
            : base(typeof(B2XCoreSettingHistory))
        {
        }

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

        /// <summary>
        /// Gets or sets the B2XCoreClient.
        /// </summary>
        /// <value>
        /// The B2XCoreClient.
        /// </value>
        public virtual B2XCoreClient B2XCoreClient { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreInstance.
        /// </summary>
        /// <value>
        /// The B2XCoreInstance.
        /// </value>
        public virtual B2XCoreInstance B2XCoreInstance { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreMachine.
        /// </summary>
        /// <value>
        /// The B2XCoreMachine.
        /// </value>
        public virtual B2XCoreMachine B2XCoreMachine { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSettingDefinition.
        /// </summary>
        /// <value>
        /// The B2XCoreSettingDefinition.
        /// </value>
        public virtual B2XCoreSettingDefinition B2XCoreSettingDefinition { get; set; }
    }
}