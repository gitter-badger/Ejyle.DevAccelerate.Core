// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class Group : Group<GroupMember, GroupRole>
    {
        public Group()
            : base()
        {
            Children = new HashSet<Group>();
        }

        public virtual ICollection<Group> Children { get; set; }
        public virtual Group Parent { get; set; }
    }

    public class Group<TGroupMember, TGroupRole> : Group<string, string, TGroupMember, TGroupRole>
        where TGroupMember : IGroupMember<string, string>
        where TGroupRole : IGroupRole<string, string>
    {
        public Group()
            : base()
        { }
    }

    public class Group<TKey, TOptionalKey, TGroupMember, TGroupRole> : EntityBase<TKey, TOptionalKey>, IGroup<TKey, TOptionalKey>
      where TGroupMember : IGroupMember<TKey, TOptionalKey>
      where TGroupRole : IGroupRole<TKey, TOptionalKey>
    {
        public Group()
        {
            GroupRoles = new HashSet<TGroupRole>();
            GroupMembers = new HashSet<TGroupMember>();
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Descrption { get; set; }
        public TKey SystemAccountId { get; set; }
        public TKey OwnerUserId { get; set; }
        public TOptionalKey ParentId { get; set; }
        public virtual ICollection<TGroupRole> GroupRoles { get; set; }
        public virtual ICollection<TGroupMember> GroupMembers { get; set; }
    }
}
