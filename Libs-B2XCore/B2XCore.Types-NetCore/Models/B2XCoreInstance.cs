using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreInstance.
    /// </summary>
    public partial class B2XCoreInstance : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreInstance"/> class.
        /// </summary>
        public B2XCoreInstance()
            : base(typeof(B2XCoreInstanceHistory))
        {
            this.B2XCoreInstanceActivity = new List<B2XCoreInstanceActivity>();
            this.B2XCoreSetting = new List<B2XCoreSetting>();
        }

        /// <summary>
        /// Gets or sets the InstanceID.
        /// </summary>
        /// <value>
        /// The InstanceID.
        /// </value>
        public int InstanceID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationName.
        /// </summary>
        /// <value>
        /// The ApplicationName.
        /// </value>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the InstanceName.
        /// </summary>
        /// <value>
        /// The InstanceName.
        /// </value>
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreInstanceActivity.
        /// </summary>
        /// <value>
        /// The B2XCoreInstanceActivity.
        /// </value>
        public virtual ICollection<B2XCoreInstanceActivity> B2XCoreInstanceActivity { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSetting.
        /// </summary>
        /// <value>
        /// The B2XCoreSetting.
        /// </value>
        public virtual ICollection<B2XCoreSetting> B2XCoreSetting { get; set; }
    }
}