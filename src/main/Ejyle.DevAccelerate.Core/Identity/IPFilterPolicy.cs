// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class IPFilterPolicy : IPFilterPolicy<FilteredIP, App>
    {
        public IPFilterPolicy()
            : base()
        { }
    }

    public class IPFilterPolicy<TFilteredIP, TApp> : IPFilterPolicy<string, string, TFilteredIP, TApp>
        where TFilteredIP : IFilteredIP<string, string>
        where TApp : IApp<string, string>
    { }

    public class IPFilterPolicy<TKey, TOptionalKey, TFilteredIP, TApp> : EntityBase<TKey, TOptionalKey>, IIPFilterPolicy<TKey, TOptionalKey>
        where TFilteredIP : IFilteredIP<TKey, TOptionalKey>
        where TApp : IApp<TKey, TOptionalKey>
    {
        public IPFilterPolicy()
            : base()
        {
            IPExceptions = new HashSet<TFilteredIP>();
            Applications = new HashSet<TApp>();
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public bool IsAllowedByDefault
        {
            get;
            set;
        }

        public virtual ICollection<TFilteredIP> IPExceptions
        {
            get;
            set;
        }

        public virtual ICollection<TApp> Applications
        {
            get;
            set;
        }
    }
}
