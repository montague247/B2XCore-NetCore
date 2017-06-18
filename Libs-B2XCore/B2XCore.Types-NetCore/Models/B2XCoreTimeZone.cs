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
    /// Entry of table B2XCoreTimeZone.
    /// </summary>
    public partial class B2XCoreTimeZone : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreTimeZone"/> class.
        /// </summary>
        public B2XCoreTimeZone()
            : base(typeof(B2XCoreTimeZoneHistory))
        {
        }

        /// <summary>Gets or sets the time zone identifier.</summary>
        /// <value>The time zone identifier.</value>
        public int TimeZoneId { get; set; }

        /// <summary>Gets or sets the key.</summary>
        /// <value>The key.</value>
        public string Key { get; set; }

        /// <summary>Gets or sets the display name.</summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        /// <summary>Gets or sets the name of the standard.</summary>
        /// <value>The name of the standard.</value>
        public string StandardName { get; set; }

        /// <summary>Gets or sets the name of the daylight.</summary>
        /// <value>The name of the daylight.</value>
        public string DaylightName { get; set; }

        /// <summary>Gets or sets the base UTC offset.</summary>
        /// <value>The base UTC offset.</value>
        public decimal BaseUtcOffset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports daylight saving time].
        /// </summary>
        /// <value>
        /// <c>true</c> if [supports daylight saving time]; otherwise, <c>false</c>.
        /// </value>
        public bool SupportsDaylightSavingTime { get; set; }
    }
}