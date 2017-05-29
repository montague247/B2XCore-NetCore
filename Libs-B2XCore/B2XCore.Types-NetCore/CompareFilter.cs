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
using System.ComponentModel;
using System.Xml.Serialization;

namespace B2XCore
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
#if !NETCORE
    [TypeConverter(typeof(PropertySorter))]
    [DefaultProperty("CompareType")]
#endif
    public sealed class CompareFilter
    {
        /// <summary>Gets or sets the key.</summary>
        /// <value>The key.</value>
        [Category("Compare"), PropertyOrder(1)]
#if !NETCORE
        [XmlAttribute(AttributeName = "key")]
#endif
        public string Key { get; set; }

        /// <summary>Gets or sets the type of the compare.</summary>
        /// <value>The type of the compare.</value>
        [Category("Compare"), DefaultValue(CompareType.Equal), PropertyOrder(2)]
#if !NETCORE
        [XmlAttribute(AttributeName = "type")]
#endif
        public CompareType CompareType { get; set; }

        /// <summary>Gets or sets the value.</summary>
        /// <value>The value.</value>
        [Category("Compare"), PropertyOrder(3)]
#if !NETCORE
        [XmlElement(ElementName = "value")]
#endif
        public object[] Value { get; set; }
    }
}