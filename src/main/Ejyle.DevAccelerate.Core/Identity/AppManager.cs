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
    public class AppManager<TRepository> : AppManager<App, TRepository>
        where TRepository : IAppRepository<string, string, App>
    {
        public AppManager(TRepository repository)
            : base(repository)
        { }
    }

    public class AppManager<TEntity, TRepository> : AppManager<string, string, TEntity, TRepository>
        where TEntity : IApp<string, string>
        where TRepository : IAppRepository<string, string, TEntity>
    {
        public AppManager(TRepository repository)
            : base(repository)
        { }
    }

    public class AppManager<TKey, TOptionalKey, TEntity, TRepository> : EntityManagerBase<TKey, TOptionalKey, TEntity, TRepository>
        where TEntity : IApp<TKey, TOptionalKey>
        where TRepository : IAppRepository<TKey, TOptionalKey, TEntity>
    {
        public AppManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<TEntity>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
        public Task<TEntity> FindByNameAsync(string Name)
        {
            return Repository.FindByNameAsync(Name);
        }

        public Task<AppResource> FindResourceByPathAsync(string appId, string path)
        {
            return Repository.FindResourceByPathAsync(appId, path);
        }

        public Task<TEntity> FindByKeyAsync(string key)
        {
            return Repository.FindByKeyAsync(key);
        }

        public Task CreateAppResourceAsync(AppResource obj)
        {
            return Repository.CreateAppResourceAsync(obj);
        }
        public Task UpdateAppResourceAsync(AppResource obj)
        {
            return Repository.UpdateAppResourceAsync(obj);
        }
        public Task DeleteAppResourceAsync(AppResource obj)
        {
            return Repository.DeleteAppResourceAsync(obj);
        }
        public Task DeleteAppResourceActionAsync(AppResourceAction obj)
        {
            return Repository.DeleteAppResourceActionAsync(obj);
        }
        public Task UpdateAppResourceActionAsync(AppResourceAction obj)
        {
            return Repository.UpdateAppResourceActionAsync(obj);
        }
        public Task CreateAppResourceActionAsync(AppResourceAction obj)
        {
            return Repository.CreateAppResourceActionAsync(obj);
        }
        public Task<AppResource> FindAppResourceByIdAsync(string id)
        {
            return Repository.FindAppResourceByIdAsync(id);
        }
        public Task<AppResource> FindAppResourceByNameAsync(string Name)
        {
            return Repository.FindAppResourceByNameAsync(Name);
        }
        public Task<AppResourceAction> FindAppResourceActionByIdAsync(string Id, string AppResourceId)
        {
            return Repository.FindAppResourceActionByIdAsync(Id, AppResourceId);
        } 
        public Task<AppResourceAction> FindAppResourceActionByNameAsync(string Name, string AppResourceId)
        {
            return Repository.FindAppResourceActionByNameAsync(Name, AppResourceId);
        } 
        public Task<List<AppResource>> FindAppResourceByAppIdAsync(string appId)
        {
            return Repository.FindAppResourceByAppIdAsync(appId);
        }
        public Task<List<AppResource>> FindAppResourceAllAsync()
        {
            return Repository.FindAppResourceAllAsync();
        }
        public Task<List<AppResourceAction>> FindAppResourceActionAllAsync()
        {
            return Repository.FindAppResourceActionAllAsync();
        }
        public Task<AppResourceAction> FindAppResourceActionByIdAsync(string id)
        {
            return Repository.FindAppResourceActionByIdAsync(id);
        }
    }
}
