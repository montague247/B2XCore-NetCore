#region License & Copyright

// B2XCore - A framework for smart applications
// Copyright © 2016 Dirk Helbig
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
#if !NETCORE
using System.Xml.Serialization;
#endif

namespace B2XCore.Types
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public class Filter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class.
        /// </summary>
        public Filter()
        {
            Combines = new List<CombineFilter>(4);
            Compares = new List<CompareFilter>(4);
        }

        /// <summary>Gets or sets the combines.</summary>
        /// <value>The combines.</value>
#if !NETCORE
        [XmlElement(ElementName = "combine")]
#endif
        public List<CombineFilter> Combines { get; set; }

		/// <summary>Gets or sets the compares.</summary>
		/// <value>The compares.</value>
#if !NETCORE
        [XmlElement(ElementName = "compare")]
#endif
		public List<CompareFilter> Compares { get; set; }
    }
}