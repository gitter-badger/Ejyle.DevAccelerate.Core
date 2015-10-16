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
    public class AppResource : AppResource<string, string, App, AppResourceAction>
    {
        public AppResource()
            : base()
        {
            Children = new HashSet<AppResource>();
        }

        public virtual ICollection<AppResource> Children { get; set; }

        public virtual AppResource Parent { get; set; }
    }

    public class AppResource<TApp, TAppResourceAction> : AppResource<string, string, TApp, TAppResourceAction>
        where TApp : IApp<string, string>
        where TAppResourceAction : IAppResourceAction<string, string>
    {
        public AppResource()
            : base()
        { }
    }

    public class AppResource<TKey, TOptionalKey, TApp, TAppResourceAction> : EntityBase<TKey, TOptionalKey>, IAppResource<TKey, TOptionalKey>
        where TApp : IApp<TKey, TOptionalKey>
        where TAppResourceAction : IAppResourceAction<TKey, TOptionalKey>
    {
        public AppResource()
            : base()
        {
            Actions = new HashSet<TAppResourceAction>();
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public TKey AppId
        {
            get;
            set;
        }

        public virtual TApp App
        {
            get;
            set;
        }

        public TOptionalKey ParentId
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

        public virtual ICollection<TAppResourceAction> Actions
        {
            get;
            set;
        }
    }
}