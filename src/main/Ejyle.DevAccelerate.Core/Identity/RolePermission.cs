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
    public class RolePermission : RolePermission<string, string>
    {
        public RolePermission()
            : base()
        { }
    }

    public class RolePermission<TKey, TOptionalKey> : AppResourcePermissionBase<TKey, TOptionalKey>, IRolePermission<TKey, TOptionalKey>
    {
        public RolePermission()
            : base()
        { }

        public TKey RoleId
        {
            get;
            set;
        }
    }
}
