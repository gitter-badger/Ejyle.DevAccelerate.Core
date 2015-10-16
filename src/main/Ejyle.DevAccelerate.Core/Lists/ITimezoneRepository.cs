// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Lists
{
    public interface ITimezoneRepository<TKey, TOptionalKey, TTimezone> : IEntityRepository<TKey, TOptionalKey, TTimezone>
        where TTimezone : ITimezone<TKey, TOptionalKey>
    {
        Task<List<TTimezone>> FindAllAsync();
    }
}
