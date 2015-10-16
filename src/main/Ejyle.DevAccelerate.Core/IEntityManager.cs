// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    public interface IEntityManager<TKey, TOptionalKey, TEntity, TRepository>
        where TEntity : IEntity<TKey, TOptionalKey>
        where TRepository : IEntityRepository<TKey, TOptionalKey, TEntity>
    {
        Task CreateAsync(TEntity obj);
        Task<TEntity> FindByIdAsync(TKey id);
        Task DeleteAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
    }
}
