// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Files
{
    public class FileManager<TFileRepository> : FileManager<File, FileLocation, TFileRepository>
        where TFileRepository : IFileRepository<string, string, File, FileLocation>
    {
        public FileManager(TFileRepository repository)
            : base(repository)
        { }
    }

    public class FileManager<TFile, TFileLocation, TFileRepository> : FileManager<string, string, TFile, TFileLocation, TFileRepository>
        where TFile : IFile<string, string>
        where TFileLocation : IFileLocation<string, string>
        where TFileRepository : IFileRepository<string, string, TFile, TFileLocation>
    {
        public FileManager(TFileRepository repository)
            : base(repository)
        { }
    }

    public class FileManager<TKey, TOptionalKey, TFile, TFileLocation, TFileRepository> : EntityManagerBase<TKey, TOptionalKey, TFile, TFileRepository>
        where TFile : IFile<TKey, TOptionalKey>
        where TFileLocation : IFileLocation<TKey, TOptionalKey>
        where TFileRepository : IFileRepository<TKey, TOptionalKey, TFile, TFileLocation>
    {
        public FileManager(TFileRepository repository)
            : base(repository)
        { }

        public Task<TFileLocation> FindFileLocationByNameAsync(string source, string name)
        {
            return Repository.FindFileLocationByNameAsync(source, name);
        }
    }
}
