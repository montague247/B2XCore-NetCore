using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreGroupHistory.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreGroupHistory : ChangeHistory
    {
		/// <summary>
		/// Gets or sets the GroupID.
		/// </summary>
		/// <value>
		/// The GroupID.
		/// </value>
		[DataMember]
		public int GroupId { get; set; }

		/// <summary>
		/// Gets or sets the Name.
		/// </summary>
		/// <value>
		/// The Name.
		/// </value>
		[DataMember]
		public string Name { get; set; }

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