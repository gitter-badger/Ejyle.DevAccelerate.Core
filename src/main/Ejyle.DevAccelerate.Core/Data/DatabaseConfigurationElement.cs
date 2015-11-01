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
    /// Represents the configuration element for a database.
    /// </summary>
    public class DatabaseConfigurationElement : NamedConfigurationElement
    {
        private const string DATABASE_CONTEXT_TYPE = "databaseContextType";
        private const string CONNECTION_STRING = "connectionString";

        /// <summary>
        /// Gets or sets the database context type that implements the <see cref="IDatebaseContext"/> interface.
        /// </summary>
        /// <remarks>The name of the configuration property is databaseContextType.</remarks>
        [ConfigurationProperty(DATABASE_CONTEXT_TYPE, IsRequired = true)]
        public string DatabaseContextType
        {
            get
            {
                return this[DATABASE_CONTEXT_TYPE] as string;
            }
            set
            {
                this[DATABASE_CONTEXT_TYPE] = value;
            }
        }

        /// <summary>
        /// Gets or sets the connection string information of a database configuration element.
        /// </summary>
        /// <remarks>The name of the configuration property is connectionString.</remarks>
        [ConfigurationProperty(CONNECTION_STRING, IsRequired = false)]
        public string ConnectionString
        {
            get
            {
                return this[CONNECTION_STRING] as string;
            }
            set
            {
                this[CONNECTION_STRING] = value;
            }
        }
    }
}
