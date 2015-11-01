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
using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core.Data
{
    /// <summary>
    /// Represents the configuration section for all the databases in the application.
    /// </summary>
    public class DatabaseConfigurationSection : DaConfigurationSection
    {
        /// <summary>
        /// Gets or sets default database of the application.
        /// </summary>
        /// <remarks>The name of the configuration property is defaultDatabase.</remarks>
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

        /// <summary>
        /// Gets or sets all the databases in the database configuration section.
        /// </summary>
        /// <remarks>The name of the configuration property is databases.</remarks>
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

        /// <summary>
        /// Returns daDatabaseConfiguration as the name of the configuration section.
        /// </summary>
        /// <returns>Returns the name of the configuration section as a <see cref="string"/>.</returns>
        public override string GetConfigurationSectionName()
        {
            return "daDatabaseConfiguration";
        }

        /// <summary>
        /// Gets the configuration information about the default database.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="DatabaseConfigurationElement"/> class.</returns>
        public DatabaseConfigurationElement GetDefaultDatabaseConfiguration()
        {
            return Databases.GetByName(DefaultDatabase);
        }
    }
}
