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
    public class ColumnMapping
    {
        private int _maxLength;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMapping" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="typeName">Name of the type.</param>
        public ColumnMapping(string name, string typeName)
        {
            Name = name;
            TypeName = typeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMapping" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="typeName">Name of the type.</param>
        /// <param name="maxLength">The maximum length.</param>
        public ColumnMapping(string name, string typeName, int maxLength)
            : this(name, typeName)
        {
            MaxLength = maxLength;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
#if NETCORE
        [DataMember(Name = "name")]
#else
        [XmlAttribute(AttributeName = "name")]
#endif
        public string Name { get; set; }

        /// <summary>Gets or sets the name of the type.</summary>
        /// <value>The name of the type.</value>
#if NETCORE
        [DataMember(Name = "type")]
#else
        [XmlAttribute(AttributeName = "type")]
#endif
        public string TypeName { get; set; }

        /// <summary>Gets or sets the maximum length.</summary>
        /// <value>The maximum length.</value>
#if NETCORE
        [DataMember(Name = "maxLength")]
#else
        [XmlAttribute(AttributeName = "maxLength")]
#endif
        public int MaxLength { get { return _maxLength; } set { _maxLength = value; MaxLengthSpecified = _maxLength > 0; } }

        /// <summary>
        /// Gets or sets a value indicating whether [maximum length specified].
        /// </summary>
        /// <value>
        /// <c>true</c> if [maximum length specified]; otherwise, <c>false</c>.
        /// </value>
#if NETCORE
        [IgnoreDataMember]
#else
        [XmlIgnore]
#endif
        public bool MaxLengthSpecified { get; set; }

		/// <summary>Gets or sets the is enabled.</summary>
		/// <value>The is enabled.</value>
#if NETCORE
		[DataMember(Name = "enabled")]
#else
        [XmlAttribute(AttributeName = "enabled")]
#endif
		public string IsEnabledString { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is enabled.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
		/// </value>
#if NETCORE
		[IgnoreDataMember]
#else
        [XmlIgnore]
#endif
		public bool? IsEnabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance has field.
		/// </summary>
		/// <value><c>true</c> if this instance has field; otherwise, <c>false</c>.</value>
#if NETCORE
		[IgnoreDataMember]
#else
        [XmlIgnore]
#endif
		public bool HasField { get; set; }

		/// <summary>Gets or sets the index of the field.</summary>
		/// <value>The index of the field.</value>
#if NETCORE
		[IgnoreDataMember]
#else
        [XmlIgnore]
#endif
		public int FieldIndex { get; set; }

		/// <summary>Gets or sets the value.</summary>
		/// <value>The value.</value>
#if NETCORE
		[IgnoreDataMember]
#else
        [XmlIgnore]
#endif
		public object Value { get; private set; }

        /// <summary>Sets the value.</summary>
        /// <param name="value">The value.</param>
        public virtual void SetValue(object value)
        {
            Value = value;
        }
    }
}