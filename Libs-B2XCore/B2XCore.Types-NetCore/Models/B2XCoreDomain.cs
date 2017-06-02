using System.Runtime.Serialization;

namespace B2XCore.Models
{
	/// <summary>
	/// Entry of table B2XCoreDomain.
	/// </summary>
	[DataContract(Namespace = Constants.CoreModelTypeNamespace)]
	public partial class B2XCoreDomain : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreDomain"/> class.
        /// </summary>
        public B2XCoreDomain()
            : base(typeof(B2XCoreDomainHistory))
        {
        }

		/// <summary>
		/// Gets or sets the domain identifier.
		/// </summary>
		/// <value>
		/// The domain identifier.
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

		/// <summary>
		/// Gets or sets the implementation identifier.
		/// </summary>
		/// <value>
		/// The implementation identifier.
		/// </value>
		[DataMember]
		public int ImplementationId { get; set; }

		/// <summary>
		/// Gets or sets the Path.
		/// </summary>
		/// <value>
		/// The Path.
		/// </value>
		[DataMember]
		public string Path { get; set; }

		/// <summary>
		/// Gets or sets the suffix.
		/// </summary>
		/// <value>
		/// The suffix.
		/// </value>
		[DataMember]
		public string Suffix { get; set; }

		/// <summary>
		/// Gets or sets the AuthGroup.
		/// </summary>
		/// <value>
		/// The AuthGroup.
		/// </value>
		[DataMember]
		public string AuthGroup { get; set; }
    }
}