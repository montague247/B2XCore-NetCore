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
using System.Runtime.Serialization;

namespace B2XCore.Excel
{
    /// <summary>
    ///
    /// </summary>
    [DataContract(Namespace = Constants.CoreTypeNamespace)]
    [Serializable]
    public sealed class ColumnData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnData"/> class.
        /// </summary>
        public ColumnData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnData" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="dataTypeName">Name of the data type.</param>
        /// <param name="subTotalType">Total type of the sub.</param>
        /// <param name="hidden">if set to <c>true</c> [hidden].</param>
        /// <param name="width">The width.</param>
        /// <param name="wrapped">if set to <c>true</c> [wrapped].</param>
        /// <param name="refColumnName">Name of the reference column.</param>
        /// <param name="invertSuccess">The invert success.</param>
        /// <param name="successValue">The success value.</param>
        /// <param name="columnFormula">The column formula.</param>
        /// <param name="totalsFormula">The totals formula.</param>
        /// <param name="tooltip">The tooltip.</param>
        public ColumnData(string name, string dataTypeName, SubTotalType subTotalType = SubTotalType.None, bool hidden = false, int? width = null, bool wrapped = false, string refColumnName = null, bool? invertSuccess = null, string successValue = null, string columnFormula = null, string totalsFormula = null, string tooltip = null)
        {
            Name = name;
            DataTypeName = dataTypeName;
            SubTotalType = subTotalType;
            Hidden = hidden;
            Width = width;
            Wrapped = wrapped;
            RefColumnName = refColumnName;
            InvertSuccess = invertSuccess;
            SuccessValue = successValue;
            ColumnFormula = columnFormula;
            TotalsFormula = totalsFormula ?? string.Empty;
            Tooltip = tooltip;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets the name of the data type.
        /// </summary>
        /// <value>
        /// The name of the data type.
        /// </value>
        [DataMember]
        public string DataTypeName { get; set; }

        /// <summary>
        /// Gets the total type of the sub.
        /// </summary>
        /// <value>
        /// The total type of the sub.
        /// </value>
        [DataMember]
        public SubTotalType SubTotalType { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ColumnData"/> is hidden.
        /// </summary>
        /// <value>
        ///   <c>true</c> if hidden; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [DataMember]
        public int? Width { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ColumnData"/> is wrapped.
        /// </summary>
        /// <value>
        ///   <c>true</c> if wrapped; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Wrapped { get; set; }

        /// <summary>
        /// Gets or sets the name of the reference column.
        /// </summary>
        /// <value>
        /// The name of the reference column.
        /// </value>
        [DataMember]
        public string RefColumnName { get; set; }

        /// <summary>
        /// Gets the invert success.
        /// </summary>
        /// <value>
        /// The invert success.
        /// </value>
        [DataMember]
        public bool? InvertSuccess { get; set; }

        /// <summary>
        /// Gets the success value.
        /// </summary>
        /// <value>
        /// The success value.
        /// </value>
        [DataMember]
        public string SuccessValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is success.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets the column formula.
        /// </summary>
        /// <value>
        /// The column formula.
        /// </value>
        [DataMember]
        public string ColumnFormula { get; set; }

        /// <summary>
        /// Gets or sets the formula.
        /// </summary>
        /// <value>
        /// The formula.
        /// </value>
        [DataMember]
        public string TotalsFormula { get; set; }

        /// <summary>
        /// Gets or sets the tooltip.
        /// </summary>
        /// <value>
        /// The tooltip.
        /// </value>
        [DataMember]
        public string Tooltip { get; set; }

        /// <summary>
        /// Gets the formula r1 c1.
        /// </summary>
        /// <value>
        /// The formula r1 c1.
        /// </value>
        [IgnoreDataMember]
        public string FormulaR1C1
        {
            get
            {
                if (SuccessValue == null)
                    return InvertSuccess == true ?
                        string.Concat("IF([", RefColumnName, "]=\"\",\"\",IF([", RefColumnName, "]=0,1,0))") :
                        string.Concat("IF([", RefColumnName, "]=\"\",\"\",[", RefColumnName, "])");
                else
                    return string.Concat("IF([", RefColumnName, "]=\"\",\"\",IF([", RefColumnName, "]=\"", SuccessValue, "\",1,0))");
            }
        }

        /// <summary>
        /// Gets the column formula.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <returns></returns>
        public string GetColumnFormula(List<ColumnData> columns)
        {
            if (SubTotalType == SubTotalType.Formula)
                return ConvertFormula(Name, ColumnFormula, columns);
            else
                return ColumnFormula ?? string.Concat("[", Name, "]");
        }

        /// <summary>
        /// Gets the totals row formula.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="columns">The columns.</param>
        /// <returns></returns>
        public string GetTotalsRowFormula(string tableName, List<ColumnData> columns)
        {
            if (SubTotalType == SubTotalType.Formula)
                return ConvertFormula(Name, TotalsFormula, tableName, columns);
            else
                return string.Concat("IFERROR(SUBTOTAL(", SubTotalType.GetHashCode(), ",", tableName, "[", Name, "]),\"\")");
        }

        /// <summary>
        /// Converts the formula.
        /// </summary>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="formula">The formula.</param>
        /// <param name="columns">The columns.</param>
        /// <returns></returns>
        public static string ConvertFormula(string columnName, string formula, List<ColumnData> columns)
        {
            var idx = -1;

            for (int i = 0; i < columns.Count; i++)
            {
                if (string.Compare(columns[i].Name, columnName, StringComparison.Ordinal) == 0)
                {
                    idx = i;

                    break;
                }
            }

            if (idx == -1)
                return null;

            for (int i = 0; i < columns.Count; i++)
            {
                var rel = i - idx;
                var v = string.Concat("RC[", rel, "]");
                var c = columns[i];

                while (formula.Contains(v))
                {
                    formula = formula.Replace(v, c.GetColumnFormula(columns));
                }
            }

            return formula;
        }

        /// <summary>
        /// Converts the formula.
        /// </summary>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="formula">The formula.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="columns">The columns.</param>
        /// <returns></returns>
        public static string ConvertFormula(string columnName, string formula, string tableName, List<ColumnData> columns)
        {
            var idx = -1;

            for (int i = 0; i < columns.Count; i++)
            {
                if (string.Compare(columns[i].Name, columnName, StringComparison.Ordinal) == 0)
                {
                    idx = i;
                    break;
                }
            }

            if (idx == -1)
                return null;

            for (int i = 0; i < columns.Count; i++)
            {
                var rel = i - idx;
                var v = string.Concat("RC[", rel, "]");
                var c = columns[i];

                while (formula.Contains(v))
                {
                    formula = formula.Replace(v, c.GetTotalsRowFormula(tableName, columns));
                }
            }

            return formula;
        }
    }
}