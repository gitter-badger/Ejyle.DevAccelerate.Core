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
    public interface IUserRepository<TKey, TOptionalKey, TUser, TUserLogin, TUserRole, TUserClaim, TSecondaryEmailAddress> : IEntityRepository<TKey, TOptionalKey, TUser>
        where TUser : IUser<TKey, TOptionalKey, TUserLogin, TUserRole, TUserClaim>
        where TUserLogin : IUserLogin<TKey, TOptionalKey>
        where TUserRole : IUserRole<TKey, TOptionalKey>
        where TUserClaim : IUserClaim<TKey, TOptionalKey>
        where TSecondaryEmailAddress : IEmailAddress<TKey, TOptionalKey>
    { }
}