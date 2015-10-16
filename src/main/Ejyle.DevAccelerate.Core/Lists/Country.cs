// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Lists
{
    public class Country : Country<Currency>
    { }

    public class Country<TCurrency> : Country<string, string, TCurrency>
        where TCurrency : ICurrency<string, string>
    {
        public Country()
            : base()
        { }
    }

    public class Country<TKey, TOptionalKey, TCurrency> : EntityBase<TKey, TOptionalKey>, ICountry<TKey, TOptionalKey>
        where TCurrency : ICurrency<TKey, TOptionalKey>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CountryCode { get; set; }

        [StringLength(10)]
        public string DialingCode { get; set; }

        public TKey DefaultCurrencyId { get; set; }
        public virtual TCurrency Currency { get; set; }
    }
}
