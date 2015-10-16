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
    public class UserReportManager<TRepository> : EntityManagerBase<string, string, UserReport, IUserReportRepository<string, string, UserReport>>
        where TRepository : IUserReportRepository<string, string, UserReport>
    {
        public UserReportManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<UserReport>> FindByUserIdAsync(string userId)
        {
            return Repository.FindByUserIdAsync(userId);
        }
    }
}
