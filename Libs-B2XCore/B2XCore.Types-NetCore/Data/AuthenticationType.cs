﻿#region License & Copyright

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

using System.Runtime.Serialization;

namespace B2XCore.Data
{
    /// <summary>
    ///
    /// </summary>
    [DataContract(Namespace = Constants.CoreTypeNamespace)]
    public enum AuthenticationType
    {
        /// <summary>
        /// The user password
        /// </summary>
        [EnumMember]
        UserPassword = 0,

        /// <summary>
        /// The domain
        /// </summary>
        [EnumMember]
        Domain = 1,

        /// <summary>
        /// The custom
        /// </summary>
        [EnumMember]
        Custom = 99
    }
}