// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using Ejyle.DevAccelerate.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    public abstract class EntityManagerBase<TEntity, TRepository> : EntityManagerBase<string, string, TEntity, TRepository>
        where TEntity : IEntity<string, string>
        where TRepository : IEntityRepository<string, string, TEntity>
    {
        #region Constructors

        protected EntityManagerBase(TRepository repository)
            : base(repository)
        { }

        #endregion Constructors
    }

    public abstract class EntityManagerBase<TKey, TOptionalKey, TEntity, TRepository> : IEntityManager<TKey, TOptionalKey, TEntity, TRepository>
        where TEntity : IEntity<TKey, TOptionalKey>
        where TRepository : IEntityRepository<TKey, TOptionalKey, TEntity>
    {
        #region Fields

        private TRepository _Repository;

        #endregion Fields

        #region Constructors

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

        public TRepository Repository
        {
            get
            {
                return _Repository;
            }
        }

        #endregion Properties

        #region Virtual Methods

        public virtual Task CreateAsync(TEntity obj)
        {
            return Repository.CreateAsync(obj);
        }

        public virtual Task DeleteAsync(TEntity obj)
        {
            return Repository.DeleteAsync(obj);
        }

        public virtual Task UpdateAsync(TEntity obj)
        {
            return Repository.UpdateAsync(obj);
        }

        public virtual Task<TEntity> FindByIdAsync(TKey id)
        {
            return Repository.FindByIdAsync(id);
        } 
        #endregion Virtual Methods
    }
}