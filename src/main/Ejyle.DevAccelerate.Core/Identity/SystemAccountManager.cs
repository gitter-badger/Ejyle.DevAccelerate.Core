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
    public class SystemAccountManager<TRepository> : EntityManagerBase<string, string, SystemAccount, TRepository>
        where TRepository : ISystemAccountRepository<string, string, SystemAccount, SystemAccountMember>
    {
        public SystemAccountManager(TRepository repository)
            : base(repository)
        { }

        public SystemAccount FindById(string id)
        {
            return Repository.FindById(id);
        }
        public Task<List<SystemAccount>> FindAllItemsAsync()
        {
            return Repository.FindAllItemsAsync();
        }

        public SystemAccount FindByName(string name)
        {
            return Repository.FindByName(name);
        }

        public Task<SystemAccount> FindByNameAsync(string name)
        {
            return Repository.FindByNameAsync(name);
        }

        public Task<SystemAccountMember> FindSystemAccountUserByIdAsync(string systemAccountUserId)
        {
            return Repository.FindSystemAccountMemberByIdAsync(systemAccountUserId);
        }

        public List<SystemAccountMember> FindSystemAccountMembersByUserId(string userId)
        {
            return Repository.FindSystemAccountMembersByUserId(userId);
        }

        public Task<SystemAccountMember> FindSystemAccountUserByUserIdAsync(string userId, string SysAccId)
        {
            return Repository.FindSystemAccountMembersByUserIdAsync(userId, SysAccId);
        }
        public Task AddSystemAccountMemberAsync(SystemAccountMember obj)
        {
            return Repository.AddSystemAccountMemberAsync(obj);
        }
        public Task RemoveSystemAccountMemberAsync(SystemAccountMember obj)
        {
            return Repository.RemoveSystemAccountMemberAsync(obj);
        }
    }
}
