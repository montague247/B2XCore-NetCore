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
    public class PropertyOrderPair : IComparable
    {
        private int _order;
        private string _name;

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyOrderPair"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="order">The order.</param>
        public PropertyOrderPair(string name, int order)
        {
            _order = order;
            _name = name;
        }

        /// <summary>
        /// Vergleicht die aktuelle Instanz mit einem anderen Objekt vom selben Typ und gibt eine ganze Zahl zurück, die angibt, ob die aktuelle Instanz in der Sortierreihenfolge vor oder nach dem anderen Objekt oder an derselben Position auftritt.
        /// </summary>
        /// <param name="obj">Ein Objekt, das mit dieser Instanz verglichen werden soll.</param>
        /// <returns>
        /// Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt.Der Rückgabewert hat folgende Bedeutung:Wert Bedeutung Kleiner als 0 Diese Instanz ist kleiner als <paramref name="obj" />. 0 Diese Instanz ist gleich <paramref name="obj" />. Größer als 0 Diese Instanz ist größer als <paramref name="obj" />.
        /// </returns>
        public int CompareTo(object obj)
        {
            //
            // Sort the pair objects by ordering by order value
            // Equal values get the same rank
            //
            int otherOrder = ((PropertyOrderPair)obj)._order;

            if (otherOrder == _order)
            {
                //
                // If order not specified, sort by name
                //
                var otherName = ((PropertyOrderPair)obj)._name;

                return string.Compare(_name, otherName);
            }
            else if (otherOrder > _order)
            {
                return -1;
            }

            return 1;
        }
    }
}