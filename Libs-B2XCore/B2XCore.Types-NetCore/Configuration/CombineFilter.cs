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
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace B2XCore.Configuration
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
#if !NETCORE
    [TypeConverter(typeof(PropertySorter))]
    [DefaultProperty("CombineType")]
    [XmlRoot(ElementName = "filter", IsNullable = false)]
#endif
	[DataContract(Name = "filter", Namespace = Constants.CoreTypeNamespace)]
    public sealed class CombineFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombineFilter"/> class.
        /// </summary>
        public CombineFilter()
        {
            Combines = new List<CombineFilter>(4);
            Compares = new List<CompareFilter>(4);
        }

        /// <summary>Gets or sets the compare.</summary>
        /// <value>The compare.</value>
        [Category("Type"), DefaultValue(CombineType.And), PropertyOrder(1)]
#if NETCORE
        [DataMember(Name = "type")]
#else
        [XmlAttribute(AttributeName = "type")]
#endif
        public CombineType CombineType { get; set; }

        /// <summary>Gets or sets the combines.</summary>
        /// <value>The combines.</value>
        [Category("Filter"), PropertyOrder(2)]
#if NETCORE
        [DataMember(Name = "combine")]
#else
        [XmlElement(ElementName = "combine")]
#endif
        public List<CombineFilter> Combines { get; set; }

        /// <summary>Gets or sets the compares.</summary>
        /// <value>The compares.</value>
        [Category("Filter"), PropertyOrder(3)]
#if NETCORE
        [DataMember(Name = "compare")]
#else
        [XmlElement(ElementName = "compare")]
#endif
        public List<CompareFilter> Compares { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return CombineType.ToString();
        }
    }
}