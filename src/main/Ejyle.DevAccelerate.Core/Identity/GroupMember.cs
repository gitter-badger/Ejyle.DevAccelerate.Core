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
    public class GroupMember : GroupMember<Group>
    {
    }

    public class GroupMember<TGroup> : GroupMember<string, string, TGroup>
        where TGroup : IGroup<string, string>
    {
    }

    public class GroupMember<TKey, TOptionalKey, TGroup> : EntityBase<TKey, TOptionalKey>, IGroupMember<TKey, TOptionalKey>
    where TGroup : IGroup<TKey, TOptionalKey>
    {
        public TKey GroupId { get; set; }
        public TKey SystemAccountUserId { get; set; }
        public virtual TGroup Group { get; set; }
    }
}
