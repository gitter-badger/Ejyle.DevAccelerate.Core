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
    public interface ISystemAccountRepository<TKey, TOptionalKey, TSystemAccount, TSystemAccountMember> : IEntityRepository<TKey, TOptionalKey, TSystemAccount>
        where TSystemAccount : ISystemAccount<TKey, TOptionalKey>
        where TSystemAccountMember : ISystemAccountMember<TKey, TOptionalKey>
    {
        void Create(TSystemAccount systemAccount);
        TSystemAccount FindById(TKey id);
        TSystemAccount FindByName(string name);
        Task<TSystemAccount> FindByNameAsync(string name);
        Task<TSystemAccountMember> FindSystemAccountMemberByIdAsync(TKey systemAccountUserId);
        Task<TSystemAccountMember> FindSystemAccountMembersByUserIdAsync(TKey userId, string SysAccId);
        List<TSystemAccountMember> FindSystemAccountMembersByUserId(TKey userId);
        Task<List<TSystemAccount>> FindAllItemsAsync();
        Task AddSystemAccountMemberAsync(SystemAccountMember obj);
        Task RemoveSystemAccountMemberAsync(SystemAccountMember obj);
       
    }
}
