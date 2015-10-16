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

    public class File<TKey, TOptionalKey, TFileType, TFileLocation> : EntityBase<TKey, TOptionalKey>, IFile<TKey, TOptionalKey>
         where TFileType : IFileType<TKey, TOptionalKey>
        where TFileLocation : IFileLocation<TKey, TOptionalKey>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string FileName { get; set; }
        public Nullable<int> FileSize { get; set; }
        public string Notes { get; set; }       
        public string UserPath { get; set; }
        public TKey FileOwner { get; set; }
        public TKey FileTypeId { get; set; }
        public TKey FileLocationId { get; set; }
        public virtual TFileType FileType { get; set; }
        public virtual TFileLocation Location { get; set; }
    }
}
