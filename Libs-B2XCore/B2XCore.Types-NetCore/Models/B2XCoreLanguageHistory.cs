namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreLanguageHistory.
    /// </summary>
    public partial class B2XCoreLanguageHistory : B2XCore.Models.ChangeHistory
    {
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
    }
}