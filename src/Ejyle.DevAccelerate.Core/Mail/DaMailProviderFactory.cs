// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;

namespace Ejyle.DevAccelerate.Core.Mail
{
    /// <summary>
    /// Represents the factory for creating an instance of <see cref="IDaMailProvider"/> type.
    /// </summary>
    public static class DaMailProviderFactory
    {
        /// <summary>
        /// Creates an instance of a <see cref="IDaMailProvider"/> type.
        /// </summary>
        /// <returns>Returns an instance of <see cref="IDaMailProvider"/>.</returns>
        public static IDaMailProvider GetProvider()
        {
            DaProviderConfigurationElement providerConfig = null;

            var config = DaMailConfigurationManager.GetConfiguration();

            if (config != null)
            {
                providerConfig = config.Providers.GetByName(config.DefaultProvider);
            }

            if (providerConfig == null)
            {
                return new DaDefaultMailProvider();
            }

            var type = Type.GetType(providerConfig.Type);
            return Activator.CreateInstance(type) as IDaMailProvider;
        }
    }
}
