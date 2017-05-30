using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreClientLanguageHistory.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreClientLanguageHistory : ChangeHistory
    {
		/// <summary>
		/// Gets or sets the ClientID.
		/// </summary>
		/// <value>
		/// The ClientID.
		/// </value>
		[DataMember]
		public int ClientId { get; set; }

		/// <summary>
		/// Gets or sets the LanguageID.
		/// </summary>
		/// <value>
		/// The LanguageID.
		/// </value>
		[DataMember]
		public int LanguageId { get; set; }

		/// <summary>
		/// Gets or sets the IsEnabled.
		/// </summary>
		/// <value>
		/// The IsEnabled.
		/// </value>
		[DataMember]
		public bool IsEnabled { get; set; }
    }
}