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
    /// A static class that sets or gets SMS provider configuration section.
    /// </summary>
    public static class DaSmsConfigurationManager
    {
        private const string SMS_CONFIG = "daSmsConfiguration";

        /// <summary>
        /// Sets SMS provider configuration based on the given configuration source..
        /// </summary>
        /// <param name="configurationSource">The configuration source from which the configuration is to be retrieved.</param>
        public static void SetConfiguration(IDaConfigurationSource configurationSource)
        {
            DaApplicationContext.SetupConfiguration<DaSmsConfigurationSection>(SMS_CONFIG, configurationSource);
        }

        /// <summary>
        /// Gets the SMS provider configuration.
        /// </summary>
        /// <returns>Returns an instance of <see cref="DaSmsConfigurationSection"/>.</returns>
        public static DaSmsConfigurationSection GetConfiguration()
        {
            return DaApplicationContext.GetConfiguration<DaSmsConfigurationSection>(SMS_CONFIG);
        }
    }
}
