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

namespace Ejyle.DevAccelerate.Core.Configuration
{
    public class IdentityConfigurationSection : DaConfigurationSection
    {
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

        public override string GetConfigurationSectionName()
        {
            return "daIdentityConfiguration";
        }
    }
}
