using System;
using System.Collections.Generic;

namespace B2XCore.Models
{
    /// <summary>
    /// Entry of table B2XCoreUser.
    /// </summary>
    public partial class B2XCoreUser : B2XCore.Models.ChangeTracking
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="B2XCoreUser"/> class.
        /// </summary>
        public B2XCoreUser()
            : base(typeof(B2XCoreUserHistory))
        {
            this.B2XCoreUserDomainResource = new List<B2XCoreUserDomainResource>();
            this.B2XCoreUserGroup = new List<B2XCoreUserGroup>();
            this.B2XCoreUserProperty = new List<B2XCoreUserProperty>();
        }

        /// <summary>
        /// Gets or sets the UserID.
        /// </summary>
        /// <value>
        /// The UserID.
        /// </value>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        /// <value>
        /// The UserName.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        /// <value>
        /// The LastName.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        /// <value>
        /// The FirstName.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// The Email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the PasswordHash.
        /// </summary>
        /// <value>
        /// The PasswordHash.
        /// </value>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the PasswordSalt.
        /// </summary>
        /// <value>
        /// The PasswordSalt.
        /// </value>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// Gets or sets the last password changed UTC.
        /// </summary>
        /// <value>
        /// The last password changed UTC.
        /// </value>
        public DateTime? LastPasswordChangedUtc { get; set; }

        /// <summary>
        /// Gets or sets the IsApproved.
        /// </summary>
        /// <value>
        /// The IsApproved.
        /// </value>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or sets the IsLockedOut.
        /// </summary>
        /// <value>
        /// The IsLockedOut.
        /// </value>
        public bool IsLockedOut { get; set; }

        /// <summary>
        /// Gets or sets the last lockout UTC.
        /// </summary>
        /// <value>
        /// The last lockout UTC.
        /// </value>
        public DateTime? LastLockoutUtc { get; set; }

        /// <summary>
        /// Gets or sets the FailedPasswordAttempt.
        /// </summary>
        /// <value>
        /// The FailedPasswordAttempt.
        /// </value>
        public int FailedPasswordAttempt { get; set; }

        /// <summary>
        /// Gets or sets the last failed password attempt UTC.
        /// </summary>
        /// <value>
        /// The last failed password attempt UTC.
        /// </value>
        public DateTime? LastFailedPasswordAttemptUtc { get; set; }

        /// <summary>
        /// Gets or sets the SecureKey.
        /// </summary>
        /// <value>
        /// The SecureKey.
        /// </value>
        public string SecureKey { get; set; }

        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        /// <value>
        /// The IsEnabled.
        /// </value>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the last field update UTC.
        /// </summary>
        /// <value>
        /// The last field update UTC.
        /// </value>
        public DateTime? LastFieldUpdateUtc { get; set; }

        /// <summary>
        /// Gets or sets the PreferredUserName.
        /// </summary>
        /// <value>
        /// The PreferredUserName.
        /// </value>
        public string PreferredUserName { get; set; }

        /// <summary>
        /// Gets or sets the AuthenticationType.
        /// </summary>
        /// <value>
        /// The AuthenticationType.
        /// </value>
        public int AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the AllowAutoLogin.
        /// </summary>
        /// <value>
        /// The AllowAutoLogin.
        /// </value>
        public bool AllowAutoLogin { get; set; }

        /// <summary>
        /// Gets or sets the DomainID.
        /// </summary>
        /// <value>
        /// The DomainID.
        /// </value>
        public int? DomainID { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUserDomainResource.
        /// </summary>
        /// <value>
        /// The B2XCoreUserDomainResource.
        /// </value>
        public virtual ICollection<B2XCoreUserDomainResource> B2XCoreUserDomainResource { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUserGroup.
        /// </summary>
        /// <value>
        /// The B2XCoreUserGroup.
        /// </value>
        public virtual ICollection<B2XCoreUserGroup> B2XCoreUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the B2XCoreUserProperty.
        /// </summary>
        /// <value>
        /// The B2XCoreUserProperty.
        /// </value>
        public virtual ICollection<B2XCoreUserProperty> B2XCoreUserProperty { get; set; }
    }
}