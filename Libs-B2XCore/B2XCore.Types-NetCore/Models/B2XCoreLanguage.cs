using System;
using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreLanguage.
    /// </summary>
    public partial class B2XCoreLanguage : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreLanguage"/> class.
        /// </summary>
        public B2XCoreLanguage()
            : base(typeof(B2XCoreLanguageHistory))
        {
            this.B2XCoreClientLanguage = new List<B2XCoreClientLanguage>();
            this.B2XCoreResourceResourceValue = new List<B2XCoreResourceResourceValue>();
        }

        /// <summary>
        /// Gets or sets the LanguageID.
        /// </summary>
        /// <value>
        /// The LanguageID.
        /// </value>
        public int LanguageID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the EnglishName.
        /// </summary>
        /// <value>
        /// The EnglishName.
        /// </value>
        public string EnglishName { get; set; }

        /// <summary>
        /// Gets or sets the NativeName.
        /// </summary>
        /// <value>
        /// The NativeName.
        /// </value>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the IetfLanguageTag.
        /// </summary>
        /// <value>
        /// The IetfLanguageTag.
        /// </value>
        public string IetfLanguageTag { get; set; }

        /// <summary>
        /// Gets or sets the ThreeLetterISOLanguageName.
        /// </summary>
        /// <value>
        /// The ThreeLetterISOLanguageName.
        /// </value>
        public string ThreeLetterISOLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the ThreeLetterWindowsLanguageName.
        /// </summary>
        /// <value>
        /// The ThreeLetterWindowsLanguageName.
        /// </value>
        public string ThreeLetterWindowsLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the TwoLetterISOLanguageName.
        /// </summary>
        /// <value>
        /// The TwoLetterISOLanguageName.
        /// </value>
        public string TwoLetterISOLanguageName { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreClientLanguage.
        /// </summary>
        /// <value>
        /// The B2XCoreClientLanguage.
        /// </value>
        public virtual ICollection<B2XCoreClientLanguage> B2XCoreClientLanguage { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreResourceResourceValue.
        /// </summary>
        /// <value>
        /// The B2XCoreResourceResourceValue.
        /// </value>
        public virtual ICollection<B2XCoreResourceResourceValue> B2XCoreResourceResourceValue { get; set; }
    }
}