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
    public class GroupManager<TGroupRepository> : GroupManager<Group, GroupMember, TGroupRepository>
        where TGroupRepository : IGroupRepository<string, string, Group, GroupMember> 
    {
        public GroupManager(TGroupRepository repository)
            : base(repository)
        { }
    }

    public class GroupManager<TGroup, TGroupMember, TGroupRepository> : GroupManager<string, string, TGroup, TGroupMember, TGroupRepository>
        where TGroup : IGroup<string, string>
        where TGroupMember: IGroupMember<string, string>
        where TGroupRepository : IGroupRepository<string, string, TGroup, TGroupMember> 
    {
        public GroupManager(TGroupRepository repository)
            : base(repository)
        { }
    }

    public class GroupManager<TKey, TOptionalKey, TGroup, TGroupMember, TGroupRepository> : EntityManagerBase<TKey, TOptionalKey, TGroup, TGroupRepository>
        where TGroup : IGroup<TKey, TOptionalKey>
        where TGroupMember : IGroupMember<TKey, TOptionalKey>
        where TGroupRepository : IGroupRepository<TKey, TOptionalKey, TGroup, TGroupMember>
    {
        public GroupManager(TGroupRepository repository)
            : base(repository)
        { }

        public Task<List<TGroup>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }

        public Task<TGroup> FindByNameAsync(string Name)
        {
            return Repository.FindByNameAsync(Name);
        }

        public Task<List<TGroup>> FindGroupByOwnerAsync(TKey OwnerUserId)
        {
            return Repository.FindGroupByOwnerAsync(OwnerUserId);
        }

        public Task<List<TGroup>> FindGroupBySystemAccountIdAsync(TKey SystemAccountId)
        {
            return Repository.FindGroupBySystemAccountIdAsync(SystemAccountId);
        }

        public Task<TGroupMember> FindGroupMemberByUserIdAsync(TKey UserId)
        {
            return Repository.FindGroupMemberByUserIdAsync(UserId);
        }

        public Task AddMemberAsync(TGroupMember obj)
        {
            return Repository.AddMemberAsync(obj);
        }

        public Task RemoveMemberAsync(TGroupMember obj)
        {
            return Repository.RemoveMemberAsync(obj);
        }
        public Task<List<GroupRole>> FindGroupRolesByIdAsync(string GroupId)
        {
            return Repository.FindGroupRolesByIdAsync(GroupId);
        }
        public Task<GroupRole> FindGroupRolesByRoleIdAsync(string RoleId)
        { 
            return Repository.FindGroupRolesByRoleIdAsync(RoleId);
        }
        public Task AddRoleAsync(GroupRole obj)
        {
            return Repository.AddRoleAsync(obj);
        }
        public Task RemoveRoleAsync(GroupRole obj)
        {
            return Repository.RemoveRoleAsync(obj);
        }
    }
}
