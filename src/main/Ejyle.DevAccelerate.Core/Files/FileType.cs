// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Files
{
    public class FileType : FileType<File>
    {
        public FileType()
            : base()
        { }
    }

    public class FileType<TFile> : FileType<string, string, TFile>
        where TFile : IFile<string, string>
    {
        public FileType()
            : base()
        { }
    }

    public class FileType<TKey, TOptionalKey, TFile> : EntityBase<TKey, TOptionalKey>, IFileType<TKey, TOptionalKey>
        where TFile : IFile<TKey, TOptionalKey>
    {
        public FileType()
        {
            Files = new HashSet<TFile>();
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Nullable<FileTypeCategory> FileTypeCategory { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public Nullable<int> MaxSize { get; set; }
        public virtual ICollection<TFile> Files { get; set; }
    }
}
