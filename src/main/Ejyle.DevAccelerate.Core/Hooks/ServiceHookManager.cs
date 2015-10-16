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

namespace Ejyle.DevAccelerate.Core.Hooks
{
    public class ServiceHookManager<TServiceHookRepository> : ServiceHookManager<ServiceHook, TServiceHookRepository>
    where TServiceHookRepository : IServiceHookRepository<string, string, ServiceHook>
    {
        public ServiceHookManager(TServiceHookRepository repository)
            : base(repository)
        { }

        public Task<List<ServiceHookEvent>> GetAllServiceHookEvents()
        {
            return Repository.GetAllServiceHookEvents();
        }

        public Task<List<ServiceHook>> GetAllServiceHooks()
        {
            return Repository.GetAllServiceHooks();
        }
    }

    public class ServiceHookManager<TServiceHook, TServiceHookRepository> : ServiceHookManager<string, string, TServiceHook, TServiceHookRepository>
        where TServiceHook : IServiceHook<string, string>
        where TServiceHookRepository : IServiceHookRepository<string, string, TServiceHook>
    {
        public ServiceHookManager(TServiceHookRepository repository)
            : base(repository)
        { }
    }

    public class ServiceHookManager<TKey, TOptionalKey, TServiceHook, TServiceHookRepository> : EntityManagerBase<TKey, TOptionalKey, TServiceHook, TServiceHookRepository>
        where TServiceHook : IServiceHook<TKey, TOptionalKey>
        where TServiceHookRepository : IServiceHookRepository<TKey, TOptionalKey, TServiceHook>
    {
        public ServiceHookManager(TServiceHookRepository repository)
            : base(repository)
        { }

    }
}
