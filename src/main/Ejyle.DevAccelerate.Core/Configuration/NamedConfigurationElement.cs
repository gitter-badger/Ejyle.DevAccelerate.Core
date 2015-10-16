// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Configuration;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    /// <summary>
    /// Represents a configuration element for a provider.
    /// </summary>
    public class NamedConfigurationElement : ConfigurationElement
    {
        private const string PROPERTY_NAME = "name";

        #region Properties

        /// <summary>
        /// Gets or sets the name of the provider.
        /// </summary>
        [ConfigurationProperty(PROPERTY_NAME, IsRequired = true)]
        public string Name
        {
            get
            {
                return this[PROPERTY_NAME] as string;
            }
            set
            {
                this[PROPERTY_NAME] = value;
            }
        }

        #endregion Properties
    }
}
