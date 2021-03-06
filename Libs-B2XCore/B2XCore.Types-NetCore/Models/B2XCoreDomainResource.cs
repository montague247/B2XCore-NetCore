#region License & Copyright

// B2XCore - A framework for smart applications
// Copyright � 2017 Dirk Helbig
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

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreDomainResource.
    /// </summary>
    [DataContract(Namespace = Constants.CoreModelTypeNamespace)]
    public partial class B2XCoreDomainResource : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreDomainResource"/> class.
        /// </summary>
        public B2XCoreDomainResource()
            : base(typeof(B2XCoreDomainResourceHistory))
        {
        }

        /// <summary>
        /// Gets or sets the domain resource identifier.
        /// </summary>
        /// <value>
        /// The domain resource identifier.
        /// </value>
        [DataMember]
        public int DomainResourceId { get; set; }

        /// <summary>
        /// Gets or sets the domain identifier.
        /// </summary>
        /// <value>
        /// The domain identifier.
        /// </value>
        [DataMember]
        public int DomainId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }
    }
}