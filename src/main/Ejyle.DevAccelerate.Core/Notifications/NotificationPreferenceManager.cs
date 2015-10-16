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
    public class NotificationPreferenceManager<TNotificationPreferenceRepository> : NotificationPreferenceManager<NotificationPreference, TNotificationPreferenceRepository>
        where TNotificationPreferenceRepository : INotificationPreferenceRepository<string, string, NotificationPreference>
    {
        public NotificationPreferenceManager(TNotificationPreferenceRepository repository)
            : base(repository)
        { }
    }

    public class NotificationPreferenceManager<TNotificationPreference, TNotificationPreferenceRepository> : NotificationPreferenceManager<string, string, TNotificationPreference, TNotificationPreferenceRepository>
        where TNotificationPreference : INotificationPreference<string, string>
        where TNotificationPreferenceRepository : INotificationPreferenceRepository<string, string, TNotificationPreference>
    {
        public NotificationPreferenceManager(TNotificationPreferenceRepository repository)
            : base(repository)
        { }
    }

    public class NotificationPreferenceManager<TKey, TOptionalKey, TNotificationPreference, TNotificationPreferenceRepository> : EntityManagerBase<TKey, TOptionalKey, TNotificationPreference, TNotificationPreferenceRepository>
        where TNotificationPreference : INotificationPreference<TKey, TOptionalKey>
        where TNotificationPreferenceRepository : INotificationPreferenceRepository<TKey, TOptionalKey, TNotificationPreference>
    {
        public NotificationPreferenceManager(TNotificationPreferenceRepository repository)
            : base(repository)
        { }

        public Task<TNotificationPreference> FindAsync(TKey userId, NotificationChannel channel, String eventName)
        {
            return Repository.FindAsync(userId, channel, eventName);
        }

        public Task<List<TNotificationPreference>> FindByUserIdAsync(TKey userId)
        {
            return Repository.FindByUserIdAsync(userId);
        }
    }
}
