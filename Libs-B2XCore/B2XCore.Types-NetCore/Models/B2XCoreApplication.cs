using System;
using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreApplication.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreApplication : ChangeTracking
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="B2XCoreApplication"/> class.
		/// </summary>
		public B2XCoreApplication()
            : base(typeof(B2XCoreApplicationHistory))
        {
        }

		/// <summary>
		/// Gets or sets the ApplicationID.
		/// </summary>
		/// <value>
		/// The ApplicationID.
		/// </value>
		[DataMember]
		public int ApplicationId { get; set; }

		/// <summary>
		/// Gets or sets the UniqueID.
		/// </summary>
		/// <value>
		/// The UniqueID.
		/// </value>
		[DataMember]
		public Guid UniqueKey { get; set; }

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