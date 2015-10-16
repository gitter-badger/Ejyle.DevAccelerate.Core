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
    public interface IUserActionTokenRepository<TKey, TOptionalKey, TUserActionToken> : IEntityRepository<TKey, TOptionalKey, TUserActionToken>
        where TUserActionToken : IUserActionToken<TKey, TOptionalKey>
    {
        Task<TUserActionToken> FindAsync(TKey userId, string token);
    }
}
