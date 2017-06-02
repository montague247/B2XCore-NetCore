using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreMachine.
    /// </summary>
    public partial class B2XCoreMachine : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreMachine"/> class.
        /// </summary>
        public B2XCoreMachine()
            : base(typeof(B2XCoreMachineHistory))
        {
            this.B2XCoreInstanceActivity = new List<B2XCoreInstanceActivity>();
            this.B2XCoreSetting = new List<B2XCoreSetting>();
        }

        /// <summary>
        /// Gets or sets the MachineID.
        /// </summary>
        /// <value>
        /// The MachineID.
        /// </value>
        public int MachineID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

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