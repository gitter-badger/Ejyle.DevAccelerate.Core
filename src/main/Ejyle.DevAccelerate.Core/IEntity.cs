// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Represents the base class for an entity.
    /// </summary>
    public interface IEntity<TKey, TOptionalKey>
    {
        /// <summary>
        /// Gets or sets the Id of the object.
        /// </summary>
        TKey Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the user who created the object.
        /// </summary>
        TKey CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the created date of the object.
        /// </summary>
        DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the user who last updated the object.
        /// </summary>
        TKey LastUpdatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last updated date of the object.
        /// </summary>
        DateTime LastUpdatedDate
        {
            get;
            set;
        }
    }
}