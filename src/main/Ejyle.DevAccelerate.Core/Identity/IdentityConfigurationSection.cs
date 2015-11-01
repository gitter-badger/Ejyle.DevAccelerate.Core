// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Identity
{
    /// <summary>
    /// Represents the configuration section for identity management in the application.
    /// </summary>
    public class IdentityConfigurationSection : DaConfigurationSection
    {
        /// <summary>
        /// Gets or sets user token provider type.
        /// </summary>
        /// <remarks>The name of the configuration property is userTokenProvider.</remarks>
        [ConfigurationProperty("userTokenProvider", IsRequired = false)]
        public string UserTokenProvider
        {
            get
            {
                return this["userTokenProvider"] as string;
            }
            set
            {
                this["userTokenProvider"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the email service type.
        /// </summary>
        /// <remarks>The name of the configuration property is emailService.</remarks>
        [ConfigurationProperty("emailService", IsRequired = false)]
        public string EmailService
        {
            get
            {
                return this["emailService"] as string;
            }
            set
            {
                this["emailService"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the SMS service type.
        /// </summary>
        /// <remarks>The name of the configuration property is smsService.</remarks>
        [ConfigurationProperty("smsService", IsRequired = false)]
        public string SMSService
        {
            get
            {
                return this["smsService"] as string;
            }
            set
            {
                this["smsService"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the two factory policy settings.
        /// </summary>
        /// <remarks>The name of the configuration policy is twoFactorPolicy.</remarks>
        [ConfigurationProperty("twoFactorPolicy", IsRequired = false)]
        public IdentityTwoFactorPolicyConfigurationElement TwoFactorPolicy
        {
            get
            {
                return this["twoFactorPolicy"] as IdentityTwoFactorPolicyConfigurationElement;
            }
            set
            {
                this["twoFactorPolicy"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the username policy settings.
        /// </summary>
        /// <remarks>The name of the configuration property is userNamePolicy.</remarks>
        [ConfigurationProperty("userNamePolicy", IsRequired = false)]
        public IdentityUserNamePolicyConfigurationElement UserNamePolicy
        {
            get
            {
                return this["userNamePolicy"] as IdentityUserNamePolicyConfigurationElement;
            }
            set
            {
                this["userNamePolicy"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the password policy settings.
        /// </summary>
        /// <remarks>The name of the configuration property is passwordPolicy.</remarks>
        [ConfigurationProperty("passwordPolicy", IsRequired = false)]
        public IdentityPasswordPolicyConfigurationElement PasswordPolicy
        {
            get
            {
                return this["passwordPolicy"] as IdentityPasswordPolicyConfigurationElement;
            }
            set
            {
                this["passwordPolicy"] = value;
            }
        }

        /// <summary>
        /// Gets or sets user lockout policy settings.
        /// </summary>
        /// <remarks>The name of the configuration property is userLockoutPolicy.</remarks>
        [ConfigurationProperty("userLockoutPolicy", IsRequired = false)]
        public IdentityLockoutPolicyConfigurationElement UserLockoutPolicy
        {
            get
            {
                return this["userLockoutPolicy"] as IdentityLockoutPolicyConfigurationElement;
            }
            set
            {
                this["userLockoutPolicy"] = value;
            }
        }

        /// <summary>
        /// Returns daIdentityConfiguration as the name of the configuration section.
        /// </summary>
        /// <returns>Returns the name of the configuration section as a <see cref="string"/>.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daIdentityConfiguration";
        }
    }
}
