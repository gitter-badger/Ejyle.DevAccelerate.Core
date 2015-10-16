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
    public class DatabaseConfigurationElementCollection : NamedConfigurationElementCollection<DatabaseConfigurationElement>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="DatabaseConfigurationElement"/> configuration class.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="DatabaseConfigurationElement"/> class.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new DatabaseConfigurationElement();
        }
    }
}
