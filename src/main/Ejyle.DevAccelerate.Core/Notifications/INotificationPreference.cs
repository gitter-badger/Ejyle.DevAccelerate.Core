// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Notifications
{
    public interface INotificationPreference<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        TKey UserId
        {
            get;
            set;
        }

        TKey NotificationEventId
        {
            get;
            set;
        }

        NotificationChannel NotificationChannel
        {
            get;
            set;
        }

        bool Notify
        {
            get;
            set;
        }
    }
}
