// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core
{
    public abstract class EntityBase : EntityBase<string, string>
    {
        protected EntityBase()
            : base()
        { }
    }

    /// <summary>
    /// Represents the base class for an entity.
    /// </summary>
    public abstract class EntityBase<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        /// <summary>
        /// Creates an instance of the <see cref="EntityBase"/> class.
        /// </summary>
        protected EntityBase()
        { }

        /// <summary>
        /// Gets or sets the unique ID of the object.
        /// </summary>
        public TKey Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the user who created the object.
        /// </summary>
        public TKey CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the created date of the object.
        /// </summary>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the user who last updated the object.
        /// </summary>
        public TKey LastUpdatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last updated date of the object.
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get;
            set;
        }
    }
}