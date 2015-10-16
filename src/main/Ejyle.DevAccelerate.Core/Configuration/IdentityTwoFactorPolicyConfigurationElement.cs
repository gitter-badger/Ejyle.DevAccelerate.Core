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
    public class IdentityTwoFactorPolicyConfigurationElement : ConfigurationElement
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

        [ConfigurationProperty("smsTokenProvider", IsRequired = false)]
        public string SMSTokenProvider
        {
            get
            {
                return this["smsTokenProvider"] as string;
            }
            set
            {
                this["smsTokenProvider"] = value;
            }
        }

        [ConfigurationProperty("emailTokenProvider", IsRequired = false)]
        public string EmailTokenProvider
        {
            get
            {
                return this["emailTokenProvider"] as string;
            }
            set
            {
                this["emailTokenProvider"] = value;
            }
        }
    }
}
