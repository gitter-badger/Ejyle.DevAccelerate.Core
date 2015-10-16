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
    public interface IAppGroupRepository<TKey, TOptionalKey, TEntity> : IEntityRepository<TKey, TOptionalKey, TEntity>
        where TEntity : IAppGroup<TKey, TOptionalKey>
    {
        Task<List<TEntity>> FindAllAsync();
        Task CreateAppMappingAsync(AppMapping obj);
        Task RemoveAppMappingAsync(AppMapping obj);
        Task<List<AppMapping>> FindAllAppMappingAsync();
        Task<List<AppMapping>> FindAppMappingByGroupIdAsync(string Id);
        
    }
}
