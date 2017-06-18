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

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUserGroup.
    /// </summary>
    public partial class B2XCoreUserGroup : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUserGroup"/> class.
        /// </summary>
        public B2XCoreUserGroup()
            : base(typeof(B2XCoreUserGroupHistory))
        {
        }

        /// <summary>
        /// Gets or sets the UserID.
        /// </summary>
        /// <value>
        /// The UserID.
        /// </value>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the GroupID.
        /// </summary>
        /// <value>
        /// The GroupID.
        /// </value>
        public int GroupID { get; set; }

        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreGroup.
        /// </summary>
        /// <value>
        /// The B2XCoreGroup.
        /// </value>
        public virtual B2XCoreGroup B2XCoreGroup { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUser.
        /// </summary>
        /// <value>
        /// The B2XCoreUser.
        /// </value>
        public virtual B2XCoreUser B2XCoreUser { get; set; }
    }
}