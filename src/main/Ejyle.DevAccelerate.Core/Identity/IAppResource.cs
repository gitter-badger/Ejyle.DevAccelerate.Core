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
    public interface IAppResource<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name
        {
            get;
            set;
        }

        string Title
        {
            get;
            set;
        }
        bool IsActive
        {
            get;
            set;
        }
        bool IsArchived
        {
            get;
            set;
        }

        DateTime? ArchivedDate
        {
            get;
            set;
        }

        TKey AppId
        {
            get;
            set;
        }

        TOptionalKey ParentId
        {
            get;
            set;
        }
    }
}
