using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreResourceValue.
    /// </summary>
    public partial class B2XCoreResourceValue : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreResourceValue"/> class.
        /// </summary>
        public B2XCoreResourceValue()
            : base(typeof(B2XCoreResourceValueHistory))
        {
            this.B2XCoreResourceResourceValue = new List<B2XCoreResourceResourceValue>();
        }

        /// <summary>
        /// Gets or sets the ResourceValueID.
        /// </summary>
        /// <value>
        /// The ResourceValueID.
        /// </value>
        public long ResourceValueID { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResourceResourceValue.
        /// </summary>
        /// <value>
        /// The B2XCoreResourceResourceValue.
        /// </value>
        public virtual ICollection<B2XCoreResourceResourceValue> B2XCoreResourceResourceValue { get; set; }
    }
}