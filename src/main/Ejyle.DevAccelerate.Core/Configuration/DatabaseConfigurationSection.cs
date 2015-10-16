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
    public class DatabaseConfigurationSection : DaConfigurationSection
    {
        [ConfigurationProperty("defaultDatabase", IsRequired=false, DefaultValue="DevAccelerateConnection")]
        public string DefaultDatabase
        {
            get
            {
                return this["defaultDatabase"] as string;
            }
            set
            {
                this["defaultDatabase"] = value;
            }
        }

        [ConfigurationProperty("databases")]
        public DatabaseConfigurationElementCollection Databases
        {
            get
            {
                return this["databases"] as DatabaseConfigurationElementCollection;
            }
            set
            {
                this["databases"] = value;
            }
        }

        public override string GetConfigurationSectionName()
        {
            return "daDatabaseConfiguration";
        }

        public DatabaseConfigurationElement GetDefaultDatabaseConfiguration()
        {
            return Databases.GetByName(DefaultDatabase);
        }
    }
}
