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
    public interface IGroupRepository<TKey, TOptionalKey, TGroup, TGroupMember> : IEntityRepository<TKey, TOptionalKey, TGroup>
        where TGroup : IGroup<TKey, TOptionalKey>
        where TGroupMember : IGroupMember<TKey, TOptionalKey>
    {
        Task<List<TGroup>> FindAllAsync();
        Task<TGroup> FindByNameAsync(string Name);
        Task<List<TGroup>> FindGroupByOwnerAsync(TKey OwnerUserId);
        Task<List<TGroup>> FindGroupBySystemAccountIdAsync(TKey SystemAccountId);
        Task<TGroupMember> FindGroupMemberByUserIdAsync(TKey UserId);
        Task AddMemberAsync(TGroupMember obj);
        Task RemoveMemberAsync(TGroupMember obj);
        Task<List<GroupRole>> FindGroupRolesByIdAsync(string GroupId);
        Task AddRoleAsync(GroupRole obj);
        Task RemoveRoleAsync(GroupRole obj);
        Task<GroupRole> FindGroupRolesByRoleIdAsync(string RoleId);
        
        
    }
}
