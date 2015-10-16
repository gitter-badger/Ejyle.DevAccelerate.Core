// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    public class FileConfigurationSource : IConfigurationSource
    {
        private string _ConfigurationFile = null;
        private static System.Configuration.Configuration _Configuration;

        public FileConfigurationSource(string configurationFile)
        {
            if(String.IsNullOrEmpty(configurationFile))
            {
                throw new ArgumentNullException("configurationFile");
            }

            _ConfigurationFile = configurationFile;

            var configFileMap = new ConfigurationFileMap(_ConfigurationFile);
            _Configuration = ConfigurationManager.OpenMappedMachineConfiguration(configFileMap);
        }

        public T GetConfigurationSection<T>(string configSectionName)
            where T : DaConfigurationSection
        {
            if (_Configuration == null)
            {
                return ConfigurationManager.GetSection(configSectionName) as T;
            }

            return _Configuration.GetSection(configSectionName) as T;
        }

        public void Save()
        {
            Configuration.Save();
        }

        public System.Configuration.Configuration Configuration
        {
            get
            {
                return _Configuration;
            }
        }
    }
}
