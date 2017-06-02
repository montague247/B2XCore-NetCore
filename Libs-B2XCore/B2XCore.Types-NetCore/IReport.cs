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

namespace B2XCore
{
    /// <summary>
    ///
    /// </summary>
    [Implementable]
    public interface IReport
    {
        /// <summary>
        /// Gets or sets the client base path.
        /// </summary>
        /// <value>
        /// The client base path.
        /// </value>
        string ClientBasePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string Title { get; set; }

        /// <summary>
        /// Gets the template slides.
        /// </summary>
        /// <value>
        /// The template slides.
        /// </value>
        int TemplateSlides { get; }

        /// <summary>
        /// Creates the report.
        /// </summary>
        /// <param name="fromDateUtc">From date UTC.</param>
        /// <param name="toDateUtc">To date UTC.</param>
        /// <param name="date">The date.</param>
        /// <param name="timeZone">The time zone.</param>
        /// <param name="editor">The editor.</param>
        void CreateReport(DateTime fromDateUtc, DateTime toDateUtc, DateTime date, TimeZoneInfo timeZone, string editor);

        /// <summary>
        /// Stops the creation.
        /// </summary>
        void StopCreation();
    }
}