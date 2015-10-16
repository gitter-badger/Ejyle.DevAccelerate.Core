﻿// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Configuration;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    /// <summary>
    /// Represents the configuration section for an email service provider.
    /// </summary>
    public class MailServiceConfigurationSection : DaConfigurationSection
    {
        public override string GetConfigurationSectionName()
        {
            return "daMailServiceConfiguration";
        }

        /// <summary>
        /// Gets or sets the host of the email service provider.
        /// </summary>
        [ConfigurationProperty("host", IsRequired = true)]
        public string Host
        {
            get
            {
                return this["host"] as string;
            }
            set
            {
                this["host"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the port for an email service provider.
        /// </summary>
        [ConfigurationProperty("port", IsRequired = false, DefaultValue=0)]
        public int Port
        {
            get
            {
                return Convert.ToInt32(this["port"]);
            }
            set
            {
                this["port"] = value;
            }
        }

        /// <summary>
        /// Determines if the SSL is used for communicating with the email service provider.
        /// </summary>
        [ConfigurationProperty("useSSL", IsRequired = false, DefaultValue = false)]
        public bool UseSSL
        {
            get
            {
                return Convert.ToBoolean(this["useSSL"]);
            }
            set
            {
                this["useSSL"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the username for the email service provider. 
        /// </summary>
        [ConfigurationProperty("userName", IsRequired = false, DefaultValue=null)]
        public string UserName
        {
            get
            {
                return this["userName"] as string;
            }
            set
            {
                this["userName"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the password for the email service provider.
        /// </summary>
        [ConfigurationProperty("password", IsRequired = false, DefaultValue=null)]
        public string Password
        {
            get
            {
                return this["password"] as string;
            }
            set
            {
                this["password"] = value;
            }
        }

        /// <summary>
        /// Determines if mail is to be running in backgroun.
        /// </summary>
        [ConfigurationProperty("sendMailInBackground", IsRequired = false, DefaultValue = false)]
        public bool SendMailInBackground
        {
            get
            {
                return Convert.ToBoolean(this["sendMailInBackground"]);
            }
            set
            {
                this["sendMailInBackground"] = value;
            }
        }
    }
}