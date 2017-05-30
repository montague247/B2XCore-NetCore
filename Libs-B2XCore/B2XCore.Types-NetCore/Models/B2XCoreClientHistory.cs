namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreClientHistory.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreClientHistory : ChangeHistory
    {
        /// <summary>
        /// Gets or sets the ClientID.
        /// </summary>
        /// <value>
        /// The ClientID.
        /// </value>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public Guid UniqueKey { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationID.
        /// </summary>
        /// <value>
        /// The ApplicationID.
        /// </value>
        public int ApplicationId { get; set; }
    }
}