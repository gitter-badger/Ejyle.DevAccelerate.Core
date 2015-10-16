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

    public class AppMapping : AppMapping<string, string,AppGroup> 
    {
        public AppMapping()
            : base()
        { }
    }

    public class AppMapping<TAppGroup> : AppMapping<string, string, TAppGroup>
        where TAppGroup : IAppGroup<string, string>
        
    {
        public AppMapping()
            : base()
        { }
    }
    public class AppMapping<TKey, TOptionalKey, TAppGroup> : EntityBase<TKey, TOptionalKey>, IAppMapping<TKey, TOptionalKey>
        where TAppGroup : IAppGroup<TKey, TOptionalKey>
        
    {
        public AppMapping()
            : base()
        {
        }

        public TKey AppId { get; set; }
        public TKey AppGroupId { get; set; }

    }
}
