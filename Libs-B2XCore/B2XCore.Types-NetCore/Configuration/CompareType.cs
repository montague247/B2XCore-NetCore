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

using System.ComponentModel;

namespace B2XCore.Configuration
{
    /// <summary>
    ///
    /// </summary>
    public enum CompareType
    {
        /// <summary>The equal</summary>
        [Description("equals")]
        Equal = 0,

        /// <summary>The not equal</summary>
        [Description("not equals")]
        NotEqual = 1,

        /// <summary>The less than</summary>
        [Description("less than")]
        LessThan = 2,

        /// <summary>The greater than</summary>
        [Description("greater than")]
        GreaterThan = 3,

        /// <summary>The less than or equal</summary>
        [Description("less than or equal")]
        LessThanOrEqual = 4,

        /// <summary>
        /// The greater than or equal
        /// </summary>
        [Description("greater than or equal")]
        GreaterThanOrEqual = 5,

        /// <summary>The contains</summary>
        [Description("contains")]
        Contains = 6,

        /// <summary>The starts with</summary>
        [Description("starts with")]
        StartsWith = 7,

        /// <summary>The ends with</summary>
        [Description("ends with")]
        EndsWith = 8,

        /// <summary>The is empty</summary>
        [Description("is empty")]
        IsEmpty = 9,
    }
}