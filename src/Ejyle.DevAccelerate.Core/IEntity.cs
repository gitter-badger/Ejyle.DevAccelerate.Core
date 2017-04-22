// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Defines the properties for an entity.
    /// </summary>
    /// <typeparam name="TKey">The type of the entity ID.</typeparam>
    /// <typeparam name="TOptionalKey">The type of the entity optional ID.</typeparam>
    public interface IEntity<TKey, TOptionalKey>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the entity.
        /// </summary>
        TKey Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the user who created the entity.
        /// </summary>
        TKey CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the created date (UTC) of the entity.
        /// </summary>
        DateTime CreatedDateUtc
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the user who last updated the entity.
        /// </summary>
        TKey LastUpdatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last updated date (UTC) of the entity.
        /// </summary>
        DateTime LastUpdatedDateUtc
        {
            get;
            set;
        }
    }
}