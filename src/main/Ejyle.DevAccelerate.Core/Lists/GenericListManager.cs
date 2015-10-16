// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejyle.DevAccelerate.Core.Lists;

namespace Ejyle.DevAccelerate.Core.EntityFramework.Lists
{
    public class GenericListManager<TRepository> : EntityManagerBase<string, string, GenericList, IGenericListRepository<string, string, GenericList>>
        where TRepository : IGenericListRepository<string, string, GenericList>
    {
        public GenericListManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<GenericList>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }

        public Task<GenericList> FindByNameAsync(string name)
        {
            return Repository.FindByNameAsync(name);
        }

        public Task AddListItemAsync(string genericListId, string text)
        {
            return Repository.AddListItemAsync(genericListId, text);
        }

        public Task RemoveListItemAsync(string listItemId)
        {
            return Repository.RemoveListItemAsync(listItemId);
        }
    }
}
