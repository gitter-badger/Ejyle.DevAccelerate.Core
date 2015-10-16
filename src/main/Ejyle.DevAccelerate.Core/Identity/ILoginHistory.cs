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
    public interface ILoginHistory<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        TKey UserId
        {
            get;
            set;
        }

        string IpAddress
        {
            get;
            set;
        }

        string SessionId
        {
            get;
            set;
        }

        LoginAction Action
        {
            get;
            set;
        }

        bool IsSuccessful
        {
            get;
            set;
        }
    }
}
