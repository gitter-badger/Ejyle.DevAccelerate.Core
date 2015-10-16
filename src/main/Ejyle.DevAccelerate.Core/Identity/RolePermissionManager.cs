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
    public class RolePermissionManager<TKey, TOptionalKey, TRolePermission, TRolePermissionRepository> : EntityManagerBase<TKey, TOptionalKey, TRolePermission, TRolePermissionRepository>
        where TRolePermission : IRolePermission<TKey, TOptionalKey>
        where TRolePermissionRepository : IRolePermissionRepository<TKey, TOptionalKey, TRolePermission>
    {
        public RolePermissionManager(TRolePermissionRepository repository)
            : base(repository)
        { }
    }
}
