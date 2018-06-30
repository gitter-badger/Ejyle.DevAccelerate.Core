// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Mail
{
    /// <summary>
    /// A static class that sets or gets mail provider configuration section.
    /// </summary>
    public static class DaMailConfigurationManager
    {
        private const string MAIL_CONFIG = "daMailConfiguration";

        /// <summary>
        /// Sets mail provider configuration based on the given configuration source..
        /// </summary>
        /// <param name="configurationSource">The configuration source from which the configuration is to be retrieved.</param>
        public static void SetConfiguration(IDaConfigurationSource configurationSource)
        {
            DaApplicationContext.SetupConfiguration<DaMailConfigurationSection>(MAIL_CONFIG, configurationSource);
        }

        /// <summary>
        /// Gets the mail provider configuration.
        /// </summary>
        /// <returns>Returns an instance of <see cref="DaMailConfigurationSection"/>.</returns>
        public static DaMailConfigurationSection GetConfiguration()
        {
            return DaApplicationContext.GetConfiguration<DaMailConfigurationSection>(MAIL_CONFIG);
        }
    }
}
