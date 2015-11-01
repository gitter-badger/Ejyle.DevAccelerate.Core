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

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class IdentityLockoutPolicyConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("isEnabled", IsRequired = false, DefaultValue = false)]
        public bool IsEnabled
        {
            get
            {
                return Convert.ToBoolean(this["isEnabled"]);
            }
            set
            {
                this["isEnabled"] = value;
            }
        }

        [ConfigurationProperty("defaultAccountLockoutTimeSpan", IsRequired = false, DefaultValue = 5)]
        public int DefaultAccountLockoutTimeSpan
        {
            get
            {
                return Convert.ToInt32(this["defaultAccountLockoutTimeSpan"]);
            }
            set
            {
                this["defaultAccountLockoutTimeSpan"] = value;
            }
        }

        [ConfigurationProperty("userLockoutEnabledByDefault", IsRequired = false, DefaultValue = true)]
        public bool UserLockoutEnabledByDefault
        {
            get
            {
                return Convert.ToBoolean(this["userLockoutEnabledByDefault"]);
            }
            set
            {
                this["userLockoutEnabledByDefault"] = value;
            }
        }

        [ConfigurationProperty("maxFailedAccessAttemptsBeforeLockout", IsRequired = false, DefaultValue = 5)]
        public int MaxFailedAccessAttemptsBeforeLockout
        {
            get
            {
                return Convert.ToInt32(this["maxFailedAccessAttemptsBeforeLockout"]);
            }
            set
            {
                this["maxFailedAccessAttemptsBeforeLockout"] = value;
            }
        }
    }
}
