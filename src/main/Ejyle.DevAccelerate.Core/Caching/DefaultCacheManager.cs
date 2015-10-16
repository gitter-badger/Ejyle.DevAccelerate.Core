// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Caching
{
    public class DefaultCacheManager : ICacheManager
    {
        ObjectCache cache = null;
        CacheItemPolicy policy = null;

        public DefaultCacheManager()
        {
            cache = MemoryCache.Default;
            policy = new CacheItemPolicy();
        }

        public CachingConfigurationSection GetSettings()
        {
            throw new NotImplementedException();
        }

        public void Add(string key, object data)
        {
            cache.Set(key, data, policy);
        }

        public object GetData(string key)
        {
            return cache[key] as string;
        }

        public long Count
        {
            get
            {
                return cache.GetCount();
            }
        }

        public void Flush()
        {
            // Ignore
        }

        public bool Contains(string key)
        {
            return cache.Contains(key);
        }
    }
}
