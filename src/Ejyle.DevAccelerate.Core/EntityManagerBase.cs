// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Represents the APIs for entity management and uses the entity repository internally.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the manager.</typeparam>
    /// <typeparam name="TOptionalKey">The type of the optional keys in the manager.</typeparam>
    /// <typeparam name="TEntity">The type of the entity in the manager.</typeparam>
    /// <typeparam name="TRepository">The type of the entity repository.</typeparam>
    public abstract class EntityManagerBase<TKey, TOptionalKey, TEntity, TRepository>
        where TEntity : IEntity<TKey, TOptionalKey>
        where TRepository : IEntityRepository<TKey, TOptionalKey, TEntity>
    {
        #region Fields

        private TRepository _Repository;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes an instance of the <see cref="EntityManagerBase{TKey, TOptionalKey, TEntity, TRepository}"/> class.
        /// </summary>
        /// <param name="repository">The repository responsible for commiting changes.</param>
        protected EntityManagerBase(TRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            _Repository = repository;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the repository responsible for commiting changes.
        /// </summary>
        public TRepository Repository
        {
            get
            {
                return _Repository;
            }
        }

        #endregion Properties

        #region Virtual Methods

        /// <summary>
        /// Asynchronously creates a new entity.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        public virtual Task CreateAsync(TEntity entity)
        {
            return Repository.CreateAsync(entity);
        }

        /// <summary>
        /// Asynchronously deletes an entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        public virtual Task DeleteAsync(TEntity entity)
        {
            return Repository.DeleteAsync(entity);
        }

        /// <summary>
        /// Asynchronously updates a entity type.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        public virtual Task UpdateAsync(TEntity entity)
        {
            return Repository.UpdateAsync(entity);
        }

        /// <summary>
        /// Asynchronously finds an entity by ID.
        /// </summary>
        /// <param name="id">The entity ID.</param>
        /// <returns>The task representing the asynchronous operation.</returns>
        public virtual Task<TEntity> FindByIdAsync(TKey id)
        {
            return Repository.FindByIdAsync(id);
        } 

        #endregion Virtual Methods
    }
}