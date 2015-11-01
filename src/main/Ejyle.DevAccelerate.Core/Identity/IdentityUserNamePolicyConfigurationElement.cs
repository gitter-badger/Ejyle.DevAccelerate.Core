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
    public class IdentityUserNamePolicyConfigurationElement : ConfigurationElement
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

        [ConfigurationProperty("allowOnlyAlphanumericUserNames", IsRequired = false, DefaultValue = false)]
        public bool AllowOnlyAlphanumericUserNames
        {
            get
            {
                return Convert.ToBoolean(this["allowOnlyAlphanumericUserNames"]);
            }
            set
            {
                this["allowOnlyAlphanumericUserNames"] = value;
            }
        }

        [ConfigurationProperty("requireUniqueEmail", IsRequired = false, DefaultValue = true)]
        public bool RequireUniqueEmail
        {
            get
            {
                return Convert.ToBoolean(this["requireUniqueEmail"]);
            }
            set
            {
                this["requireUniqueEmail"] = value;
            }
        }
    }
}
