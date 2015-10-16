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
    public class ProviderConfigurationSection : DaConfigurationSection
    {
        private const string PROPERTY_EXTENDED_PROPERTIES = "extendedProperties";
        private const string PROPERTY_TYPE = "type";

        [ConfigurationProperty(PROPERTY_TYPE, IsRequired = true)]
        public string Type
        {
            get
            {
                return this[PROPERTY_TYPE] as string;
            }
            set
            {
                this[PROPERTY_TYPE] = value;
            }
        }

        [ConfigurationProperty(PROPERTY_EXTENDED_PROPERTIES)]
        public ExtendedPropertyConfigurationElementCollection ExtendedProperties
        {
            get
            {
                return this[PROPERTY_EXTENDED_PROPERTIES] as ExtendedPropertyConfigurationElementCollection;
            }
            set
            {
                this[PROPERTY_EXTENDED_PROPERTIES] = value;
            }
        }
    }
}
