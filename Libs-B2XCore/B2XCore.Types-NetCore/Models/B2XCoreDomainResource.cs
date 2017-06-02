using System.Collections.Generic;
using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreDomainResource.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreDomainResource : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreDomainResource"/> class.
        /// </summary>
        public B2XCoreDomainResource()
            : base(typeof(B2XCoreDomainResourceHistory))
        {
        }

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