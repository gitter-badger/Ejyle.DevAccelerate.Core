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

namespace Ejyle.DevAccelerate.Core.Lists
{
    public class CountryManager<TCountryRepository> : CountryManager<Country, TCountryRepository>
        where TCountryRepository : ICountryRepository<string, string, Country>
    {
        public CountryManager(TCountryRepository repository)
            : base(repository)
        { }
    }

    public class CountryManager<TCountry, TCountryRepository> : CountryManager<string, string, TCountry, TCountryRepository>
        where TCountry : ICountry<string, string>
        where TCountryRepository : ICountryRepository<string, string, TCountry>
    {
        public CountryManager(TCountryRepository repository)
            : base(repository)
        { }
    }

    public class CountryManager<TKey, TOptionalKey, TCountry, TCountryRepository> : EntityManagerBase<TKey, TOptionalKey, TCountry, TCountryRepository>
        where TCountry : ICountry<TKey, TOptionalKey>
        where TCountryRepository : ICountryRepository<TKey, TOptionalKey, TCountry>
    {
        public CountryManager(TCountryRepository repository)
            : base(repository)
        { }

        public Task<List<TCountry>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
    }
}
