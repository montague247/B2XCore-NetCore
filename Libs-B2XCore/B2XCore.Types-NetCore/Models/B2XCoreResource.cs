using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreResource.
    /// </summary>
    public partial class B2XCoreResource : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreResource"/> class.
        /// </summary>
        public B2XCoreResource()
            : base(typeof(B2XCoreResourceHistory))
        {
            this.B2XCoreResourceResourceValue = new List<B2XCoreResourceResourceValue>();
        }

        /// <summary>
        /// Gets or sets the ResourceID.
        /// </summary>
        /// <value>
        /// The ResourceID.
        /// </value>
        public long ResourceID { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationID.
        /// </summary>
        /// <value>
        /// The ApplicationID.
        /// </value>
        public int ApplicationID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreApplication.
        /// </summary>
        /// <value>
        /// The B2XCoreApplication.
        /// </value>
        public virtual B2XCoreApplication B2XCoreApplication { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResourceResourceValue.
        /// </summary>
        /// <value>
        /// The B2XCoreResourceResourceValue.
        /// </value>
        public virtual ICollection<B2XCoreResourceResourceValue> B2XCoreResourceResourceValue { get; set; }
    }
}