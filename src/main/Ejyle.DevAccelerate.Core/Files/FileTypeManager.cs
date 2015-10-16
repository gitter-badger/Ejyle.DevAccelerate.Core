// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Files
{
    public class FileTypeManager<TFileTypeRepository> : FileTypeManager<string, string, FileType, TFileTypeRepository>
        where TFileTypeRepository : IFileTypeRepository<string, string, FileType>
    {
        public FileTypeManager(TFileTypeRepository repository)
            : base(repository)
        { }
    }

    public class FileTypeManager<TFileType, TFileTypeRepository> : FileTypeManager<string, string, TFileType, TFileTypeRepository>
        where TFileType : IFileType<string, string>
        where TFileTypeRepository : IFileTypeRepository<string, string, TFileType>
    {
        public FileTypeManager(TFileTypeRepository repository)
            : base(repository)
        { }
    }

    public class FileTypeManager<TKey, TOptionalKey, TFileType, TFileTypeRepository> : EntityManagerBase<TKey, TOptionalKey, TFileType, TFileTypeRepository>
        where TFileType : IFileType<TKey, TOptionalKey>
        where TFileTypeRepository : IFileTypeRepository<TKey, TOptionalKey, TFileType>
     {
        public FileTypeManager(TFileTypeRepository repository)
            : base(repository)
        { }

        public Task<TFileType> FindByMimeTypeAsync(string mimeType)
        {
            return Repository.FindByMimeTypeAsync(mimeType);
        }
        public Task<List<TFileType>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
    }
}
