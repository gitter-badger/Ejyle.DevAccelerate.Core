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
    public class ServiceHook : ServiceHook<ServiceHookEvent>
    {
        public ServiceHook()
            : base()
        { }
    }

    public class ServiceHook<TServiceHookEvent> : ServiceHook<string, string, TServiceHookEvent>
        where TServiceHookEvent : IServiceHookEvent<string, string>
    {
        public ServiceHook()
            : base()
        { }
    }

    public class ServiceHook<TKey, TOptionalKey, TServiceHookEvent> : EntityBase<TKey, TOptionalKey>, IServiceHook<TKey, TOptionalKey>
        where TServiceHookEvent : IServiceHookEvent<TKey, TOptionalKey>
    {
        public ServiceHook()
            : base()
        { }

        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public TOptionalKey SystemAccountId { get; set; }
        public TKey ServiceHookEventId { get; set; }
        public virtual TServiceHookEvent ServiceHookEvent { get; set; }
    }
}
