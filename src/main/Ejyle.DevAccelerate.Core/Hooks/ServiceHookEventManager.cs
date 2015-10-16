// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Hooks
{
    public class ServiceHookEventManager<TKey, TOptionalKey, TServiceHookEvent, TServiceHookEventRepository> : EntityManagerBase<TKey, TOptionalKey, TServiceHookEvent, TServiceHookEventRepository>
        where TServiceHookEvent : IServiceHookEvent<TKey, TOptionalKey>
        where TServiceHookEventRepository : IServiceHookEventRepository<TKey, TOptionalKey, TServiceHookEvent>
    {
        public ServiceHookEventManager(TServiceHookEventRepository repository)
            : base(repository)
        { }
    }
}
