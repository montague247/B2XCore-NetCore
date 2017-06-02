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
using System.Collections;
using System.ComponentModel;

namespace B2XCore
{
    /// <summary>
    ///
    /// </summary>
    public sealed class PropertySorter : ExpandableObjectConverter
    {
        #region Methods

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob dieses Objekt Eigenschaften unter Verwendung des angegebenen Kontexts unterstützt.
        /// </summary>
        /// <param name="context">Ein <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, der einen Formatierungskontext bereitstellt.</param>
        /// <returns>
        /// true, da <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" /> aufgerufen werden muss, um die Eigenschaften dieses Objekts zu ermitteln.Diese Methode gibt nie false zurück.
        /// </returns>
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Ruft eine Auflistung von Eigenschaften für den durch den Wertparameter angegebenen Typ von Objekt ab.
        /// </summary>
        /// <param name="context">Ein <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, der einen Formatierungskontext bereitstellt.</param>
        /// <param name="value">Ein <see cref="T:System.Object" />, das den Typ von Objekt angibt, für das die Eigenschaften abgerufen werden sollen.</param>
        /// <param name="attributes">Ein Array vom Typ <see cref="T:System.Attribute" />, das als Filter verwendet wird.</param>
        /// <returns>
        /// Eine <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> mit den Eigenschaften, die für die Komponente verfügbar sind, oder null, wenn keine Eigenschaften vorhanden sind.
        /// </returns>
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            //
            // This override returns a list of properties in order
            //
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(value, attributes);
            var orderedProperties = new ArrayList();

            foreach (PropertyDescriptor pd in pdc)
            {
                Attribute attribute = pd.Attributes[typeof(PropertyOrderAttribute)];
                if (attribute != null)
                {
                    //
                    // If the attribute is found, then create an pair object to hold it
                    //
                    PropertyOrderAttribute poa = (PropertyOrderAttribute)attribute;
                    orderedProperties.Add(new PropertyOrderPair(pd.Name, poa.Order));
                }
                else
                {
                    //
                    // If no order attribute is specifed then given it an order of 0
                    //
                    orderedProperties.Add(new PropertyOrderPair(pd.Name, 0));
                }
            }

            //
            // Perform the actual order using the value PropertyOrderPair classes
            // implementation of IComparable to sort
            //
            orderedProperties.Sort();

            //
            // Build a string list of the ordered names
            //
            ArrayList propertyNames = new ArrayList();

            foreach (PropertyOrderPair pop in orderedProperties)
            {
                propertyNames.Add(pop.Name);
            }

            //
            // Pass in the ordered list for the PropertyDescriptorCollection to sort by
            //
            return pdc.Sort((string[])propertyNames.ToArray(typeof(string)));
        }

        #endregion Methods
    }
}