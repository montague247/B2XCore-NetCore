using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreDomainResourceHistory.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreDomainResourceHistory : ChangeHistory
    {
		/// <summary>
		/// Gets or sets the DomainResourceID.
		/// </summary>
		/// <value>
		/// The DomainResourceID.
		/// </value>
		[DataMember]
		public int DomainResourceId { get; set; }

		/// <summary>
		/// Gets or sets the DomainID.
		/// </summary>
		/// <value>
		/// The DomainID.
		/// </value>
		[DataMember]
		public int DomainId { get; set; }

		/// <summary>
		/// Gets or sets the Name.
		/// </summary>
		/// <value>
		/// The Name.
		/// </value>
		[DataMember]
		public string Name { get; set; }
    }
}