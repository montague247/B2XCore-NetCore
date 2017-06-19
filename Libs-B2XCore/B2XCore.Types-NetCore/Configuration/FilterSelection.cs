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
using System.ComponentModel;
#if NETCORE
using System.Runtime.Serialization;
#else
using System.Xml.Serialization;
#endif

namespace B2XCore.Configuration
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
#if !NETCORE
    [TypeConverter(typeof(PropertySorter))]
    [DefaultProperty("Entries")]
    //[XmlRoot(ElementName = "filter", IsNullable = false)]
#endif
	public sealed class FilterSelection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterSelection"/> class.
        /// </summary>
        public FilterSelection()
        {
            Entries = new List<FilterEntry>(64);
        }

        /// <summary>Gets or sets the entries.</summary>
        /// <value>The entries.</value>
        [Category("Filter"), PropertyOrder(1)]
#if NETCORE
        [DataMember(Name = "entry")]
#else
        [XmlElement(ElementName = "entry")]
#endif
        public List<FilterEntry> Entries { get; set; }
    }
}