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
    /// Represents additional properties for a named configuration element.
    /// </summary>
    public class ExtendedPropertyConfigurationElement : NamedConfigurationElement
    {
        private const string VALUE = "value";

        /// <summary>
        /// Gets or sets the value of the named configuration element.
        /// </summary>
        [ConfigurationProperty(VALUE, IsRequired = true)]
        public string Value
        {
            get
            {
                return this[VALUE] as string;
            }
            set
            {
                this[VALUE] = value;
            }
        }
    }
}
