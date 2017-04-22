// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Configuration;
using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Data
{
    /// <summary>
    /// Contains a collections of the <see cref="DatabaseConfigurationElement"/> objects.
    /// </summary>
    public class DatabaseConfigurationElementCollection : NamedConfigurationElementCollection<DatabaseConfigurationElement>
    {
        /// <summary>
        /// creates a new <see cref="ConfigurationElement" />.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="DatabaseConfigurationElement"/> class.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new DatabaseConfigurationElement();
        }
    }
}
