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
    /// <summary>
    /// Represents the configuration element for a database.
    /// </summary>
    public class DatabaseConfigurationElement : NamedConfigurationElement
    {
        /// <summary>
        /// Gets or sets the database context type that implements the <see cref="IDatabaseContext"/> interface.
        /// </summary>
        /// <remarks>The name of the configuration property is databaseContextType.</remarks>
        [ConfigurationProperty("databaseContextType", IsRequired = true)]
        public string DatabaseContextType
        {
            get
            {
                return this["databaseContextType"] as string;
            }
            set
            {
                this["databaseContextType"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the connection string information of a database configuration element.
        /// </summary>
        /// <remarks>The name of the configuration property is connectionString.</remarks>
        [ConfigurationProperty("connectionString", IsRequired = false)]
        public string ConnectionString
        {
            get
            {
                return this["connectionString"] as string;
            }
            set
            {
                this["connectionString"] = value;
            }
        }
    }
}
