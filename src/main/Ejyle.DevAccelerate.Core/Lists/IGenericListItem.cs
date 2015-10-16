// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Lists
{
    public interface IGenericListItem<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        TKey GenericListId { get; set; }
        string Text { get; set; }
    }
}
