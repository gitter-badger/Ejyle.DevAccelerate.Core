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
    public class UserActionTokenManager<TKey, TOptionalKey, TUserActionToken, TUserActionTokenRepository> : EntityManagerBase<TKey, TOptionalKey, TUserActionToken, TUserActionTokenRepository>
        where TUserActionToken : IUserActionToken<TKey, TOptionalKey>
        where TUserActionTokenRepository : IUserActionTokenRepository<TKey, TOptionalKey, TUserActionToken>
    {
        public UserActionTokenManager(TUserActionTokenRepository repository)
            : base(repository)
        { }

        public Task<TUserActionToken> FindAsync(TKey userId, string token)
        {
            return Repository.FindAsync(userId, token);
        }
    }
}
