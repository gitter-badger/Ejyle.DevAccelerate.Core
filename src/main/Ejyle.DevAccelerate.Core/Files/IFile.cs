// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Files
{
    public interface IFile<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string FileName { get; set; }
        string Name { get; set; }
        Nullable<int> FileSize { get; set; }
        string UserPath { get; set; }
        string Notes { get; set; }
        TKey FileOwner { get; set; }
        TKey FileLocationId { get; set; }
    }
}
