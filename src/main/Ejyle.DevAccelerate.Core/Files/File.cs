// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Files
{
    public class File : File<FileType, FileLocation>
    { }

    public class File<TFileType, TFileLocation> : File<string, string, TFileType, TFileLocation>
        where TFileType : IFileType<string, string>
        where TFileLocation : IFileLocation<string, string>
    { }

    /// <summary>
    /// Represents a file.
    /// </summary>
    /// <typeparam name="TKey">The type of the unique identifier of the file.</typeparam>
    /// <typeparam name="TOptionalKey">The type of an optional key.</typeparam>
    /// <typeparam name="TFileType">The type of the file type.</typeparam>
    /// <typeparam name="TFileLocation">The type of the file location.</typeparam>
    public class File<TKey, TOptionalKey, TFileType, TFileLocation> : EntityBase<TKey, TOptionalKey>, IFile<TKey, TOptionalKey>
         where TFileType : IFileType<TKey, TOptionalKey>
        where TFileLocation : IFileLocation<TKey, TOptionalKey>
    {
        /// <summary>
        /// Gets or sets the logical name of the file.
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets physical name of the file.
        /// </summary>
        [Required]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets size of the file in bytes.
        /// </summary>
        public Nullable<int> FileSize { get; set; }

        /// <summary>
        /// Gets or sets note about the file.
        /// </summary>
        public string Notes { get; set; }   
    
        /// <summary>
        /// Gets or sets the user specific part of the file's path.
        /// </summary>
        public string UserPath { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who owns the file.
        /// </summary>
        public TKey FileOwner { get; set; }

        /// <summary>
        /// Gets or sets the ID of the file's type.
        /// </summary>
        public TKey FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the file's location.
        /// </summary>
        public TKey FileLocationId { get; set; }

        /// <summary>
        /// Gets or sets the file's file type object.
        /// </summary>
        public virtual TFileType FileType { get; set; }

        /// <summary>
        /// Gets or sets the file's file location object.
        /// </summary>
        public virtual TFileLocation Location { get; set; }
    }
}
