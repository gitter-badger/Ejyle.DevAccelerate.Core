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
    public interface INotificationPreferenceRepository<TKey, TOptionalKey, TNotificationPreference> : IEntityRepository<TKey, TOptionalKey, TNotificationPreference>
        where TNotificationPreference : INotificationPreference<TKey, TOptionalKey>
    {
        Task<TNotificationPreference> FindAsync(TKey userId, NotificationChannel channel, string eventName);
        Task<List<TNotificationPreference>> FindByUserIdAsync(TKey userId);
    }
}
