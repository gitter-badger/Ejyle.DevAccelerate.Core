// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class IPFilterPolicyManager<TIPFilterPolicyRepository> : IPFilterPolicyManager<IPFilterPolicy, TIPFilterPolicyRepository>
        where TIPFilterPolicyRepository : IIPFilterPolicyRepository<string, string, IPFilterPolicy>
    {
        public IPFilterPolicyManager(TIPFilterPolicyRepository repository)
            : base(repository)
        { }
    }

    public class IPFilterPolicyManager<TIPFitlerPolicy, TIPFilterPolicyRepository> : IPFilterPolicyManager<string, string, TIPFitlerPolicy, TIPFilterPolicyRepository>
        where TIPFitlerPolicy : IIPFilterPolicy<string, string>
        where TIPFilterPolicyRepository : IIPFilterPolicyRepository<string, string, TIPFitlerPolicy>
    {
        public IPFilterPolicyManager(TIPFilterPolicyRepository repository)
            : base(repository)
        { }
    }

    public class IPFilterPolicyManager<TKey, TOptionalKey, TIPFilterPolicy, TIPFilterPolicyRepository> : EntityManagerBase<TKey, TOptionalKey, TIPFilterPolicy, TIPFilterPolicyRepository>
        where TIPFilterPolicy : IIPFilterPolicy<TKey, TOptionalKey>
        where TIPFilterPolicyRepository : IIPFilterPolicyRepository<TKey, TOptionalKey, TIPFilterPolicy>
    {
        public IPFilterPolicyManager(TIPFilterPolicyRepository repository)
            : base(repository)
        { }

        public Task<List<TIPFilterPolicy>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
        public Task CreateFilteredIpAsync(FilteredIP obj)
        {
            return Repository.CreateFilteredIpAsync(obj);
        }
        public Task UpdateFilteredIPAsync(FilteredIP obj)
        {
            return Repository.UpdateFilteredIPAsync(obj);
        }
        public Task DeleteFilteredIPAsync(FilteredIP obj)
        {
            return Repository.DeleteFilteredIPAsync(obj);
        }
        public Task<FilteredIP> FindFilteredIPByIdAsync(string Id)
        {
            return Repository.FindFilteredIPByIdAsync(Id);
        }
    }
}
