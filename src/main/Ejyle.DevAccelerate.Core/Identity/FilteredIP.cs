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
    public class FilteredIP : FilteredIP<IPFilterPolicy>
    {
        public FilteredIP()
            : base()
        { }
    }

    public class FilteredIP<TIPFilterPolicy> : FilteredIP<string, string, TIPFilterPolicy>
       where TIPFilterPolicy : IIPFilterPolicy<string, string>
    { }

    public class FilteredIP<TKey, TOptionalKey, TIPFilterPolicy> : EntityBase<TKey, TOptionalKey>, IFilteredIP<TKey, TOptionalKey>
         where TIPFilterPolicy : IIPFilterPolicy<TKey, TOptionalKey>
    {
        public FilteredIP()
            : base()
        { }

        public TKey IPFilterPolicyId
        {
            get;
            set;
        }

        public bool? IsAllowed
        {
            get;
            set;
        }

        public string FromIPAddress
        {
            get;
            set;
        }
        public string ToIPAddress
        {
            get;
            set;
        }

        public virtual TIPFilterPolicy IPFilterPolicy
        {
            get;
            set;
        }
    }
}
