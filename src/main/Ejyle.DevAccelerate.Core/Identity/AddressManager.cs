// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejyle.DevAccelerate.Core.Identity;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class AddressManager<TRepository> : EntityManagerBase<string, string, Address, IAddressRepository<string, string, Address>>
        where TRepository : IAddressRepository<string, string, Address>
    {
        public AddressManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<Address>> FindByUserIdAsync(string userId)
        {
            return Repository.FindByUserIdAsync(userId);
        }
    }
}
