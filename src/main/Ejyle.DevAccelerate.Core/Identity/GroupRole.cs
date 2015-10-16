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
    public class GroupRole : GroupRole<Group>
    {
        public GroupRole()
            : base()
        { }
    }

    public class GroupRole<TGroup> : GroupRole<string, string, TGroup>
        where TGroup : IGroup<string, string>
    {
        public GroupRole()
            : base()
        { }
    }

    public class GroupRole<TKey, TOptionalKey, TGroup> : EntityBase<TKey, TOptionalKey>, IGroupRole<TKey, TOptionalKey>
        where TGroup : IGroup<TKey, TOptionalKey>
    {
        public GroupRole()
            : base()
        { }

        public TKey GroupId
        {
            get;
            set;
        }

        public TKey RoleId
        {
            get;
            set;
        }

        public virtual TGroup Group
        {
            get;
            set;
        }
    }
}
