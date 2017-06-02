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

namespace B2XCore.Data
{
    /// <summary>
    ///
    /// </summary>
    [Implementable]
    public interface IDomainAccessor
    {
        /// <summary>
        /// Determines whether [is user enabled] [the specified full user name].
        /// </summary>
        /// <param name="fullUserName">Full name of the user.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="domainName">Name of the domain.</param>
        /// <returns></returns>
        bool IsUserEnabled(string fullUserName, string userName, string domainName);

        /// <summary>
        /// Determines whether [is password valid] [the specified user name].
        /// </summary>
        /// <param name="fullUserName">Full name of the user.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="domainName">Name of the domain.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool IsPasswordValid(string fullUserName, string userName, string domainName, string password);

        /// <summary>
        /// Gets the password salt.
        /// </summary>
        /// <param name="fullUserName">Full name of the user.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="domainName">Name of the domain.</param>
        /// <returns></returns>
        string GetPasswordSalt(string fullUserName, string userName, string domainName);

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="fullUserName">Full name of the user.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="domainName">Name of the domain.</param>
        /// <returns></returns>
        bool AddUser(string fullUserName, string userName, string domainName);
    }
}