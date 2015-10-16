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
    public class DefaultConfigurationSource : IConfigurationSource
    {
        public T GetConfigurationSection<T>(string configSectionName)
            where T : DaConfigurationSection
        {
            return System.Configuration.ConfigurationManager.GetSection(configSectionName) as T;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
