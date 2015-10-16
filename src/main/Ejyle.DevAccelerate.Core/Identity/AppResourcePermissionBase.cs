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
    public class AppResourcePermissionBase<TKey, TOptionalKey> : EntityBase<TKey, TOptionalKey>, IAppResourcePermission<TKey, TOptionalKey>
    {
        public AppResourcePermissionBase()
            : base()
        { }

        public TKey AppResourceId
        {
            get;
            set;
        }

        public TKey AppResourceActionId
        {
            get;
            set;
        }

        public bool? IsAllowed
        {
            get;
            set;
        }
    }
}
