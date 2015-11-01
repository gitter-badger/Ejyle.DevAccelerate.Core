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
using Ejyle.DevAccelerate.Core.Identity;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    /// <summary>
    /// Represents the general configuration section for the DevAccelerate application.
    /// </summary>
    public class DaApplicationConfigurationSection : DaConfigurationSection
    {
        private const string USER_CONTEXT_MANAGER = "userContextManager";

        /// <summary>
        /// Gets or sets user context management type that implements the <see cref="IUserContextManager"/> interface.
        /// </summary>
        [ConfigurationProperty(USER_CONTEXT_MANAGER, IsRequired = false)]
        public string UserContextManager
        {
            get
            {
                return this[USER_CONTEXT_MANAGER] as string;
            }
            set
            {
                this[USER_CONTEXT_MANAGER] = value;
            }
        }

        /// <summary>
        /// Gets the name of the configuration section. 
        /// </summary>
        /// <returns>Returns the name of the configuration section as a <see cref="string"/>.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daApplicationConfiguration";
        }
    }
}
