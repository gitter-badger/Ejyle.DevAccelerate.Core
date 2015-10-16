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
    public interface IFileTypeRepository<TKey, TOptionalKey, TFileType> : IEntityRepository<TKey, TOptionalKey, TFileType>
        where TFileType : IFileType<TKey, TOptionalKey>
    {
        Task<TFileType> FindByMimeTypeAsync(string mimeType);
        Task<List<TFileType>> FindAllAsync();
    }
}
