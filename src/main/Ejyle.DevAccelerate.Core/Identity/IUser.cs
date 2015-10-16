// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public interface IUser<TKey, TOptionalKey, TUserLogin, TUserRole, TUserClaim> : IUser<TKey, TOptionalKey>
        where TUserLogin : IUserLogin<TKey, TOptionalKey>
        where TUserRole : IUserRole<TKey, TOptionalKey>
        where TUserClaim : IUserClaim<TKey, TOptionalKey>
    { }

    public interface IUser<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string UserName { get; set; }
        string Email { get; set; }
    }
}
