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
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace B2XCore.Configuration
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    [TypeConverter(typeof(PropertySorter))]
    [DefaultProperty("Column")]
    [DataContract(Namespace = Constants.CoreTypeNamespace)]
    public sealed class FilterEntry
    {
        private Type _entryType;

        /// <summary>Gets or sets the table.</summary>
        /// <value>The table.</value>
        [Category("Entry"), DefaultValue(null), PropertyOrder(1)]
        [XmlAttribute(AttributeName = "table")]
        [DataMember]
        public string Table { get; set; }

        /// <summary>Gets or sets the column.</summary>
        /// <value>The column.</value>
        [Category("Entry"), PropertyOrder(2)]
        [XmlAttribute(AttributeName = "column")]
        [DataMember]
        public string Column { get; set; }

        /// <summary>Gets or sets the value.</summary>
        /// <value>The value.</value>
        [Category("Entry"), DefaultValue(null), PropertyOrder(3)]
        [XmlAttribute(AttributeName = "display")]
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>Gets or sets the type of the entry.</summary>
        /// <value>The type of the entry.</value>
        [Category("Entry"), PropertyOrder(4)]
        [XmlIgnore]
        [IgnoreDataMember]
        public Type EntryType
        {
            get
            {
                if (_entryType == null &&
                    TypeName != null)
                {
                    _entryType = Type.GetType(TypeName);
                }

                return _entryType;
            }
            set
            {
                TypeName = GetTypeName(value);
                _entryType = value;
            }
        }

        /// <summary>Gets or sets the name of the type.</summary>
        /// <value>The name of the type.</value>
        [Browsable(false)]
        [XmlAttribute(AttributeName = "type")]
        [DataMember]
        public string TypeName { get; set; }

        /// <summary>Gets the key.</summary>
        /// <value>The key.</value>
        [Category("Entry"), PropertyOrder(5)]
        [XmlIgnore]
        [IgnoreDataMember]
        public string Key
        {
            get
            {
                var key = string.Concat('[', Column, ']');

                if (!string.IsNullOrEmpty(Table))
                {
                    key = string.Concat('[', Table, ']', key);
                }

                return key;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return DisplayName ?? Key;
        }

        private static string GetTypeName(Type type)
        {
            if (type == null) return null;

            string name = type.Assembly.FullName;

            name = string.Concat(type.FullName, ", ", name.Substring(0, name.IndexOf(',')));

            return name;
        }
    }
}