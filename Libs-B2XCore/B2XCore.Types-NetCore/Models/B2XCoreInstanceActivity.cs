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
using System.Runtime.Serialization;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreInstanceActivity.
    /// </summary>
    [DataContract(Namespace = Constants.CoreModelTypeNamespace)]
    public partial class B2XCoreInstanceActivity : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreInstanceActivity"/> class.
        /// </summary>
        public B2XCoreInstanceActivity()
            : base(typeof(B2XCoreInstanceActivityHistory))
        {
        }

        /// <summary>
        /// Gets or sets the instance identifier.
        /// </summary>
        /// <value>
        /// The instance identifier.
        /// </value>
        [DataMember]
        public int InstanceId { get; set; }

        /// <summary>
        /// Gets or sets the machine identifier.
        /// </summary>
        /// <value>
        /// The machine identifier.
        /// </value>
        [DataMember]
        public int MachineId { get; set; }

        /// <summary>
        /// Gets or sets the process identifier.
        /// </summary>
        /// <value>
        /// The process identifier.
        /// </value>
        [DataMember]
        public int ProcessId { get; set; }

        /// <summary>
        /// Gets or sets the unique key.
        /// </summary>
        /// <value>
        /// The unique key.
        /// </value>
        [DataMember]
        public Guid UniqueKey { get; set; }

        /// <summary>
        /// Gets or sets the start date UTC.
        /// </summary>
        /// <value>
        /// The start date UTC.
        /// </value>
        [DataMember]
        public DateTime StartDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the end date UTC.
        /// </summary>
        /// <value>
        /// The end date UTC.
        /// </value>
        [DataMember]
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the last is alive UTC.
        /// </summary>
        /// <value>
        /// The last is alive UTC.
        /// </value>
        [DataMember]
        public DateTime? LastIsAliveUtc { get; set; }

        /// <summary>
        /// Gets or sets the client ip.
        /// </summary>
        /// <value>
        /// The client ip.
        /// </value>
        [DataMember]
        public string ClientIP { get; set; }
    }
}