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
    public class TimezoneManager<TRepository> : EntityManagerBase<string, string, Timezone, ITimezoneRepository<string, string, Timezone>>
        where TRepository : ITimezoneRepository<string, string, Timezone>
    {
        public TimezoneManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<Timezone>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
    }
}
