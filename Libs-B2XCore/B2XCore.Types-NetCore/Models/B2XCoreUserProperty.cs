#region License & Copyright

// B2XCore - A framework for smart applications
// Copyright � 2017 Dirk Helbig
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
    /// Entry of table B2XCoreUserProperty.
    /// </summary>
    public partial class B2XCoreUserProperty : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUserProperty"/> class.
        /// </summary>
        public B2XCoreUserProperty()
            : base(typeof(B2XCoreUserPropertyHistory))
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
        /// Gets or sets the UserPropertyDefinitionID.
        /// </summary>
        /// <value>
        /// The UserPropertyDefinitionID.
        /// </value>
        public int UserPropertyDefinitionID { get; set; }

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
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUser.
        /// </summary>
        /// <value>
        /// The B2XCoreUser.
        /// </value>
        public virtual B2XCoreUser B2XCoreUser { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUserPropertyDefinition.
        /// </summary>
        /// <value>
        /// The B2XCoreUserPropertyDefinition.
        /// </value>
        public virtual B2XCoreUserPropertyDefinition B2XCoreUserPropertyDefinition { get; set; }
    }
}