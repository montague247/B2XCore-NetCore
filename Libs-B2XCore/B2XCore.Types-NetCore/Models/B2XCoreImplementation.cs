using System;
using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreImplementation.
    /// </summary>
    public partial class B2XCoreImplementation : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreImplementation"/> class.
        /// </summary>
        public B2XCoreImplementation()
            : base(typeof(B2XCoreImplementationHistory))
        {
            this.B2XCoreDomain = new List<B2XCoreDomain>();
        }

        /// <summary>
        /// Gets or sets the ImplementationID.
        /// </summary>
        /// <value>
        /// The ImplementationID.
        /// </value>
        public int ImplementationID { get; set; }

        /// <summary>
        /// Gets or sets the TypeName.
        /// </summary>
        /// <value>
        /// The TypeName.
        /// </value>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the InterfaceName.
        /// </summary>
        /// <value>
        /// The InterfaceName.
        /// </value>
        public string InterfaceName { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreDomain.
        /// </summary>
        /// <value>
        /// The B2XCoreDomain.
        /// </value>
        public virtual ICollection<B2XCoreDomain> B2XCoreDomain { get; set; }
    }
}