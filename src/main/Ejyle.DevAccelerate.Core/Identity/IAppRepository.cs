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
    public interface IAppRepository<TKey, TOptionalKey, TEntity> : IEntityRepository<TKey, TOptionalKey, TEntity>
        where TEntity : IApp<TKey, TOptionalKey>
    {
        Task<List<TEntity>> FindAllAsync();
        Task<AppResource> FindResourceByPathAsync(string appId, string path);
        Task<TEntity> FindByKeyAsync(string key);
        Task<TEntity> FindByNameAsync(string Name);
        Task CreateAppResourceAsync(AppResource obj);
        Task UpdateAppResourceAsync(AppResource obj);
        Task DeleteAppResourceAsync(AppResource obj);
        Task DeleteAppResourceActionAsync(AppResourceAction obj);
        Task UpdateAppResourceActionAsync(AppResourceAction obj);
        Task CreateAppResourceActionAsync(AppResourceAction obj);
        Task<AppResource> FindAppResourceByIdAsync(string id);
        Task<AppResource> FindAppResourceByNameAsync(string Name);
        Task<AppResourceAction> FindAppResourceActionByIdAsync(string Id, string AppResourceId);
        Task<AppResourceAction> FindAppResourceActionByNameAsync(string Name, string AppResourceId);
        Task<List<AppResource>> FindAppResourceByAppIdAsync(string appId);
        Task<List<AppResource>> FindAppResourceAllAsync();
        Task<List<AppResourceAction>> FindAppResourceActionAllAsync();
        Task<AppResourceAction> FindAppResourceActionByIdAsync(string id);
    }
}
