// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Logging
{
    /// <summary>
    /// Represents the configuration section for logging management in the application.
    /// </summary>
    public class DaLoggingConfigurationSection : DaProviderConfigurationSection
    {
        /// <summary>
        /// Returns daLoggingConfiguration as the name of the configuration section.
        /// </summary>
        /// <returns>Returns the name of the confiuration section as a <see cref="string"/>.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daLoggingConfiguration";
        }
    }
}
