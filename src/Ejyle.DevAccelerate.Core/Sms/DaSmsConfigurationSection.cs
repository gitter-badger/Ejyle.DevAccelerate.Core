// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Sms
{
    /// <summary>
    /// Represents SMS configuration.
    /// </summary>
    public class DaSmsConfigurationSection
        : DaProviderConfigurationSection<DaSmsProviderConfigurationElement>
    {
        /// <summary>
        /// Gets the name of the SMS configuration section.
        /// </summary>
        /// <returns>Returns daSmsConfiguration as the name of the configuration section.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daSmsConfiguration";
        }
    }
}
