// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Lists
{
    public interface IGenericListRepository<TKey, TOptionalKey, TGenericList> : IEntityRepository<TKey, TOptionalKey, TGenericList>
        where TGenericList : IGenericList<TKey, TOptionalKey>
    {
        Task<List<TGenericList>> FindAllAsync();
        Task<TGenericList> FindByNameAsync(string name);
        Task AddListItemAsync(TKey genericListId, string text);
        Task RemoveListItemAsync(TKey listItemId);
    }
}
