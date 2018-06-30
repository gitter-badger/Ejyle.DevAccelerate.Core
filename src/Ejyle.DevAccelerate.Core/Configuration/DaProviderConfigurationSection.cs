// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Configuration;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    /// <summary>
    /// Represents a configuration section for provider configurations as part of the library's provider model.
    /// </summary>
    public class DaProviderConfigurationSection
        : DaProviderConfigurationSection<DaProviderConfigurationElement>
    {
    }

    /// <summary>
    /// Represents a configuration section for provider configurations as part of the library's provider model.
    /// </summary>
    /// <typeparam name="TProviderConfigurationElement">The type of <see cref="DaProviderConfigurationElement"/>.</typeparam>
    public class DaProviderConfigurationSection<TProviderConfigurationElement> : DaConfigurationSection
        where TProviderConfigurationElement : DaProviderConfigurationElement
    {
        private const string PROVIDERS = "providers";
        private const string DEFAULT_PROVIDER = "defaultProvider";

        /// <summary>
        /// Gets or sets the default provider in the provider configuration collection.
        /// </summary>
        [ConfigurationProperty(DEFAULT_PROVIDER, IsRequired = false, DefaultValue = null)]
        public string DefaultProvider
        {
            get
            {
                return this[DEFAULT_PROVIDER] as string;
            }
            set
            {
                this[DEFAULT_PROVIDER] = value;
            }
        }

        /// <summary>
        /// Gets or sets the collection of provider configurations.
        /// </summary>
        [ConfigurationProperty(PROVIDERS, IsRequired = false, DefaultValue = null)]
        public ProviderConfigurationElementCollection<TProviderConfigurationElement> Providers
        {
            get
            {
                return this[PROVIDERS] as ProviderConfigurationElementCollection<TProviderConfigurationElement>;
            }
            set
            {
                this[PROVIDERS] = value;
            }
        }
    }
}
