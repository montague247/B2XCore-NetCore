using System;
using System.Runtime.Serialization;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreClient.
    /// </summary>
    [DataContract(Namespace = Constants.CoreModelTypeNamespace)]
    public partial class B2XCoreClient : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreClient"/> class.
        /// </summary>
        public B2XCoreClient()
            : base(typeof(B2XCoreClientHistory))
        {
        }

        /// <summary>
        /// Gets or sets the ClientID.
        /// </summary>
        /// <value>
        /// The ClientID.
        /// </value>
        [DataMember]
        public int ClientId { get; set; }

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

        /// <summary>
        /// Gets or sets the ApplicationID.
        /// </summary>
        /// <value>
        /// The ApplicationID.
        /// </value>
        [DataMember]
        public int ApplicationId { get; set; }
    }
}