// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Caching
{
    /// <summary>
    /// Represents the configuration section for caching.
    /// </summary>
    public class DaCachingConfigurationSection : DaProviderConfigurationSection
    {
        /// <summary>
        /// Gets the name of the configuration section.
        /// </summary>
        /// <returns>Returns the name of the configuration section as a <see cref="string"/>.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daCachingConfiguration";
        }
    }
}
