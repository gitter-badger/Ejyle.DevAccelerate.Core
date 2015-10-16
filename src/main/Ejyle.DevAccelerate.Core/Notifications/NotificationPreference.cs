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
    public class NotificationPreference : NotificationPreference<NotificationEvent>
    {
    }

    public class NotificationPreference<TNotificationEvent> : NotificationPreference<string, string, TNotificationEvent>
        where TNotificationEvent : INotificationEvent<string, string>
    {
    }

    public class NotificationPreference<TKey, TOptionalKey, TNotificationEvent> : EntityBase<TKey, TOptionalKey>, INotificationPreference<TKey, TOptionalKey>
        where TNotificationEvent : INotificationEvent<TKey, TOptionalKey>
    {
        public TKey UserId
        {
            get;
            set;
        }

        public TKey NotificationEventId
        {
            get;
            set;
        }

        public NotificationChannel NotificationChannel
        {
            get;
            set;
        }

        public virtual TNotificationEvent NotificationEvent
        {
            get;
            set;
        }

        public bool Notify
        {
            get;
            set;
        }
    }
}
