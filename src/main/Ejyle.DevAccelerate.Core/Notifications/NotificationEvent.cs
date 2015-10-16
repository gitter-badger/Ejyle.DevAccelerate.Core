// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Notifications
{
    public class NotificationEvent : NotificationEvent<string, string, NotificationPreference>
    { }

    public class NotificationEvent<TNotificationPreference> : NotificationEvent<string, string, TNotificationPreference>
        where TNotificationPreference : INotificationPreference<string, string>
    { }

    public class NotificationEvent<TKey, TOptionalKey, TNotificationPreference> : EntityBase<TKey, TOptionalKey>, INotificationEvent<TKey, TOptionalKey>
        where TNotificationPreference : INotificationPreference<TKey, TOptionalKey>
    {
        public NotificationEvent()
        {
            NotificationPreferences = new HashSet<TNotificationPreference>();
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public virtual ICollection<TNotificationPreference> NotificationPreferences
        {
            get;
            set;
        }
    }
}
