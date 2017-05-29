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

namespace B2XCore
{
    /// <summary>
    ///
    /// </summary>
    public enum CombineType
    {
        /// <summary>The and</summary>
        [Description("AND")]
        And = 0,

        /// <summary>The or</summary>
        [Description("OR")]
        Or = 1,

        /// <summary>The and</summary>
        [Description("AND NOT")]
        AndNot = 2,

        /// <summary>The or</summary>
        [Description("OR NOT")]
        OrNot = 3,
    }
}