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
#if NETCORE
using System.Reflection;
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
    [DefaultProperty("CompareType")]
#endif
	public sealed class CompareFilter
    {
        /// <summary>Gets or sets the key.</summary>
        /// <value>The key.</value>
        [Category("Compare"), PropertyOrder(1)]
#if NETCORE
        [DataMember(Name = "key")]
#else
        [XmlAttribute(AttributeName = "key")]
#endif
        public string Key { get; set; }

        /// <summary>Gets or sets the type of the compare.</summary>
        /// <value>The type of the compare.</value>
        [Category("Compare"), DefaultValue(CompareType.Equal), PropertyOrder(2)]
#if NETCORE
        [DataMember(Name = "type")]
#else
        [XmlAttribute(AttributeName = "type")]
#endif
        public CompareType CompareType { get; set; }

        /// <summary>Gets or sets the value.</summary>
        /// <value>The value.</value>
        [Category("Compare"), PropertyOrder(3)]
#if NETCORE
        [DataMember(Name = "value")]
#else
        [XmlAttribute(AttributeName = "value")]
#endif
        public object[] Value { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return string.Concat(Key, ' ', GetDescriptionOfEnumValue(CompareType));
        }

        private static string GetDescriptionOfEnumValue(Enum value)
        {
            var type = value.GetType();

#if NETCORE
            var ti = type.GetTypeInfo();

            if (!ti.IsEnum)
				throw new ArgumentException("Type is not an Enum.");

            throw new NotImplementedException();
#else
            if (!type.IsEnum)
                throw new ArgumentException("Type is not an Enum.");

            var mi = type.GetMember(Enum.GetName(type, value));

            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(mi[0], typeof(DescriptionAttribute));

            if (attribute != null)
                return attribute.Description;

            return value.ToString();
#endif
		}

    }
}