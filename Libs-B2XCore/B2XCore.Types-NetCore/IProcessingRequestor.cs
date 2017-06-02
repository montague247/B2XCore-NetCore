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
    [Implementable]
    public interface IProcessingRequestor
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; }

        /// <summary>
        /// Gets or sets a value indicating whether [open file after finish].
        /// </summary>
        /// <value>
        /// <c>true</c> if [open file after finish]; otherwise, <c>false</c>.
        /// </value>
        bool OpenFileAfterFinish { get; set; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns></returns>
        ProcessingStatus GetStatus();

        /// <summary>
        /// Processes the specified status.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <param name="hasNewStatus">if set to <c>true</c> [has new status].</param>
        /// <returns></returns>
        ProcessingStatus Process(ProcessingStatus status, out bool hasNewStatus);

        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns></returns>
        ProcessingStatus Stop();

        /// <summary>
        /// Finishes this instance.
        /// </summary>
        /// <returns></returns>
        ProcessingStatus Finish();
    }
}