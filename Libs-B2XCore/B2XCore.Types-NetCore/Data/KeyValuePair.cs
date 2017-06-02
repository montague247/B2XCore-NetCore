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
using System.Runtime.Serialization;

namespace B2XCore.Data
{
    /// <summary>
    ///
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
    [DataContract(Namespace = Constants.CoreTypeNamespace)]
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct KeyValuePair<TKey, TValue>
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValuePair&lt;TKey, TValue&gt;"/> struct.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public KeyValuePair(TKey key, TValue value)
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
        [DataMember]
        public TKey Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [DataMember]
        public TValue Value { get; set; }

        #endregion Public properties

        #region Public methods

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

        #endregion Public methods
    }
}