// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;

namespace Ejyle.DevAccelerate.Core.Lists
{
    public class GenericListItem : GenericListItem<GenericList>
    { }

    public class GenericListItem<TGenericList> : GenericListItem<string, string, TGenericList>
        where TGenericList : IGenericList<string, string>
    {
    }

    public class GenericListItem<TKey, TOptionalKey, TGenericList> : EntityBase<TKey, TOptionalKey>, IGenericListItem<TKey, TOptionalKey>
        where TGenericList : IGenericList<TKey, TOptionalKey>
    {
        public TKey GenericListId { get; set; }
        public string Text { get; set; }
        public virtual TGenericList GenericList { get; set; }
    }
}
