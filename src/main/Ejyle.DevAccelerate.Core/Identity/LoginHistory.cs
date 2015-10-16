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
    public class LoginHistory : LoginHistory<string, string>
    { }

    public class LoginHistory<TKey, TOptionalKey> : EntityBase<TKey, TOptionalKey>, ILoginHistory<TKey, TOptionalKey>
    {
        public TKey UserId
        {
            get;
            set;
        }

        [StringLength(30)]
        public string IpAddress
        {
            get;
            set;
        }

        [StringLength(255)]
        public string SessionId
        {
            get;
            set;
        }

        public LoginAction Action
        {
            get;
            set;
        }

        public bool IsSuccessful
        {
            get;
            set;
        }
    }
}
