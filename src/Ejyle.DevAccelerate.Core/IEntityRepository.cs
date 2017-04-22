// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Defines the methods for entity management.
    /// </summary>
    /// <typeparam name="TKey">The key of the entity.</typeparam>
    /// <typeparam name="TOptionalKey">The optional key of the entity.</typeparam>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    public interface IEntityRepository<TKey, TOptionalKey, TEntity> : IDisposable
        where TEntity : IEntity<TKey, TOptionalKey>
    {
        /// <summary>
        /// Asynchronously creates a new entity of TEntity type.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        Task CreateAsync(TEntity entity);

        /// <summary>
        /// Asynchronously finds an entity of TEntity type by ID.
        /// </summary>
        /// <param name="id">The entity ID.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        Task<TEntity> FindByIdAsync(TKey id);

        /// <summary>
        /// Asynchronously deletes an entity of TEntity type.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        Task DeleteAsync(TEntity entity);

        /// <summary>
        /// Asynchronously updates a entity of TEntity type.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        Task UpdateAsync(TEntity entity);
    }
}
