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

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreLanguage.
    /// </summary>
    public partial class B2XCoreLanguage : ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreLanguage"/> class.
        /// </summary>
        public B2XCoreLanguage()
            : base(typeof(B2XCoreLanguageHistory))
        {
            this.B2XCoreClientLanguage = new List<B2XCoreClientLanguage>();
            this.B2XCoreResourceResourceValue = new List<B2XCoreResourceResourceValue>();
        }

        /// <summary>
        /// Gets or sets the LanguageID.
        /// </summary>
        /// <value>
        /// The LanguageID.
        /// </value>
        public int LanguageID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the EnglishName.
        /// </summary>
        /// <value>
        /// The EnglishName.
        /// </value>
        public string EnglishName { get; set; }

        /// <summary>
        /// Gets or sets the NativeName.
        /// </summary>
        /// <value>
        /// The NativeName.
        /// </value>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the IetfLanguageTag.
        /// </summary>
        /// <value>
        /// The IetfLanguageTag.
        /// </value>
        public string IetfLanguageTag { get; set; }

        /// <summary>
        /// Gets or sets the ThreeLetterISOLanguageName.
        /// </summary>
        /// <value>
        /// The ThreeLetterISOLanguageName.
        /// </value>
        public string ThreeLetterISOLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the ThreeLetterWindowsLanguageName.
        /// </summary>
        /// <value>
        /// The ThreeLetterWindowsLanguageName.
        /// </value>
        public string ThreeLetterWindowsLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the TwoLetterISOLanguageName.
        /// </summary>
        /// <value>
        /// The TwoLetterISOLanguageName.
        /// </value>
        public string TwoLetterISOLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreClientLanguage.
        /// </summary>
        /// <value>
        /// The B2XCoreClientLanguage.
        /// </value>
        public virtual ICollection<B2XCoreClientLanguage> B2XCoreClientLanguage { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResourceResourceValue.
        /// </summary>
        /// <value>
        /// The B2XCoreResourceResourceValue.
        /// </value>
        public virtual ICollection<B2XCoreResourceResourceValue> B2XCoreResourceResourceValue { get; set; }
    }
}