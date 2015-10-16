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
    public class UserPermissionManager<TKey, TOptionalKey, TUserPermission, TUserPermissionRepository> : EntityManagerBase<TKey, TOptionalKey, TUserPermission, TUserPermissionRepository>
        where TUserPermission : IUserPermission<TKey, TOptionalKey>
        where TUserPermissionRepository : IUserPermissionRepository<TKey, TOptionalKey, TUserPermission>
    {
        public UserPermissionManager(TUserPermissionRepository repository)
            : base(repository)
        { }
    }
}
