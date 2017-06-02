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
using System.Text;
using System.Xml.Serialization;

namespace B2XCore.Configuration
{
    /// <summary>
    ///
    /// </summary>
    [XmlRoot(ElementName = "importMapping", IsNullable = false, Namespace = Constants.CoreTypeNamespace)]
    public sealed class ImportMapping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportMapping"/> class.
        /// </summary>
        public ImportMapping()
        {
            EncodingString = Encoding.UTF8.BodyName;
            MinLineLengthString = "1";
            FieldQualifierString = "\"";
            FieldSeparatorString = "\t";
            Columns = new List<ColumnMapping>(32);
            Columns.Add(new ColumnMapping("ImportID", "int"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportMapping"/> class.
        /// </summary>
        /// <param name="table">The table.</param>
        public ImportMapping(string table)
            : this()
        {
            Table = table;
        }

        /// <summary>
        /// Gets or sets the encoding.
        /// </summary>
        /// <value>
        /// The encoding.
        /// </value>
        [XmlAttribute(AttributeName = "encoding")]
        public string EncodingString { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [XmlAttribute(AttributeName = "position")]
        public string PositionString { get; set; }

        /// <summary>
        /// Gets or sets the line delimiter.
        /// </summary>
        /// <value>
        /// The line delimiter.
        /// </value>
        [XmlAttribute(AttributeName = "lineDelimiter")]
        public string LineDelimiter { get; set; }

        /// <summary>Gets or sets the first line starts with.</summary>
        /// <value>The first line starts with.</value>
        [XmlAttribute(AttributeName = "firstLineStartsWith")]
        public string FirstLineStartsWith { get; set; }

        /// <summary>Gets or sets the has columns header.</summary>
        /// <value>The has columns header.</value>
        [XmlAttribute(AttributeName = "hasColumnsHeader")]
        public string HasColumnsHeader { get; set; }

        /// <summary>
        /// Gets or sets the minimum length of the line.
        /// </summary>
        /// <value>
        /// The minimum length of the line.
        /// </value>
        [XmlAttribute(AttributeName = "minLineLength")]
        public string MinLineLengthString { get; set; }

        /// <summary>
        /// Gets or sets the table.
        /// </summary>
        /// <value>
        /// The table.
        /// </value>
        [XmlAttribute(AttributeName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// Gets or sets the field qualifier.
        /// </summary>
        /// <value>
        /// The field qualifier.
        /// </value>
        [XmlAttribute(AttributeName = "fieldQualifier")]
        public string FieldQualifierString { get; set; }

        /// <summary>
        /// Gets or sets the field separator.
        /// </summary>
        /// <value>
        /// The field separator.
        /// </value>
        [XmlAttribute(AttributeName = "fieldSeparator")]
        public string FieldSeparatorString { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        [XmlElement(ElementName = "column")]
        public List<ColumnMapping> Columns { get; set; }

        /// <summary>Gets the column.</summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public ColumnMapping GetColumn(string name)
        {
            if (Columns == null)
                return null;

            foreach (var column in Columns)
            {
                if (string.Compare(name, column.Name, StringComparison.OrdinalIgnoreCase) == 0)
                    return column;
            }

            return null;
        }

        /// <summary>Adds the tracking columns.</summary>
        public void AddTrackingColumns()
        {
            Columns.Add(new ModifiedUtcColumnMapping());
            Columns.Add(new EditorColumnMapping());
        }
    }
}