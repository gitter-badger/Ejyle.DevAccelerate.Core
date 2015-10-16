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
    public interface IServiceHook<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name { get; set; }
        string Url {  get; set;}
        bool IsActive { get; set; }
        TOptionalKey SystemAccountId { get; set; }
        TKey ServiceHookEventId { get; set; }
    }
}
