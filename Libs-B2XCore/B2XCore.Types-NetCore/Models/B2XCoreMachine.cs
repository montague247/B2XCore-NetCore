#region License & Copyright

// B2XCore - A framework for smart applications
// Copyright © 2017 Dirk Helbig
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Dirk Helbig (montague247@users.sourceforge.net)

#endregion License & Copyright

using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreMachine.
    /// </summary>
    public partial class B2XCoreMachine : ChangeTracking
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