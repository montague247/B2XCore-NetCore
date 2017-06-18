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
    /// Entry of table B2XCoreResource.
    /// </summary>
    public partial class B2XCoreResource : ChangeTracking
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