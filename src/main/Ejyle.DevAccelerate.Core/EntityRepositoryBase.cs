// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    public abstract class EntityRepositoryBase<TKey, TOptionalKey, TEntity> : IEntityRepository<TKey, TOptionalKey, TEntity>
        where TEntity : IEntity<TKey, TOptionalKey>
    {
        public EntityRepositoryBase()
        { }

        public abstract Task CreateAsync(TEntity obj);
        public abstract Task<TEntity> FindByIdAsync(TKey id);
        public abstract Task DeleteAsync(TEntity obj);
        public abstract Task UpdateAsync(TEntity obj);

        public abstract void Dispose();
    }
}
