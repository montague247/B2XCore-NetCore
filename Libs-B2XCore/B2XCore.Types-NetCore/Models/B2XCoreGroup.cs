using System.Collections.Generic;
using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreGroup.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreGroup : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreGroup"/> class.
        /// </summary>
        public B2XCoreGroup()
            : base(typeof(B2XCoreGroupHistory))
        {
        }

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