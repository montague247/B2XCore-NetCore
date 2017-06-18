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
    /// Entry of table B2XCoreResourceResourceValue.
    /// </summary>
    public partial class B2XCoreResourceResourceValue : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreResourceResourceValue"/> class.
        /// </summary>
        public B2XCoreResourceResourceValue()
            : base(typeof(B2XCoreResourceResourceValueHistory))
        {
        }

        /// <summary>
        /// Gets or sets the ResourceID.
        /// </summary>
        /// <value>
        /// The ResourceID.
        /// </value>
        public long ResourceID { get; set; }

        /// <summary>
        /// Gets or sets the LanguageID.
        /// </summary>
        /// <value>
        /// The LanguageID.
        /// </value>
        public int LanguageID { get; set; }

        /// <summary>
        /// Gets or sets the ClientID.
        /// </summary>
        /// <value>
        /// The ClientID.
        /// </value>
        public int ClientID { get; set; }

        /// <summary>
        /// Gets or sets the ResourceValueID.
        /// </summary>
        /// <value>
        /// The ResourceValueID.
        /// </value>
        public long ResourceValueID { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreClient.
        /// </summary>
        /// <value>
        /// The B2XCoreClient.
        /// </value>
        public virtual B2XCoreClient B2XCoreClient { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreLanguage.
        /// </summary>
        /// <value>
        /// The B2XCoreLanguage.
        /// </value>
        public virtual B2XCoreLanguage B2XCoreLanguage { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResource.
        /// </summary>
        /// <value>
        /// The B2XCoreResource.
        /// </value>
        public virtual B2XCoreResource B2XCoreResource { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResourceValue.
        /// </summary>
        /// <value>
        /// The B2XCoreResourceValue.
        /// </value>
        public virtual B2XCoreResourceValue B2XCoreResourceValue { get; set; }
    }
}