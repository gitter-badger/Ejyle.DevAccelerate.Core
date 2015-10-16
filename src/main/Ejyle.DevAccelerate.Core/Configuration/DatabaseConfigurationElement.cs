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
    public class DatabaseConfigurationElement : NamedConfigurationElement
    {
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
