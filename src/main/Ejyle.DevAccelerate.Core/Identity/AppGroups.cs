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
    public class AppGroup : AppGroup<AppMapping>
    {
        public AppGroup()
            : base()
        { }
    }
    public class AppGroup<TAppMapping> : AppGroup<string, string, TAppMapping>
        where TAppMapping : IAppMapping<string, string> 
    {
        public AppGroup()
            : base()
        { }
    }


    public class AppGroup<TKey, TOptionalKey, TAppMapping> : EntityBase<TKey, TOptionalKey>, IAppGroup<TKey, TOptionalKey>
        where TAppMapping : IAppMapping<TKey, TOptionalKey>
    {
        public AppGroup()
            : base()
        {
          
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string Title
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

        public TOptionalKey AppMappingId
        {
            get;
            set;
        }
        public virtual TAppMapping AppMapping
        {
            get;
            set;
        }
        public virtual ICollection<App> Applications { get; set; }
    }
}
