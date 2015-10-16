// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Files
{
    public interface IFileType<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name { get; set; }
        Nullable<FileTypeCategory> FileTypeCategory { get; set; }
        string MimeType { get; set; }
        string Extension { get; set; }
        Nullable<int> MaxSize { get; set; }
    }
}
