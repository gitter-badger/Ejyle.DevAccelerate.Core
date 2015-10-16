// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Files
{
    public class FileLocation : FileLocation<File>
    { }

    public class FileLocation<TFile> : FileLocation<string, string, TFile>
        where TFile : IFile<string, string>
    {
    }

    public class FileLocation<TKey, TOptionalKey, TFile> : EntityBase<TKey, TOptionalKey>, IFileLocation<TKey, TOptionalKey>
        where TFile : IFile<TKey, TOptionalKey>
    {
        public FileLocation()
        {
            Files = new HashSet<TFile>();
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public string Path
        {
            get;
            set;
        }

        public string Source
        {
            get;
            set;
        }

        public virtual ICollection<TFile> Files
        {
            get;
            set;
        }
    }
}
