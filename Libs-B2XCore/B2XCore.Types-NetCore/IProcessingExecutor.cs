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
    public interface IProcessingExecutor
    {
        /// <summary>Gets the status.</summary>
        /// <value>The status.</value>
        ProcessingStatus Status { get; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <returns></returns>
        byte[] GetContent();

        /// <summary>
        /// Puts the content.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="max">The maximum.</param>
        void PutContent(byte[] bytes, int max);

        /// <summary>
        /// Gets the name of the content file.
        /// </summary>
        /// <value>
        /// The name of the content file.
        /// </value>
        string ContentFileName { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="IProcessingExecutor"/> is stop.
        /// </summary>
        /// <value><c>true</c> if stop; otherwise, <c>false</c>.</value>
        bool Stop { get; }

        /// <summary>Starts the execution.</summary>
        void StartExecution();

        /// <summary>Stops the execution.</summary>
        void StopExecution();
    }
}