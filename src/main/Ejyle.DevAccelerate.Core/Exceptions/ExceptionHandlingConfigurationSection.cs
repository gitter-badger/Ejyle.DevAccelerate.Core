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

namespace Ejyle.DevAccelerate.Core.Exceptions
{
    /// <summary>
    /// Represents the configuration section for exception handling in the application.
    /// </summary>
    public class ExceptionHandlingConfigurationSection : ProviderConfigurationSection
    {
        /// <summary>
        /// Gets or sets the name of the default exception policy.
        /// </summary>
        /// <remarks>The name of the configuration property is defaultExceptionPolicy.</remarks>
        [ConfigurationProperty("defaultExceptionPolicy", IsRequired = false, DefaultValue="Default Exception Policy")]
        public string DefaultExceptionPolicy
        {
            get
            {
                return this["defaultExceptionPolicy"] as string;
            }
            set
            {
                this["defaultExceptionPolicy"] = value;
            }
        }

        /// <summary>
        /// Returns daExceptionHandlingConfiguration as the name of the configuration section.
        /// </summary>
        /// <returns>Returns the name of the configuration section as a <see cref="string"/>.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daExceptionHandlingConfiguration";
        }
    }
}
