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
using System.Runtime.InteropServices;
#if NETCORE
using System.Runtime.Serialization;
#else
using System.Xml.Serialization;
#endif
using B2XCore.Configuration;

namespace B2XCore.Data
{
    /// <summary>
    ///
    /// </summary>
    [ConfigurationDescription("{0}")]
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct KeyValue
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValue"/> struct.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public KeyValue(string key, string value)
            : this()
        {
            Key = key;
            Value = value;
        }

        #endregion Constructor

        #region Public properties

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The key.</value>
        [ConfigurationDisplayName(0)]
#if NETCORE
        [DataMember(Name = "enabled")]
#else
        [XmlAttribute("key")]
#endif
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
#if NETCORE
        [DataMember(Name = "value ")]
#else
        [XmlAttribute("value")]
#endif
        public string Value { get; set; }

#endregion Public properties

#region Public methods

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns>
        /// true if <paramref name="obj"/> and this instance are the same type and represent the same value; otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            return string.Compare(Key, ((KeyValue)obj).Key, StringComparison.Ordinal) == 0 &&
                string.Compare(Value, ((KeyValue)obj).Value, StringComparison.Ordinal) == 0;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that is the hash code for this instance.
        /// </returns>
        public override int GetHashCode()
        {
            return string.Concat(Key, "|", Value).GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="keyValue1">The key value1.</param>
        /// <param name="keyValue2">The key value2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(KeyValue keyValue1, KeyValue keyValue2)
        {
            return string.Compare(keyValue1.Key, keyValue2.Key, StringComparison.Ordinal) == 0 &&
                string.Compare(keyValue1.Value, keyValue2.Value, StringComparison.Ordinal) == 0;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="keyValue1">The key value1.</param>
        /// <param name="keyValue2">The key value2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(KeyValue keyValue1, KeyValue keyValue2)
        {
            return string.Compare(keyValue1.Key, keyValue2.Key, StringComparison.Ordinal) != 0 ||
                string.Compare(keyValue1.Value, keyValue2.Value, StringComparison.Ordinal) != 0;
        }

#endregion Public methods
    }
}