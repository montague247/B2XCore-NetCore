namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreResourceResourceValue.
    /// </summary>
    public partial class B2XCoreResourceResourceValue : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreResourceResourceValue"/> class.
        /// </summary>
        public B2XCoreResourceResourceValue()
            : base(typeof(B2XCoreResourceResourceValueHistory))
        {
        }

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

        /// <summary>
        /// Gets or sets the B2XCoreClient.
        /// </summary>
        /// <value>
        /// The B2XCoreClient.
        /// </value>
        public virtual B2XCoreClient B2XCoreClient { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreLanguage.
        /// </summary>
        /// <value>
        /// The B2XCoreLanguage.
        /// </value>
        public virtual B2XCoreLanguage B2XCoreLanguage { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResource.
        /// </summary>
        /// <value>
        /// The B2XCoreResource.
        /// </value>
        public virtual B2XCoreResource B2XCoreResource { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResourceValue.
        /// </summary>
        /// <value>
        /// The B2XCoreResourceValue.
        /// </value>
        public virtual B2XCoreResourceValue B2XCoreResourceValue { get; set; }
    }
}