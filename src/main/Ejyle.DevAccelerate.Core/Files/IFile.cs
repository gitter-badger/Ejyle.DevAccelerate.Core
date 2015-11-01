// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Files
{
    /// <summary>
    /// Defines the properties of a file.
    /// </summary>
    /// <typeparam name="TKey">The unique identifier of the file.</typeparam>
    /// <typeparam name="TOptionalKey">The optional key.</typeparam>
    public interface IFile<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        /// <summary>
        /// Gets or sets the physical name of the file.
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets logical name of the file.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the size of the file in bytes.
        /// </summary>
        Nullable<int> FileSize { get; set; }

        /// <summary>
        /// Gets or sets user specific part of the file's path.
        /// </summary>
        string UserPath { get; set; }

        /// <summary>
        /// Gets or sets the notes about the file.
        /// </summary>
        string Notes { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who owns the file.
        /// </summary>
        TKey FileOwner { get; set; }

        /// <summary>
        /// Gets or sets the ID of the file's type.
        /// </summary>
        TKey FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the file's location.
        /// </summary>
        TKey FileLocationId { get; set; }
    }
}
