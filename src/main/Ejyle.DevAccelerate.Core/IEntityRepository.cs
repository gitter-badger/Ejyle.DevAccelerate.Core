// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    public interface IEntityRepository<TKey, TOptionalKey, TEntity> : IDisposable
        where TEntity : IEntity<TKey, TOptionalKey>
    {
        Task CreateAsync(TEntity obj);
        Task<TEntity> FindByIdAsync(TKey id);
        Task DeleteAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
    }
}
