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
    public class AppGroupsManager<TRepository> : AppGroupsManager<AppGroup, TRepository>
        where TRepository : IAppGroupRepository<string, string, AppGroup>
    {
        public AppGroupsManager(TRepository repository)
            : base(repository)
        { }
    }
    public class AppGroupsManager<TEntity, TRepository> : AppGroupsManager<string, string, TEntity, TRepository>
        where TEntity : IAppGroup<string, string>
        where TRepository : IAppGroupRepository<string, string, TEntity>
    {
        public AppGroupsManager(TRepository repository)
            : base(repository)
        { }
    }
    public class AppGroupsManager<TKey, TOptionalKey, TEntity, TRepository> : EntityManagerBase<TKey, TOptionalKey, TEntity, TRepository>
        where TEntity : IAppGroup<TKey, TOptionalKey>
        where TRepository :IAppGroupRepository<TKey, TOptionalKey, TEntity>
    {
        public AppGroupsManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<TEntity>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
        
        public Task CreateAppMappingAsync(AppMapping obj)
        {
            return Repository.CreateAppMappingAsync(obj);
        }

        public Task RemoveAppMappingAsync(AppMapping obj)
        {
            return Repository.RemoveAppMappingAsync(obj);
        }

        public Task<List<AppMapping>> FindAllAppMappingAsync()
        {
            return Repository.FindAllAppMappingAsync();
        }

        public Task<List<AppMapping>> FindAppMappingByGroupIdAsync(string Id)
        {
            return Repository.FindAppMappingByGroupIdAsync(Id);
        }       
    }
}
