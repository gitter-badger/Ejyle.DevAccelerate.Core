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
    public class Currency : Currency<Country>
    {}

    public class Currency<TCountry> : Currency<string, string, TCountry>
        where TCountry : ICountry<string, string>
    {
        public Currency()
            : base()
        { }
    }

    public class Currency<TKey, TOptionalKey, TCountry> : EntityBase<TKey, TOptionalKey>, ICurrency<TKey, TOptionalKey>
        where TCountry : ICountry<TKey, TOptionalKey>
    {
        public Currency()
        {
            Countries = new HashSet<TCountry>();
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(10)]
        public string CurrencySymbol { get; set; }

        [StringLength(20)]
        public string CurrencyCode { get; set; }
        public virtual ICollection<TCountry> Countries { get; set; }
    }
}
