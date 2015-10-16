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
    public class IdentityPasswordPolicyConfigurationElement : ConfigurationElement
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

        [ConfigurationProperty("requiredLength", IsRequired = false, DefaultValue = 6)]
        public int RequiredLength
        {
            get
            {
                return Convert.ToInt32(this["requiredLength"]);
            }
            set
            {
                this["requiredLength"] = value;
            }
        }

        [ConfigurationProperty("requireNonLetterOrDigit", IsRequired = false, DefaultValue = true)]
        public bool RequireNonLetterOrDigit
        {
            get
            {
                return Convert.ToBoolean(this["requireNonLetterOrDigit"]);
            }
            set
            {
                this["requireNonLetterOrDigit"] = value;
            }
        }

        [ConfigurationProperty("requireDigit", IsRequired = false, DefaultValue = true)]
        public bool RequireDigit
        {
            get
            {
                return Convert.ToBoolean(this["requireDigit"]);
            }
            set
            {
                this["requireDigit"] = value;
            }
        }

        [ConfigurationProperty("requireLowercase", IsRequired = false, DefaultValue = true)]
        public bool RequireLowercase
        {
            get
            {
                return Convert.ToBoolean(this["requireLowercase"]);
            }
            set
            {
                this["requireLowercase"] = value;
            }
        }

        [ConfigurationProperty("requireUppercase", IsRequired = false, DefaultValue = true)]
        public bool RequireUppercase
        {
            get
            {
                return Convert.ToBoolean(this["requireUppercase"]);
            }
            set
            {
                this["requireUppercase"] = value;
            }
        }
    }
}
