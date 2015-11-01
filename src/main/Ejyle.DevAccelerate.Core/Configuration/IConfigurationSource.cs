// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    /// <summary>
    /// Defines the methods for a configuration source.
    /// </summary>
    public interface IConfigurationSource
    {
        /// <summary>
        /// Gets a configuration section by its name from the configuration source.
        /// </summary>
        /// <typeparam name="T">The type of the configuration section.</typeparam>
        /// <param name="configSectionName">The name of the configuration section.</param>
        /// <returns>Returns an instance of the generic configuration section type.</returns>
        T GetConfigurationSection<T>(string configSectionName)
            where T : DaConfigurationSection;

        /// <summary>
        /// Saves changes into the configuration source.
        /// </summary>
        void Save();
    }
}
