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
    public class AppResourceAction : AppResourceAction<AppResource>
    {
        public AppResourceAction()
            : base()
        { }
    }

    public class AppResourceAction<TAppResource> : AppResourceAction<string, string, TAppResource>
        where TAppResource : IAppResource<string, string>
    {
        public AppResourceAction()
            : base()
        { }
    }

    public class AppResourceAction<TKey, TOptionalKey, TAppResource> : EntityBase<TKey, TOptionalKey>, IAppResourceAction<TKey, TOptionalKey>
        where TAppResource : IAppResource<TKey, TOptionalKey>
    {
        public AppResourceAction()
            : base()
        { }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public string Data
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
        public TKey AppResourceId
        {
            get;
            set;
        }

        public TAppResource AppResource
        {
            get;
            set;
        }
    }
}
