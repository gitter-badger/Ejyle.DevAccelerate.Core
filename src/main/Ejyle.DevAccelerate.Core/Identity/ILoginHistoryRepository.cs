// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public interface ILoginHistoryRepository<TKey, TOptionalKey, TLoginHistory> : IEntityRepository<TKey, TOptionalKey, TLoginHistory>
        where TLoginHistory : ILoginHistory<TKey, TOptionalKey>
    {
        Task<List<LoginHistory>> FindByUserIdAsync(TKey userId, DateTime fromDate, DateTime toDate);
    }
}
