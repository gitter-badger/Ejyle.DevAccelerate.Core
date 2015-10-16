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
    public class App : App<IPFilterPolicy, AppResource>
    {
        public App()
            : base()
        { }
    }

    public class App<TIPFilterPolicy, TAppResource> : App<string, string, TIPFilterPolicy, TAppResource>
        where TIPFilterPolicy : IIPFilterPolicy<string, string>
        where TAppResource : IAppResource<string, string>
    {
        public App()
            : base()
        { }
    }

    public class App<TKey, TOptionalKey, TIPFilterPolicy, TAppResource> : EntityBase<TKey, TOptionalKey>, IApp<TKey, TOptionalKey>
        where TIPFilterPolicy : IIPFilterPolicy<TKey, TOptionalKey>
        where TAppResource : IAppResource<TKey, TOptionalKey>
    {
        public App()
            : base()
        {
            Resources = new HashSet<TAppResource>();
        }

        [Required]
        [StringLength(255)]
        public string Title
        {
            get;
            set;
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public bool IsArchived
        {
            get;
            set;
        }

        public DateTime? ArchivedDate
        {
            get;
            set;
        }

        public TOptionalKey IPFilterPolicyId
        {
            get;
            set;
        }

        public virtual TIPFilterPolicy IPFilterPolicy
        {
            get;
            set;
        }

        public virtual ICollection<TAppResource> Resources
        {
            get;
            set;
        }
    }
}
