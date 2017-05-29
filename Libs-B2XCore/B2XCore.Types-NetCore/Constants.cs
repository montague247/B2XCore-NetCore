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

namespace B2XCore
{
    /// <summary>
    ///
    /// </summary>
    public sealed class Constants
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Constants"/> class.
        /// </summary>
        private Constants()
        {
        }

        #endregion Constructor

        /// <summary>
        /// The core service namespace
        /// </summary>
        public const string CoreServiceNamespace = "urn:b2xcore:services";

        /// <summary>
        /// The core type namespace
        /// </summary>
        public const string CoreTypeNamespace = "urn:b2xcore:types";

		/// <summary>
		/// The core models type namespace
		/// </summary>
		public const string CoreModelTypeNamespace = "urn:b2xcore:types:models";

		/// <summary>
		/// The modification date column name
		/// </summary>
		public const string ModificationDateColumnName = "ModifiedUtc";

        /// <summary>
        /// The modification date SQL function name
        /// </summary>
        public const string ModificationDateSqlFunctionName = "GETUTCDATE()";
    }
}