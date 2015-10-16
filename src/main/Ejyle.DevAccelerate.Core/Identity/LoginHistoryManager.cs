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
    public class LoginHistoryManager<TRepository> : EntityManagerBase<string, string, LoginHistory, ILoginHistoryRepository<string, string, LoginHistory>>
        where TRepository : ILoginHistoryRepository<string, string, LoginHistory>
    {
        public LoginHistoryManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<LoginHistory>> FindByUserIdAsync(string userId, DateTime fromDate, DateTime toDate)
        {
            return Repository.FindByUserIdAsync(userId, fromDate, toDate);
        }
    }
}
