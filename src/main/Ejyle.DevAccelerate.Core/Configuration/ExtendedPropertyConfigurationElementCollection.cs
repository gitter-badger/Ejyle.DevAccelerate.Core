// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Configuration;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    public class ExtendedPropertyConfigurationElementCollection : NamedConfigurationElementCollection<ExtendedPropertyConfigurationElement>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ExtendedPropertyConfigurationElement"/> configuration class.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="ExtendedPropertyConfigurationElement"/> class.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ExtendedPropertyConfigurationElement();
        }
    }
}
