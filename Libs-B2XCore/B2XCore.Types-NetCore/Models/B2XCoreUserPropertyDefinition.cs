using System;
using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserPropertyDefinition.
    /// </summary>
    public partial class B2XCoreUserPropertyDefinition : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUserPropertyDefinition"/> class.
        /// </summary>
        public B2XCoreUserPropertyDefinition()
            : base(typeof(B2XCoreUserPropertyDefinitionHistory))
        {
            this.B2XCoreUserProperty = new List<B2XCoreUserProperty>();
        }

        /// <summary>
        /// Gets or sets the UserPropertyDefinitionID.
        /// </summary>
        /// <value>
        /// The UserPropertyDefinitionID.
        /// </value>
        public int UserPropertyDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        /// <value>
        /// The Key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the IsPublic.
        /// </summary>
        /// <value>
        /// The IsPublic.
        /// </value>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Gets or sets the AddOnUserCreation.
        /// </summary>
        /// <value>
        /// The AddOnUserCreation.
        /// </value>
        public bool AddOnUserCreation { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUserProperty.
        /// </summary>
        /// <value>
        /// The B2XCoreUserProperty.
        /// </value>
        public virtual ICollection<B2XCoreUserProperty> B2XCoreUserProperty { get; set; }
    }
}