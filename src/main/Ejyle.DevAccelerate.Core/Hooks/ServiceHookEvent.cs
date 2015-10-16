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
    public class ServiceHookEvent : ServiceHookEvent<ServiceHook>
    {
        public ServiceHookEvent()
            : base()
        { }
    }

    public class ServiceHookEvent<TServiceHook> : ServiceHookEvent<string, string, TServiceHook>
        where TServiceHook : IServiceHook<string, string>
    {
        public ServiceHookEvent()
            : base()
        { }
    }

    public  class ServiceHookEvent<TKey, TOptionalKey, TServiceHook> : EntityBase<TKey, TOptionalKey>, IServiceHookEvent<TKey, TOptionalKey>
        where TServiceHook : IServiceHook<TKey, TOptionalKey>
    {
        public ServiceHookEvent()
            : base()
        {
            ServiceHooks = new HashSet<TServiceHook>();
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public virtual ICollection<TServiceHook> ServiceHooks { get; set; }
    }
}
