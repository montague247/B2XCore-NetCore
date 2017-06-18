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

using System;
using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreSettingDefinition.
    /// </summary>
    public partial class B2XCoreSettingDefinition : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreSettingDefinition"/> class.
        /// </summary>
        public B2XCoreSettingDefinition()
            : base(typeof(B2XCoreSettingDefinitionHistory))
        {
            this.B2XCoreSetting = new List<B2XCoreSetting>();
        }

        /// <summary>
        /// Gets or sets the SettingDefinitionID.
        /// </summary>
        /// <value>
        /// The SettingDefinitionID.
        /// </value>
        public int SettingDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the ParentSettingDefinitionID.
        /// </summary>
        /// <value>
        /// The ParentSettingDefinitionID.
        /// </value>
        public int? ParentSettingDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the UniqueID.
        /// </summary>
        /// <value>
        /// The UniqueID.
        /// </value>
        public System.Guid UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the changed UTC.
        /// </summary>
        /// <value>
        /// The changed UTC.
        /// </value>
        public DateTime? ChangedUtc { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSetting.
        /// </summary>
        /// <value>
        /// The B2XCoreSetting.
        /// </value>
        public virtual ICollection<B2XCoreSetting> B2XCoreSetting { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSettingDefinition1.
        /// </summary>
        /// <value>
        /// The B2XCoreSettingDefinition1.
        /// </value>
        public virtual B2XCoreSettingDefinition B2XCoreSettingDefinition1 { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreSettingDefinition2.
        /// </summary>
        /// <value>
        /// The B2XCoreSettingDefinition2.
        /// </value>
        public virtual B2XCoreSettingDefinition B2XCoreSettingDefinition2 { get; set; }
    }
}