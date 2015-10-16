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
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    public class DaConfigurationSection : ConfigurationSection, IXmlSerializable
    {
        public virtual XmlSchema GetSchema()
        {
            return null;
        }

        public virtual string GetConfigurationSectionName()
        {
            return "daConfigurationSection";
        }

        public virtual void WriteXml(XmlWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            var serializedSection = SerializeSection(this, GetConfigurationSectionName(), ConfigurationSaveMode.Full);
            writer.WriteRaw(serializedSection);
        }

        public virtual void ReadXml(XmlReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            reader.Read();
            DeserializeSection(reader);
        }

        public virtual ProtectedConfigurationProvider GetProtectionProviderByName(string providerName)
        {
            if (string.IsNullOrEmpty(providerName)) return null;
            return ProtectedConfiguration.Providers[providerName];
        }
    }
}
