// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Sms
{
    /// <summary>
    /// Represents the base and common functionality for a SMS provider.
    /// </summary>
    public abstract class DaSmsProviderBase : IDaSmsProvider
    {
        /// <summary>
        /// Creates an instance of <see cref="DaSmsProviderBase"/>.
        /// </summary>
        public DaSmsProviderBase()
        {
            var config = DaApplicationContext.GetConfiguration<DaSmsConfigurationSection>("daSmsConfiguration");
            var provider = config.Providers.GetByName(config.DefaultProvider);

            SmsProviderInfo = new DaSmsProviderInfo()
            {
                From = provider.From,
                Sid = provider.Sid,
                Token = provider.Token
            };           
        }

        /// <summary>
        /// Gets or sets SMS provider information.
        /// </summary>
        protected DaSmsProviderInfo SmsProviderInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Sends an SMS.
        /// </summary>
        /// <param name="to">The recipient of the SMS.</param>
        /// <param name="body">The body of the SMS message.</param>
        public abstract void Send(string to, string body);

        /// <summary>
        /// Asynchronously sends an SMS.
        /// </summary>
        /// <param name="to">The recipient of the SMS.</param>
        /// <param name="body">The body of the SMS message.</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public abstract Task SendAsync(string to, string body);
    }
}
