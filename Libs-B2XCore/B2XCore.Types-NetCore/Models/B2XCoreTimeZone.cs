namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreTimeZone.
    /// </summary>
    public partial class B2XCoreTimeZone : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreTimeZone"/> class.
        /// </summary>
        public B2XCoreTimeZone()
            : base(typeof(B2XCoreTimeZoneHistory))
        {
        }

        /// <summary>Gets or sets the time zone identifier.</summary>
        /// <value>The time zone identifier.</value>
        public int TimeZoneId { get; set; }

        /// <summary>Gets or sets the key.</summary>
        /// <value>The key.</value>
        public string Key { get; set; }

        /// <summary>Gets or sets the display name.</summary>
        /// <value>The display name.</value>
        public string DisplayName { get; set; }

        /// <summary>Gets or sets the name of the standard.</summary>
        /// <value>The name of the standard.</value>
        public string StandardName { get; set; }

        /// <summary>Gets or sets the name of the daylight.</summary>
        /// <value>The name of the daylight.</value>
        public string DaylightName { get; set; }

        /// <summary>Gets or sets the base UTC offset.</summary>
        /// <value>The base UTC offset.</value>
        public decimal BaseUtcOffset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports daylight saving time].
        /// </summary>
        /// <value>
        /// <c>true</c> if [supports daylight saving time]; otherwise, <c>false</c>.
        /// </value>
        public bool SupportsDaylightSavingTime { get; set; }
    }
}