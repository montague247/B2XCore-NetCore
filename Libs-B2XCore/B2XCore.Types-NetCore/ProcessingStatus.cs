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
using System.Runtime.Serialization;

namespace B2XCore
{
    /// <summary>
    ///
    /// </summary>
    [DataContract(Namespace = Constants.CoreTypeNamespace)]
    [Serializable]
    public sealed class ProcessingStatus
    {
        #region Member variables

        private ProcessingStatusType _status;
        private DateTime? _started;
        private DateTime? _finished;
        private string _message;
        private int _current;
        private int _max;
        private bool _isContentAvailable;
        private bool _isContentRequired;

        #endregion Member variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatus"/> class.
        /// </summary>
        public ProcessingStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatus"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public ProcessingStatus(int id)
        {
            Id = id;
            _status = ProcessingStatusType.Pending;
            Queued = DateTime.Now;
            Modified = DateTime.Now;
        }

        #endregion Constructor

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>Gets or sets the status.</summary>
        /// <value>The status.</value>
        [DataMember]
        public ProcessingStatusType Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status != value)
                    Modified = DateTime.Now;

                _status = value;
            }
        }

        /// <summary>Gets or sets the queued.</summary>
        /// <value>The queued.</value>
        [DataMember]
        public DateTime Queued { get; set; }

        /// <summary>Gets or sets the started.</summary>
        /// <value>The started.</value>
        [DataMember]
        public DateTime? Started
        {
            get
            {
                return _started;
            }
            set
            {
                if (_started != value)
                    Modified = DateTime.Now;

                _started = value;
            }
        }

        /// <summary>
        /// Gets or sets the modified.
        /// </summary>
        /// <value>
        /// The modified.
        /// </value>
        [DataMember]
        public DateTime Modified { get; set; }

        /// <summary>Gets or sets the finished.</summary>
        /// <value>The finished.</value>
        [DataMember]
        public DateTime? Finished
        {
            get
            {
                return _finished;
            }
            set
            {
                if (_finished != value)
                    Modified = DateTime.Now;

                _finished = value;
            }
        }

        /// <summary>Gets or sets the message.</summary>
        /// <value>The message.</value>
        [DataMember]
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if (_message != value)
                    Modified = DateTime.Now;

                _message = value;
            }
        }

        /// <summary>Gets or sets the current.</summary>
        /// <value>The current.</value>
        [DataMember]
        public int Current
        {
            get
            {
                return _current;
            }
            set
            {
                if (_current != value)
                    Modified = DateTime.Now;

                _current = value;
            }
        }

        /// <summary>Gets or sets the maximum.</summary>
        /// <value>The maximum.</value>
        [DataMember]
        public int Max
        {
            get
            {
                return _max;
            }
            set
            {
                if (_max != value)
                    Modified = DateTime.Now;

                _max = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is content available.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is content available; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsContentAvailable
        {
            get
            {
                return _isContentAvailable;
            }
            set
            {
                if (_isContentAvailable != value)
                    Modified = DateTime.Now;

                _isContentAvailable = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is content required.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is content required; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsContentRequired
        {
            get
            {
                return _isContentRequired;
            }
            set
            {
                if (_isContentRequired != value)
                    Modified = DateTime.Now;

                _isContentRequired = value;
            }
        }
    }
}